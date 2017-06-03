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
            target.GetComponent<CharacterManager>().state == CharacterState.Dead)
        {
            target = null;
        }
    }
}
