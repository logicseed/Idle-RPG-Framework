using UnityEngine;

/// <summary>
/// Contains unscaled attributes for a character.
/// </summary>
[System.Serializable]
public struct BaseAttributes
{
    [HelpBox("These are unscaled values that represent how skilled a character is in a " +
             "particular attribute. These attributes range from inept (1) to average (50) " +
             "to godlike (100). These values will be scaled to provide the final attributes " +
             "of a character.\n", HelpBoxMessageType.Information)]
    [SerializeField]
    [Range(0, 100)]
    private int attackDamage;

    [SerializeField]
    [Range(0, 100)]
    private int abilityDamage;

    [SerializeField]
    [Range(0, 100)]
    private int defense;

    [SerializeField]
    [Range(0, 100)]
    private int health;

    [SerializeField]
    [Range(0, 100)]
    private int healthRegeneration;

    [SerializeField]
    [Range(0, 100)]
    private int energy;

    [SerializeField]
    [Range(0, 100)]
    private int energyRegeneration;

    [SerializeField]
    [Range(0, 100)]
    private int attackSpeed;

    [SerializeField]
    [Range(0, 100)]
    private int criticalHitChance;

    [SerializeField]
    [Range(0, 100)]
    private int criticalHitDamage;

    [SerializeField]
    [Range(0, 100)]
    private int cooldownReduction;

    [SerializeField]
    [Range(0, 100)]
    private int lifeDrain;

    [SerializeField]
    [Range(0, 100)]
    private int movementSpeed;

    /// <summary>
    /// Damage done with basic attack.
    /// </summary>
    public int AttackDamage { get { return attackDamage; } set { attackDamage = value; } }

    /// <summary>
    /// Damage done with caster basic attack.
    /// </summary>
    public int AbilityDamage { get { return abilityDamage; } set { abilityDamage = value; } }

    /// <summary>
    /// Damage resisted from basic attacks.
    /// </summary>
    public int Defense { get { return defense; } set { defense = value; } }

    /// <summary>
    /// Health points until death.
    /// </summary>
    public int Health { get { return health; } set { health = value; } }

    /// <summary>
    /// Health points regenerated per second.
    /// </summary>
    public int HealthRegeneration { get { return healthRegeneration; } set { healthRegeneration = value; } }

    /// <summary>
    /// Energy points used for abilities.
    /// </summary>
    public int Energy { get { return energy; } set { energy = value; } }

    /// <summary>
    /// Energy points regnerated per second.
    /// </summary>
    public int EnergyRegeneration { get { return energyRegeneration; } set { energyRegeneration = value; } }

    /// <summary>
    /// Attacks per second.
    /// </summary>
    public int AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }

    /// <summary>
    /// Chance for a critical strike.
    /// </summary>
    public int CriticalHitChance { get { return criticalHitChance; } set { criticalHitChance = value; } }

    /// <summary>
    /// Extra damage on critical hits.
    /// </summary>
    public int CriticalHitDamage { get { return criticalHitDamage; } set { criticalHitDamage = value; } }

    /// <summary>
    /// Reduction is ability cooldowns.
    /// </summary>
    public int CooldownReduction { get { return cooldownReduction; } set { cooldownReduction = value; } }

    /// <summary>
    /// Health points regained based on damage.
    /// </summary>
    public int LifeDrain { get { return lifeDrain; } set { lifeDrain = value; } }

    /// <summary>
    /// Units moved per second.
    /// </summary>
    public int MovementSpeed { get { return movementSpeed; } set { movementSpeed = value; } }

    /// <summary>
    /// Adds two BaseAttributes together and returns a new one.
    /// </summary>
    /// <param name="attributesA">BaseAttributes to add to.</param>
    /// <param name="attributesB">BaseAttributes to add from.</param>
    /// <returns>BaseAttributes containing the sum of attributesA and attributesB.</returns>
    public static BaseAttributes operator +(BaseAttributes attributesA, BaseAttributes attributesB)
    {
        var attributes = new BaseAttributes();

        attributes.AttackDamage = attributesA.AttackDamage + attributesB.AttackDamage;
        attributes.AbilityDamage = attributesA.AbilityDamage + attributesB.AbilityDamage;
        attributes.Defense = attributesA.Defense + attributesB.Defense;
        attributes.Health = attributesA.Health + attributesB.Health;
        attributes.HealthRegeneration = attributesA.HealthRegeneration + attributesB.HealthRegeneration;
        attributes.Energy = attributesA.Energy + attributesB.Energy;
        attributes.EnergyRegeneration = attributesA.EnergyRegeneration + attributesB.EnergyRegeneration;
        attributes.AttackSpeed = attributesA.AttackSpeed + attributesB.AttackSpeed;
        attributes.CriticalHitChance = attributesA.CriticalHitChance + attributesB.CriticalHitChance;
        attributes.CriticalHitDamage = attributesA.CriticalHitDamage + attributesB.CriticalHitDamage;
        attributes.CooldownReduction = attributesA.CooldownReduction + attributesB.CooldownReduction;
        attributes.LifeDrain = attributesA.LifeDrain + attributesB.LifeDrain;
        attributes.MovementSpeed = attributesA.MovementSpeed + attributesB.MovementSpeed;

        return attributes;
    }
}