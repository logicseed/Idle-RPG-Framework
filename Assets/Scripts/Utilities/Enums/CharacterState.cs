/// <summary>
/// Represents the current state of a character.
/// </summary>
public enum CharacterState
{
    /// <summary>
    /// Character is idle.
    /// </summary>
    Idle,

    /// <summary>
    /// Character is walking.
    /// </summary>
    Walk,

    /// <summary>
    /// Character is performing melee basic attacks.
    /// </summary>
    Melee,

    /// <summary>
    /// Character is performing ranged basic attacks.
    /// </summary>
    Ranged,

    /// <summary>
    /// Character is defending.
    /// </summary>
    Defend,

    /// <summary>
    /// Character is performing caster basic attacks.
    /// </summary>
    Cast,

    /// <summary>
    /// Character is dead.
    /// </summary>
    Dead
}