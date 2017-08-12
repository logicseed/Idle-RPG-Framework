using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

/// <summary>
///
/// </summary>
public class CombatController : MonoBehaviour
{
    public GameCharacterController target;
    public GameCharacterController character;
    public int currentHealth;
    public int currentEnergy;
    protected float lastAttackTime;

    protected virtual void Start()
    {
        character = GetComponent<GameCharacterController>();
        currentHealth = character.attributes.health;
        currentEnergy = character.attributes.energy;
        lastAttackTime = Time.time - (1/character.attributes.attackSpeed);
    }

    protected virtual void Update()
    {
        if (character.state == CharacterState.Dead) return;
        if (!character.isCombatDummy)
        {
            UpdateTarget();
            PerformCombatRound();
        }
    }

    public float DesiredRange
    {
        get
        {
            if (character.attack == AttackType.Ranged) return GameManager.GameSettings.Constants.Range.RangedAttack;
            else if (character.attack == AttackType.Caster) return GameManager.GameSettings.Constants.Range.CasterAttack;
            else return GameManager.GameSettings.Constants.Range.MeleeAttack;
        }
    }

    internal void ApplyStun(float potency)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds an appropriate target for the character if one exists on the stage.
    /// </summary>
    public virtual void UpdateTarget()
    {
        if (target == null ||
            target.GetComponent<GameCharacterController>().state == CharacterState.Dead)
        {
            switch (character.type)
            {
                case CharacterType.Ally:
                    GetClosestHostile(GameManager.AllEnemies);
                    break;

                case CharacterType.Boss:
                case CharacterType.Enemy:
                    GetClosestHostile(GameManager.AllFriendlies);
                    break;
                default:
                    break;
            }
        }
    }

    protected void GetClosestHostile(List<GameCharacterController> hostiles)
    {
        GameCharacterController closestHostile = null;
        var closestSquaredDistance = Mathf.Infinity;

        foreach (var hostile in hostiles)
        {
            var directionToHostile = hostile.transform.position - transform.position;
            var squaredDistance = directionToHostile.sqrMagnitude;

            if (squaredDistance < closestSquaredDistance)
            {
                closestSquaredDistance = squaredDistance;
                closestHostile = hostile;
            }
        }

        target = closestHostile;
    }

    public virtual void PerformCombatRound()
    {
        // Make sure we can attack
        if (!CanAttack) return;

        FaceTarget();

        // Character passes all attack checks, and it can attack
        if (character.attack == AttackType.Caster) PerformCasterAttack();
        else if (character.attack == AttackType.Ranged) PerformRangedAttack();
        else PerformMeleeAttack();

        lastAttackTime = Time.time;
    }

    public virtual void PerformMeleeAttack()
    {
        // Update state
        character.state = CharacterState.Idle; // Make sure event is fired.
        character.state = CharacterState.Melee; //TODO: Add ranged

        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);

