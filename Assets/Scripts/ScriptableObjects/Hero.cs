using UnityEngine;

/// <summary>
/// Represents a hero.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Hero")]
public class Hero : Character
{
    /// <summary>
    /// Character type of the hero.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Hero; } }
}