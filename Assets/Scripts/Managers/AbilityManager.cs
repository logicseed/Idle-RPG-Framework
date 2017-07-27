using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public class AbilityManager : WorldEntityManager
{
    public override int MaximumAmount { get { return GameManager.GameSettings.MaximumAssignedAbilities; } }
    public override string ResourcePath { get { return GameManager.GameSettings.AbilitiesPath; } }

    public AbilityManager(SaveGame save = null) : base(save) { }

    public override void Load(SaveGame save)
    {
        if (save != null)
        {
            foreach (var ability in save.unlockedAbilities) AddUnlocked(ability);
            foreach (var ability in save.assignedAbilities) AddAssigned(ability);
        }
    }

    public override void Save(ref SaveGame save)
    {
        save.unlockedAbilities = unlocked;
        save.assignedAbilities = assigned;
    }
}
