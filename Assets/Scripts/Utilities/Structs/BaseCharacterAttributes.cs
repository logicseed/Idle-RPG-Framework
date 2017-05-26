using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public struct BaseCharacterAttributes
{
    [HelpBox("These are unscaled values that represent how skilled a character is in a " +
             "particular attribute. These attributes range from inept (1) to average (50) " +
             "to godlike (100). These values will be scaled to provide the final attributes " +
             "of a character.\n", HelpBoxMessageType.Information)]
    [Range(1,100)]
    public int attackDamage;

    [Range(1, 100)]
    public int abilityDamage;

    [Range(1, 100)]
    public int attackSpeed;

    [Range(1, 100)]
    public int criticalHitChance;

    [Range(1, 100)]
    public int criticalHitDamage;

    [Range(1, 100)]
    public int defense;

    [Range(1, 100)]
    public int cooldownReduction;

    [Range(1, 100)]
    public int health;

    [Range(1, 100)]
    public int healthRegeneration;

    [Range(1, 100)]
    public int energy;

    [Range(1, 100)]
    public int energyRegeration;

    [Range(1, 100)]
    public int lifeDrain;

    [Range(1, 100)]
    public int movementSpeed;
}
