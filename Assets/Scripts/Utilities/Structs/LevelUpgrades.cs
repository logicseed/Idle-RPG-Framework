using System;

/// <summary>
/// Represents which attributes will be leveled up when an ally is upgraded.
/// </summary>
[Serializable]
public class LevelUpgrades
{
    public bool AttackDamage = true;
    public bool AbilityDamage = true;
    public bool Defense = true;
    public bool Health = true;
    public bool HealthRegeneration = true;
    public bool Energy = true;
    public bool EnergyRegeneration = true;
    public bool AttackSpeed = true;
    public bool CriticalHitChance = true;
    public bool CriticalHitDamage = true;
    public bool CooldownReduction = true;
    public bool LifeDrain = true;
    public bool MovementSpeed = true;
}
