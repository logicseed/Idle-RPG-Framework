using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class HeroCombatController : CombatController
{
    /// <summary>
    ///
    /// </summary>
    public override void PerformCombatRound()
    {
        base.PerformCombatRound();
    }

    /// <summary>
    /// 
    /// </summary>
    public override void UpdateTarget()
    {
        if (target != null &&
            target.GetComponent<GameCharacterController>().state == CharacterState.Dead)
        {
            target = null;
        }
    }

    protected override void Start()
    {
        character = GetComponent<HeroController>();
        currentHealth = character.attributes.health;
        currentEnergy = character.attributes.energy;
        lastAttackTime = Time.time - (1 / character.attributes.attackSpeed);
    }
}
