using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
///
/// </summary>
public class CombatController : MonoBehaviour
{
    public GameObject target;
    public CharacterManager character;
    public int currentHealth;
    public int currentEnergy;

    protected virtual void Start()
    {
        character = GetComponent<CharacterManager>();
    }

    protected virtual void Update()
    {
        UpdateTarget();
        PerformCombatRound();
    }

    /// <summary>
    /// Finds an appropriate target for the character if one exists on the stage.
    /// </summary>
    public virtual void UpdateTarget()
    {
        if (target == null)
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

        if (closestHostile != null) target = closestHostile;
    }

    /// <summary>
    ///
    /// </summary>
    public virtual void PerformCombatRound()
    {

    }


    public virtual void ApplyDamage(int damage)
    {
        var unblockedDamage = damage - character.attributes.defense;

        if (unblockedDamage > 0) currentHealth -= unblockedDamage;

        if (currentHealth < 1) character.state = CharacterState.Dead;
    }
}
