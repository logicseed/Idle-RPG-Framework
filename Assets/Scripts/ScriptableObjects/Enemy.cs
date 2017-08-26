using UnityEngine;

/// <summary>
/// Represents an enemy.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Enemy")]
public class Enemy : Character
{
    /// <summary>
    /// Character type of the enemy.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Enemy; } }
}