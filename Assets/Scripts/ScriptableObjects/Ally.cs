using UnityEngine;

/// <summary>
/// Represents an ally.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Ally")]
public class Ally : Character
{
    [SerializeField]
    protected Ability lesson;

    [SerializeField]
    protected LevelUpgrades levelUpgrades;

    /// <summary>
    /// The character type of the ally.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Ally; } }

    /// <summary>
    /// The lesson taught by the ally; i.e. the ability gained when unlocking ally.
    /// </summary>
    public Ability Lesson { get { return lesson; } }

    /// <summary>
    /// The attributes that are upgraded when leveling up the ally.
    /// </summary>
    public LevelUpgrades LevelUpgrades { get { return levelUpgrades; } }

    /// <summary>
    /// Type of lists this ally belongs to.
    /// </summary>
    public override ListableEntityType ListableType { get { return ListableEntityType.Roster; } }
}