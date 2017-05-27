using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
///
/// </summary>
public abstract class BaseCombatController : MonoBehaviour
{
    public GameObject characterTarget;
    public BaseCharacterAttributeManager attributeManager;

    private void Start()
    {
        attributeManager = GetComponent<BaseCharacterAttributeManager>();
    }

    private void Update()
    {
        UpdateCharacterTarget();
    }

    public virtual void UpdateCharacterTarget()
    {
        if (characterTarget == null)
        {
            try
            {
                switch (attributeManager.characterType)
                {
                    case CharacterType.Ally:
                        GameObject closestEnemy = null;

                        foreach (var enemy in GameManager.Instance.enemies)
                        {
                            if (closestEnemy == null)
                            {
                                closestEnemy = enemy;
                                continue;
                            }

                            var currentDistance = Vector2.Distance(transform.position, closestEnemy.transform.position);
                            var newDistance = Vector2.Distance(transform.position, enemy.transform.position);

                            if (newDistance < currentDistance) closestEnemy = enemy;
                        }

                        if (closestEnemy != null) characterTarget = closestEnemy;
                        break;

                    case CharacterType.Boss:
                    case CharacterType.Enemy:
                        GameObject closestAlly = null;

                        foreach (var ally in GameManager.Instance.allies)
                        {
                            if (closestAlly == null)
                            {
                                closestAlly = ally;
                                continue;
                            }

                            var currentDistance = Vector2.Distance(transform.position, closestAlly.transform.position);
                            var newDistance = Vector2.Distance(transform.position, ally.transform.position);

                            if (newDistance < currentDistance) closestAlly = ally;
                        }

                        foreach (var hero in GameManager.Instance.hero)
                        {
                            if (closestAlly == null)
                            {
                                closestAlly = hero;
                                continue;
                            }

                            var currentDistance = Vector2.Distance(transform.position, closestAlly.transform.position);
                            var newDistance = Vector2.Distance(transform.position, hero.transform.position);

                            if (newDistance < currentDistance) closestAlly = hero;
                        }

                        if (closestAlly != null) characterTarget = closestAlly;
                        // find closest ally or hero
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                attributeManager = GetComponent<BaseCharacterAttributeManager>();
            }
        }
    }

    /// <summary>
    ///
    /// </summary>
    public abstract void PerformCombatRound();

    //public abstract void GetAttributeManager();
}
