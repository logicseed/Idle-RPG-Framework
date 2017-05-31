using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DerivedAttributes
{
    // Attribute constants
    private const int FULL_ATTACK_DAMAGE = 100;
    private const int FULL_ABILITY_DAMAGE = 100;
    private const int FULL_DEFENSE = 50;
    private const int FULL_HEALTH = 500;
    private const int FULL_HEALTH_REGENERATION = 20;
    private const int FULL_ENERGY = 400;
    private const int FULL_ENERGY_REGENERATION = 15;
    private const float FULL_ATTACK_SPEED = 2.0f;
    private const float FULL_CRITICAL_HIT_CHANCE = 0.5f;
    private const float FULL_CRITICAL_HIT_DAMAGE = 2.0f;
    private const float FULL_COOLDOWN_REDUCTION = 0.5f;
    private const float FULL_LIFE_DRAIN = 0.5f;
    private const float FULL_MOVEMENT_SPEED = 0.5f;

    // Derived attributes
    private int attackDamageDerived;
    private int abilityDamageDerived;
    private int defenseDerived;
    private int healthDerived;
    private int healthRegenerationDerived;
    private int energyDerived;
    private int energyRegenerationDerived;
    private float attackSpeedDerived;
    private float criticalHitChanceDerived;
    private float criticalHitDamageDerived;
    private float cooldownReductionDerived;
    private float lifeDrainDerived;
    private float movementSpeedDerived;

    /// <summary>
    ///
    /// </summary>
    public int attackDamage { get { return attackDamageDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int abilityDamage { get { return abilityDamageDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int defense { get { return defenseDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int health { get { return healthDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int healthRegeneration { get { return healthRegenerationDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int energy { get { return energyDerived; } }

    /// <summary>
    ///
    /// </summary>
    public int energyRegeneration { get { return energyRegenerationDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float attackSpeed { get { return attackSpeedDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float critialHitChance { get { return criticalHitChanceDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float critialHitDamage { get { return criticalHitDamageDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float cooldownReduction { get { return cooldownReductionDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float lifeDrain { get { return lifeDrainDerived; } }

    /// <summary>
    ///
    /// </summary>
    public float movementSpeed { get { return movementSpeedDerived; } }

    private CharacterManager character;

    /// <summary>
    /// Constructor to create derived attributes from
    /// </summary>
    /// <param name="character"></param>
    public DerivedAttributes(CharacterManager character)
    {
        this.character = character;

        CalculateDerivedAttributes();
    }

    public void CalculateDerivedAttributes()
    {
        DeriveAttackDamage();
        DeriveAbilityDamage();
        DeriveDefense();
        DeriveHealth();
        DeriveHealthRegeneration();
        DeriveEnergy();
        DeriveEnergyRegeneration();
        DeriveAttackSpeed();
        DeriveCriticalHitChance();
        DeriveCriticalHitDamage();
        DeriveCooldownReduction();
        DeriveLifeDrain();
        DeriveMovementSpeed();
    }

    private float DeriveAttributeFloat(int baseAttribute, float fullValue, int bonusAttribute)
    {
        float derivedAttribute = baseAttribute;
        derivedAttribute += bonusAttribute;
        derivedAttribute /= 100f;
        derivedAttribute *= fullValue;
        derivedAttribute *= character.level;
        return derivedAttribute;
    }

    private int DeriveAttributeInt(int baseAttribute, int fullValue, int bonusAttribute)
    {
        return (int)DeriveAttributeFloat(baseAttribute, fullValue, bonusAttribute);
    }

    private void DeriveAttackDamage()
    {
        attackDamageDerived = DeriveAttributeInt(
            character.baseAttributes.attackDamage,
            FULL_ATTACK_DAMAGE,
            character.bonusAttributes.attackDamage);
    }

    private void DeriveAbilityDamage()
    {
        abilityDamageDerived = DeriveAttributeInt(
            character.baseAttributes.abilityDamage,
            FULL_ABILITY_DAMAGE,
            character.bonusAttributes.abilityDamage);
    }

    private void DeriveDefense()
    {
        defenseDerived = DeriveAttributeInt(
            character.baseAttributes.defense,
            FULL_DEFENSE,
            character.bonusAttributes.defense);
    }

    private void DeriveHealth()
    {
        healthDerived = DeriveAttributeInt(
            character.baseAttributes.health,
            FULL_HEALTH,
            character.bonusAttributes.health);
    }

    private void DeriveHealthRegeneration()
    {
        healthRegenerationDerived = DeriveAttributeInt(
            character.baseAttributes.healthRegeneration,
            FULL_HEALTH_REGENERATION,
            character.bonusAttributes.healthRegeneration);
    }

    private void DeriveEnergy()
    {
        energyDerived = DeriveAttributeInt(
            character.baseAttributes.energy,
            FULL_ENERGY,
            character.bonusAttributes.energy);
    }

    private void DeriveEnergyRegeneration()
    {
        energyRegenerationDerived = DeriveAttributeInt(
            character.baseAttributes.energyRegeneration,
            FULL_ENERGY_REGENERATION,
            character.bonusAttributes.energyRegeneration);
    }

    private void DeriveAttackSpeed()
    {
        attackSpeedDerived = DeriveAttributeFloat(
            character.baseAttributes.attackSpeed,
            FULL_ATTACK_SPEED,
            character.bonusAttributes.attackSpeed);
    }

    private void DeriveCriticalHitChance()
    {
        criticalHitChanceDerived = DeriveAttributeFloat(
            character.baseAttributes.criticalHitChance,
            FULL_CRITICAL_HIT_CHANCE,
            character.bonusAttributes.criticalHitChance);
    }

    private void DeriveCriticalHitDamage()
    {
        criticalHitDamageDerived = DeriveAttributeFloat(
            character.baseAttributes.criticalHitDamage,
            FULL_CRITICAL_HIT_DAMAGE,
            character.bonusAttributes.criticalHitDamage);
    }

    private void DeriveCooldownReduction()
    {
        cooldownReductionDerived = DeriveAttributeFloat(
            character.baseAttributes.cooldownReduction,
            FULL_COOLDOWN_REDUCTION,
            character.bonusAttributes.cooldownReduction);
    }

    private void DeriveLifeDrain()
    {
        lifeDrainDerived = DeriveAttributeFloat(
            character.baseAttributes.lifeDrain,
            FULL_LIFE_DRAIN,
            character.bonusAttributes.lifeDrain);
    }

    private void DeriveMovementSpeed()
    {
        movementSpeedDerived = DeriveAttributeFloat(
            character.baseAttributes.movementSpeed,
            FULL_MOVEMENT_SPEED,
            character.bonusAttributes.movementSpeed);
    }
}

