using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class AbilityManager : MonoBehaviour
{
    public const int MAX_ACTIVE_ABILITY = 3;

    public List<Ability> unlockedAbilities;
    public List<Ability> activeAbilities;

    /// <summary>
    ///
    /// </summary>
    /// <param name="ability"></param>
    public void AddActive(Ability ability)
    {
        if (!activeAbilities.Contains(ability) && activeAbilities.Count < MAX_ACTIVE_ABILITY)
        {
            activeAbilities.Add(ability);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ability"></param>
    public void RemoveActive(Ability ability)
    {
        if (activeAbilities.Contains(ability))
        {
            activeAbilities.Remove(ability);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ability"></param>
    public void AddUnlocked(Ability ability)
    {
        if (!unlockedAbilities.Contains(ability)) unlockedAbilities.Add(ability);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="ability"></param>
    public void RemoveUnlocked(Ability ability)
    {
        if (unlockedAbilities.Contains(ability)) unlockedAbilities.Remove(ability);
    }
}
