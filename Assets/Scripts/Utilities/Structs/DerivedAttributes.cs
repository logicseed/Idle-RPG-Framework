using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// The derived attributes of a character from base attributes, levels, equipment, etc.
/// </summary>
public class DerivedAttributes
{
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
    /// Damage of basic attacks.
    /// </summary>
    public int AttackDamage { get { return attackDamageDerived; } }

    /// <summary>
    /// Damage of abilities.
    /// </summary>
    public int AbilityDamage { get { return abilityDamageDerived; } }

    /// <summary>
    /// Resistance to damage.
    /// </summary>
    public int Defense { get { return defenseDerived; } }

    /// <summary>
    /// Health points before death.
    /// </summary>
    public int Health { get { return healthDerived; } }

    /// <summary>
    /// Health points regained per second.
    /// </summary>
    public int HealthRegeneration { get { return healthRegenerationDerived; } }

    /// <summary>
    /// Energy points spend on abilities.
    /// </summary>
    public int Energy { get { return energyDerived; } }

    /// <summary>
    /// Energy points regained per second.
    /// </summary>
    public int EnergyRegeneration { get { return energyRegenerationDerived; } }

    /// <summary>
    /// Attacks per second.
    /// </summary>
    public float AttackSpeed { get { return attackSpeedDerived; } }

    /// <summary>
    /// Chance for a critical hit.
    /// </summary>
    public float CriticalHitChance { get { return criticalHitChanceDerived; } }

    /// <summary>
    /// Damage bonus upon critical hit.
    /// </summary>
    public float CriticalHitDamage { get { return criticalHitDamageDerived; } }

    /// <summary>
    /// Percentage of cooldowns reduced.
    /// </summary>
    public float CooldownReduction { get { return cooldownReductionDerived; } }

    /// <summary>
    /// Life regained per damage done.
    /// </summary>
    public float LifeDrain { get { return lifeDrainDerived; } }

    /// <summary>
    /// Units moved per second.
    /// </summary>
    public float MovementSpeed { get { return movementSpeedDerived; } }

    private Character character;
    private int level;
    private BaseAttributes bonusAttributes;
    private LevelUpgrades levelUpgrades;

    /// <summary>
    /// Constructor to create derived attributes from a character.
    /// </summary>
    /// <param name="character">Character object for base attributes.</param>
    /// <param name="level">Level of the character.</param>
    public DerivedAttributes(Character character, int level)
    {
        this.character = character;
        this.level = level;

        if (character.CharacterType == CharacterType.Hero)
        {
            bonusAttributes = character.BonusAttributes + GameManager.InventoryManager.AttributeModifiers;
        }
        else
        {
            bonusAttributes = character.BonusAttributes;
        }

        if (character.CharacterType == CharacterType.Ally)
        {
            var ally = character as Ally;
            levelUpgrades = ally.LevelUpgrades;
        }
        else
        {
            levelUpgrades = new LevelUpgrades();
        }

        CalculateDerivedAttributes();
    }

    /// <summary>
    /// Calculate all derived attributes.
    /// </summary>
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

    /// <summary>
    /// Derives a floating point attribute.
    /// </summary>
    /// <param name="baseAttribute">Base attribute value.</param>
    /// <param name="fullValue">Full value of the attribute.</param>
    /// <param name="bonusAttribute">Bonus attribute values.</param>
    /// <param name="upgradable">Whether or not the attribute is upgraded by level.</param>
    /// <returns>The derived attribute.</returns>
    protected float DeriveAttributeFloat(int baseAttribute, float fullValue, int bonusAttribute, bool upgradable = true)
    {
        float derivedAttribute = baseAttribute;
        derivedAttribute += bonusAttribute;
        derivedAttribute /= 100f;
        derivedAttribute *= fullValue;
        if (upgradable) derivedAttribute *= level;
        return derivedAttribute;
    }

    /// <summary>
    /// Derives an integer attribute.
    /// </summary>
    /// <param name="baseAttribute">Base attribute value.</param>
    /// <param name="fullValue">Full value of the attribute.</param>
    /// <param name="bonusAttribute">Bonus attribute values.</param>
    /// <param name="upgradable">Whether or not the attribute is upgraded by level.</param>
    /// <returns>The derived attribute.</returns>
    protected int DeriveAttributeInt(int baseAttribute, int fullValue, int bonusAttribute, bool upgradable = true)
    {
        return (int)DeriveAttributeFloat(baseAttribute, fullValue, bonusAttribute);
    }

    /// <summary>
    /// Derives the attack damage attribute.
    /// </summary>
    protected void DeriveAttackDamage()
    {
        attackDamageDerived = DeriveAttributeInt(
            character.BaseAttributes.AttackDamage,
            GameManager.GameSettings.Max.AttributeFactor.AttackDamage,
            bonusAttributes.AttackDamage,
            levelUpgrades.AbilityDamage);
    }