        // Apply damage
        target.GetComponent<CombatController>().ApplyDamage(damage, criticalModifier > 1);
    }

    public virtual void PerformCasterAttack()
    {
        // Update state
        character.state = CharacterState.Idle; // Make sure event is fired.
        character.state = CharacterState.Cast;
        var length = character.animatorReference.runtimeAnimatorController.animationClips[1].length;
        Invoke("SpawnCasterball", length);
    }

    public virtual void PerformRangedAttack()
    {
        // Update state
        character.state = CharacterState.Idle; // Make sure event is fired.
        character.state = CharacterState.Ranged;
        var length = character.animatorReference.runtimeAnimatorController.animationClips[10].length / 2;
        Invoke("SpawnArrow", length);
    }

    public void SpawnArrow()
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Arrow, transform.position, damage, target, criticalModifier);
    }

    public void SpawnCasterball()
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.abilityDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Casterball, transform.position, damage, target, criticalModifier);
    }

    public void SpawnProjectile(GameObject prefab, Vector3 location, int damage, GameCharacterController target, float criticalModifier)
    {
        var projectileGO = Instantiate(prefab, location, Quaternion.identity) as GameObject;
        var projectile = projectileGO.GetComponent<DirectAbilityController>();
        projectile.target = target;
        projectile.damage = damage;
        projectile.criticalModifier = criticalModifier;
    }

    private bool CanAttack
    {
        get
        {
            return target != null
                && character.state != CharacterState.Dead
                && character.state != CharacterState.Walk
                && character.state != CharacterState.Defend
                && target.state != CharacterState.Dead
                && HasHostileTarget 
                && HasTargetInRange 
                && IsTimeToAttack;
        }
    }

    public bool HasHostileTarget
    {
        get
        {
            var targetType = target.GetComponent<GameCharacterController>().type;

            if (character.type == CharacterType.Ally || character.type == CharacterType.Hero)
                return targetType == CharacterType.Enemy || targetType == CharacterType.Boss;

            if (character.type == CharacterType.Enemy || character.type == CharacterType.Boss)
                return targetType == CharacterType.Ally || targetType == CharacterType.Hero;

            return false;
        }
    }

    private void FaceTarget()
    {
        if (target.transform.position.x > transform.position.x)
        {
            character.direction = MoveDirection.Right;
        }
        else if (target.transform.position.x < transform.position.x)
        {
            character.direction = MoveDirection.Left;
        }
    }

    public virtual void ApplyDamage(int damage, bool isCritical = false)
    {
        var unblockedDamage = damage - character.attributes.defense;

        var textObject = Instantiate(GameManager.GameSettings.Prefab.UI.CombatText, transform);
        var textController = textObject.GetComponent<CombatTextController>();

        if (unblockedDamage <= 0)
        {
            textController.text = GameManager.GameSettings.Constants.CombatText.BlockedText;
            textController.color = GameManager.GameSettings.Constants.Colors.CombatTextBlocked;
        }

        if (isCritical)
        {
            textController.text = GameManager.GameSettings.Constants.CombatText.CriticalText + " " + unblockedDamage;
            textController.color = GameManager.GameSettings.Constants.Colors.CombatTextCritical;
        }
        else
        {
            textController.text = GameManager.GameSettings.Constants.CombatText.NormalText + " " + unblockedDamage;
            textController.color = GameManager.GameSettings.Constants.Colors.CombatTextNormal;
        }

        if (unblockedDamage > 0 && !character.isCombatDummy) currentHealth -= unblockedDamage;

        if (currentHealth < 1)
        {
            character.state = CharacterState.Dead;
            if (!character.IsFriendly)
            {
                ApplyExperience();
                ApplyReward();
            }
            character.Unregister();
            Invoke("Despawn", 1.0f);
        }
    }

    public void Despawn()
    {
        Destroy(gameObject);
    }

    public void ApplyExperience()
    {
        GameManager.HeroManager.experience += (int)(character.level * GameManager.GameSettings.Constants.ExperiencePerLevel);
    }

    public void ApplyReward()
    {
        GameManager.StageManager.GetReward();
    }

    public bool HasTargetInRange
    {
        get
        {
            var distanceSqr = transform.position.SqrDistance(target.transform.position);

            // Add a little variance
            var attackRangeSqr = DesiredRange * DesiredRange +
                (DesiredRange * DesiredRange * 0.1); // 10% error

            return distanceSqr <= attackRangeSqr;
        }
    }

    public bool IsTimeToAttack
    {
        get
        {
            // Since attack speed is in (attacks/sec) finding the reciprical
            // will give us (secs/attack)
            var attackTime = 1 / character.attributes.attackSpeed;

            return Time.time - lastAttackTime >= attackTime;
        }
    }

    protected float CriticalModifier()
    {
        if (Random.Range(0.0f, 1.0f) <= character.attributes.criticalHitChance)
        {
            return character.attributes.criticalHitDamage;
        }
        return 1.0f;
    }
}
