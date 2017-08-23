using UnityEngine;

/// <summary>
/// Represents an ability.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Ability")]
public class Ability : ListableEntity
{
    [SerializeField]
    protected AbilityRange abilityRange;

    [SerializeField]
    protected AbilityType abilityType;

    [SerializeField]
    protected Sprite effect;

    [SerializeField]
    [Range(0, 10)]
    protected float potency;

    [SerializeField]
    protected int energyCost;


    [SerializeField]
    public float cooldown;

    /// <summary>
    /// Range type of the ability.
    /// </summary>
    public AbilityRange AbilityRange { get { return abilityRange; } }

    /// <summary>
    /// Type of the ability.
    /// </summary>
    public AbilityType AbilityType { get { return abilityType; } }

    /// <summary>
    /// Cooldown of the ability in seconds.
    /// </summary>
    public float Cooldown { get { return cooldown; } }

    /// <summary>
    /// Visual effect for the ability.
    /// </summary>
    public Sprite Effect { get { return effect; } }

    /// <summary>
    /// Energy cost.
    /// </summary>
    public int EnergyCost { get { return energyCost * GameManager.HeroManager.Level; } }

    /// <summary>
    /// Type of lists this ability belongs to.
    /// </summary>
    public override ListableEntityType ListableType { get { return ListableEntityType.Ability; } }

    /// <summary>
    /// Potency of the ability.
    /// </summary>
    public float Potency { get { return potency; } }
}