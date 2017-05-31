using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public struct BaseAttributes
{
    [HelpBox("These are unscaled values that represent how skilled a character is in a " +
             "particular attribute. These attributes range from inept (1) to average (50) " +
             "to godlike (100). These values will be scaled to provide the final attributes " +
             "of a character.\n", HelpBoxMessageType.Information)]
    [Range(0,100)]
    public int attackDamage;

    [Range(0, 100)]
    public int abilityDamage;

    [Range(0, 100)]
    public int defense;

    [Range(0, 100)]
    public int health;

    [Range(0, 100)]
    public int healthRegeneration;

    [Range(0, 100)]
    public int energy;

    [Range(0, 100)]
    public int energyRegeneration;

    [Range(0, 100)]
    public int attackSpeed;

    [Range(0, 100)]
    public int criticalHitChance;

    [Range(0, 100)]
    public int criticalHitDamage;

    [Range(0, 100)]
    public int cooldownReduction;

    [Range(0, 100)]
    public int lifeDrain;

    [Range(0, 100)]
    public int movementSpeed;

    public static BaseAttributes operator +(BaseAttributes attributesA, BaseAttributes attributesB)
    {
        var attributes = new BaseAttributes();

        attributes.attackDamage = attributesA.attackDamage + attributesB.attackDamage;
        attributes.abilityDamage = attributesA.abilityDamage + attributesB.abilityDamage;
        attributes.defense = attributesA.defense + attributesB.defense;
        attributes.health = attributesA.health + attributesB.health;
        attributes.healthRegeneration = attributesA.healthRegeneration + attributesB.healthRegeneration;
        attributes.energy = attributesA.energy + attributesB.energy;
        attributes.energyRegeneration = attributesA.energyRegeneration + attributesB.energyRegeneration;
        attributes.attackSpeed = attributesA.attackSpeed + attributesB.attackSpeed;
        attributes.criticalHitChance = attributesA.criticalHitChance + attributesB.criticalHitChance;
        attributes.criticalHitDamage = attributesA.criticalHitDamage + attributesB.criticalHitDamage;
        attributes.cooldownReduction = attributesA.cooldownReduction + attributesB.cooldownReduction;
        attributes.lifeDrain = attributesA.lifeDrain + attributesB.lifeDrain;
        attributes.movementSpeed = attributesA.movementSpeed + attributesB.movementSpeed;

        return attributes;
    }
}
