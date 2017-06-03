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
    public GameObject target;
    public CharacterManager character;
    public int currentHealth;
    public int currentEnergy;
    private float lastAttackTime;

    protected virtual void Start()
    {
        character = GetComponent<CharacterManager>();
        currentHealth = character.attributes.health;
        currentEnergy = character.attributes.energy;
        lastAttackTime = Time.time - (1/character.attributes.attackSpeed);
    }

    protected virtual void Update()
    {
        if (character.state == CharacterState.Dead) return;
        UpdateTarget();
        PerformCombatRound();
    }

    /// <summary>
    /// Finds an appropriate target for the character if one exists on the stage.
    /// </summary>
    public virtual void UpdateTarget()
    {
        if (target == null || 
            target.GetComponent<CharacterManager>().state == CharacterState.Dead)
        {
            try
            {
                switch (character.type)
                {
                    case CharacterType.Ally:
                        GetClosestHostile(GameManager.Instance.AllEnemies);
                        break;

                    case CharacterType.Boss:
                    case CharacterType.Enemy:
                        GetClosestHostile(GameManager.Instance.AllFriendlies);
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                character = GetComponent<CharacterManager>();
            }
        }
    }

    internal void ApplyStun(float potency)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds the closest hostile on the stage.
    /// </summary>
    /// <param name="hostiles">A list of hostile GameObjects.</param>
    protected void GetClosestHostile(List<GameObject> hostiles)
    {
        GameObject closestHostile = null;
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

    /// <summary>
    ///
    /// </summary>
    public virtual void PerformCombatRound()
    {
        // Make sure we can attack
        if (target == null ||
            !IsTargetInRange() ||
            !IsTimeToAttack()
        ) return;

        FaceTarget();

        // Character passes all attack checks, and it can attack

        // Update state
        character.state = CharacterState.Idle; // Make sure event is fired.
        character.state = CharacterState.Melee; //TODO: Add ranged

        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);

        // Apply damage
        target.GetComponent<CombatController>().ApplyDamage(damage, criticalModifier > 1);
        lastAttackTime = Time.time;
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
        var textControler = textObject.GetComponent<CombatTextController>();
        if (isCritical)
        {
            textControler.text = "CRITICAL " + unblockedDamage;
            textControler.color = Color.red;
        }
        else
        {
            textControler.text = unblockedDamage.ToString();
            textControler.color = Color.yellow;
        }

        if (unblockedDamage > 0) currentHealth -= unblockedDamage;

        if (currentHealth < 1) character.state = CharacterState.Dead;
    }

    protected bool IsTargetInRange()
    {
        var distanceSqr = transform.position.SqrDistance(target.transform.position);

        // Add a little variance
        var attackRangeSqr = MovementController.SEEK_TARGET_DISTANCE_SQR +
            (MovementController.SEEK_TARGET_DISTANCE_SQR * 0.1); // 10% error

        return distanceSqr <= attackRangeSqr;
    }

    protected bool IsTimeToAttack()
    {
        // Since attack speed is in (attacks/sec) finding the reciprical
        // will give us (secs/attack)
        var attackTime = 1 / character.attributes.attackSpeed;

        return Time.time - lastAttackTime >= attackTime;
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
