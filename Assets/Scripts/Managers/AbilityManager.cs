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
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Abilities.Unlocked; } }
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Abilities.Assigned; } }
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Abilities; } }

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
        save.unlockedAbilities = Unlocked;
        save.assignedAbilities = Assigned;
    }
}
