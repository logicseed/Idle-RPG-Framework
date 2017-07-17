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
    public const float ATTACK_RANGE_MELEE = 0.5f;
    public const float ATTACK_RANGE_CASTER = 2.0f;
    public const float ATTACK_RANGE_RANGED = 3.0f;

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
            if (character.attack == AttackType.Ranged) return ATTACK_RANGE_RANGED;
            else if (character.attack == AttackType.Caster) return ATTACK_RANGE_CASTER;
            else return ATTACK_RANGE_MELEE;
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
        Invoke("SpawnFireball", length);
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
        SpawnProjectile("Arrow");
    }

    public void SpawnFireball()
    {
        SpawnProjectile("Fireball");
    }

    public void SpawnProjectile(string prefab)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);

        var projectileGO = Instantiate(Resources.Load(prefab), transform.position, Quaternion.identity) as GameObject;
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

        var textObject = Instantiate((GameObject)Resources.Load("UI/CombatText"), transform);
        var textController = textObject.GetComponent<CombatTextController>();
        if (isCritical)
        {
            textController.text = "CRITICAL " + unblockedDamage;
            textController.color = Color.red;
        }
        else
        {
            textController.text = unblockedDamage.ToString();
            textController.color = Color.yellow;
        }

        if (unblockedDamage > 0 && !character.isCombatDummy) currentHealth -= unblockedDamage;

        if (currentHealth < 1)
        {
            character.state = CharacterState.Dead;
            if (!character.IsFriendly)
            {
                ApplyExperience();
            }
            Invoke("Despawn", 1.0f);
        }
    }

    public void Despawn()
    {
        Destroy(gameObject);
    }

    public void ApplyExperience()
    {
        GameManager.HeroManager.experience += character.level * 1000;
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
        if (Random.Range(0.0f, 1.0f) <= character.attributes.critialHitChance)
        {
            return character.attributes.critialHitDamage;
        }
        return 1.0f;
    }
}
