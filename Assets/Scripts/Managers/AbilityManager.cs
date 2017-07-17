using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public class AbilityManager
{
    public const int MAX_ACTIVE_ABILITY = 3;
    public const string ABILITY_PATH = "Abilities/";

    public List<string> unlockedAbilities;
    public Dictionary<string, Ability> abilityObjects;
    public List<string> assignedAbilities;

    private AbilityManager()
    {
        unlockedAbilities = new List<string>();
        abilityObjects = new Dictionary<string, Ability>();
        assignedAbilities = new List<string>();
    }

    public void AddToActive(string ability)
    {
        if (!assignedAbilities.Contains(ability) && assignedAbilities.Count < MAX_ACTIVE_ABILITY)
        {
            assignedAbilities.Add(ability);
        }
    }

    public void RemoveFromActive(string ability)
    {
        if (assignedAbilities.Contains(ability))
        {
            assignedAbilities.Remove(ability);
        }
    }

    public void AddToAbilities(string ability)
    {
        if (!unlockedAbilities.Contains(ability))
        {
            unlockedAbilities.Add(ability);
            var abilityObject = Resources.Load(ABILITY_PATH + ability) as Ability;
            abilityObjects.Add(ability, abilityObject);
        }
    }

    public void RemoveFromAbilities(string ability)
    {
        if (unlockedAbilities.Contains(ability))
        {
            unlockedAbilities.Remove(ability);
            abilityObjects.Remove(ability);
            if (assignedAbilities.Contains(ability)) assignedAbilities.Remove(ability);
        }
    }

    public Ability GetAbility(string ability)
    {
        if (unlockedAbilities.Contains(ability))
        {
            if (abilityObjects.ContainsKey(ability))
            {
                return abilityObjects[ability];
            }
            else
            {
                var abilityObject = Resources.Load(ABILITY_PATH + ability) as Ability;
                abilityObjects.Add(ability, abilityObject);
                return abilityObject;
            }
        }
        return Resources.Load(ABILITY_PATH + ability) as Ability;
    }

    public List<Ability> GetActiveAbilities()
    {
        var abilities = new List<Ability>();

        foreach (var ability in assignedAbilities)
        {
            abilities.Add(abilityObjects[ability]);
        }

        return abilities;
    }

    internal void Save(ref SaveGame save)
    {
        save.unlockedAbilities = unlockedAbilities;
        save.assignedAbilities = assignedAbilities;
    }

    public static AbilityManager Load(SaveGame save)
    {
        var abilityManager = new AbilityManager();

        if (save != null)
        {
            foreach (var ability in save.unlockedAbilities)
            {
                abilityManager.AddToAbilities(ability);
            }

            foreach (var ability in save.assignedAbilities)
            {
                abilityManager.AddToActive(ability);
            }
        }

        return abilityManager;
    }
}
