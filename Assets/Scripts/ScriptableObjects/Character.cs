using UnityEngine;

/// <summary>
/// Represents a character.
/// </summary>
public abstract class Character : ListableEntity
{
    [SerializeField]
    protected RuntimeAnimatorController animator;

    [SerializeField]
    protected AttackType attackType;

    [SerializeField]
    protected int level = 1;

    [SerializeField]
    protected BaseAttributes baseAttributes;

    [SerializeField]
    protected BaseAttributes bonusAttributes;

    /// <summary>
    /// The animator controller for the character.
    /// </summary>
    public RuntimeAnimatorController Animator { get { return animator; } }
    /// <summary>
    /// Attack type of the character.
    /// </summary>
    public AttackType AttackType { get { return attackType; } }
    /// <summary>
    /// Base attributes of the character.
    /// </summary>
    public BaseAttributes BaseAttributes { get { return baseAttributes; } }

    /// <summary>
    /// Bonus attributes of the character.
    /// </summary>
    public BaseAttributes BonusAttributes { get { return bonusAttributes; } }

    /// <summary>
    /// Type of the character.
    /// </summary>
    public abstract CharacterType CharacterType { get; }

    /// <summary>
    /// The level of the character.
    /// </summary>
    public int Level { get { return level; } set { level = value; } }
}