    /// <summary>
    /// Derives the ability damage attribute.
    /// </summary>
    protected void DeriveAbilityDamage()
    {
        abilityDamageDerived = DeriveAttributeInt(
            character.BaseAttributes.AbilityDamage,
            GameManager.GameSettings.Max.AttributeFactor.AbilityDamage,
            bonusAttributes.AbilityDamage,
            levelUpgrades.AbilityDamage);
    }

    /// <summary>
    /// Derives the defense attribute.
    /// </summary>
    protected void DeriveDefense()
    {
        defenseDerived = DeriveAttributeInt(
            character.BaseAttributes.Defense,
            GameManager.GameSettings.Max.AttributeFactor.Defense,
            bonusAttributes.Defense,
            levelUpgrades.Defense);
    }

    /// <summary>
    /// Derives the health attribute.
    /// </summary>
    protected void DeriveHealth()
    {
        healthDerived = DeriveAttributeInt(
            character.BaseAttributes.Health,
            GameManager.GameSettings.Max.AttributeFactor.Health,
            bonusAttributes.Health,
            levelUpgrades.Health);
    }

    /// <summary>
    /// Derives the health regeneration attribute.
    /// </summary>
    protected void DeriveHealthRegeneration()
    {
        healthRegenerationDerived = DeriveAttributeInt(
            character.BaseAttributes.HealthRegeneration,
            GameManager.GameSettings.Max.AttributeFactor.HealthRegeneration,
            bonusAttributes.HealthRegeneration,
            levelUpgrades.HealthRegeneration);
    }

    /// <summary>
    /// Derives the energy attribute.
    /// </summary>
    protected void DeriveEnergy()
    {
        energyDerived = DeriveAttributeInt(
            character.BaseAttributes.Energy,
            GameManager.GameSettings.Max.AttributeFactor.Energy,
            bonusAttributes.Energy,
            levelUpgrades.Energy);
    }

    /// <summary>
    /// Derives the energy regeneration attribute.
    /// </summary>
    protected void DeriveEnergyRegeneration()
    {
        energyRegenerationDerived = DeriveAttributeInt(
            character.BaseAttributes.EnergyRegeneration,
            GameManager.GameSettings.Max.AttributeFactor.EnergyRegeneration,
            bonusAttributes.EnergyRegeneration,
            levelUpgrades.EnergyRegeneration);
    }

    /// <summary>
    /// Derives the attack speed attribute.
    /// </summary>
    protected void DeriveAttackSpeed()
    {
        attackSpeedDerived = DeriveAttributeFloat(
            character.BaseAttributes.AttackSpeed,
            GameManager.GameSettings.Max.AttributeFactor.AttackSpeed,
            bonusAttributes.AttackSpeed,
            false);
    }

    /// <summary>
    /// Derives the critical hit change attribute.
    /// </summary>
    protected void DeriveCriticalHitChance()
    {
        criticalHitChanceDerived = DeriveAttributeFloat(
            character.BaseAttributes.CriticalHitChance,
            GameManager.GameSettings.Max.AttributeFactor.CriticalHitChance,
            bonusAttributes.CriticalHitChance,
            levelUpgrades.CriticalHitChance);
    }

    /// <summary>
    /// Derives the critical hit damage attribute.
    /// </summary>
    protected void DeriveCriticalHitDamage()
    {
        criticalHitDamageDerived = 1 + DeriveAttributeFloat(
            character.BaseAttributes.CriticalHitDamage,
            GameManager.GameSettings.Max.AttributeFactor.CriticalHitDamage,
            bonusAttributes.CriticalHitDamage,
            levelUpgrades.CriticalHitDamage);
    }

    /// <summary>
    /// Derives the cooldown reduction attribute.
    /// </summary>
    protected void DeriveCooldownReduction()
    {
        cooldownReductionDerived = DeriveAttributeFloat(
            character.BaseAttributes.CooldownReduction,
            GameManager.GameSettings.Max.AttributeFactor.CooldownReduction,
            bonusAttributes.CooldownReduction,
            levelUpgrades.CooldownReduction);
    }

    /// <summary>
    /// Derives the lide drain attribute.
    /// </summary>
    protected void DeriveLifeDrain()
    {
        lifeDrainDerived = DeriveAttributeFloat(
            character.BaseAttributes.LifeDrain,
            GameManager.GameSettings.Max.AttributeFactor.LifeDrain,
            bonusAttributes.LifeDrain,
            levelUpgrades.LifeDrain);
    }

    /// <summary>
    /// Derives the movement speed attribute.
    /// </summary>
    protected void DeriveMovementSpeed()
    {
        movementSpeedDerived = DeriveAttributeFloat(
            character.BaseAttributes.MovementSpeed,
            GameManager.GameSettings.Max.AttributeFactor.MovementSpeed,
            bonusAttributes.MovementSpeed,
            false);
    }
}

