using System.Collections.Generic;

/// <summary>
/// Manages abilities; maintains which abilities are unlocked, assigned, and provides access
/// to the ability objects by name.
/// </summary>
[System.Serializable]
public class AbilityManager : WorldEntityManager
{
    /// <summary>
    /// Constructs the ability manager from a saved game.
    /// </summary>
    /// <param name="save">The saved game data.</param>
    public AbilityManager(SaveGame save = null) : base(save) { }

    /// <summary>
    /// Returns the maximum amount of assigned abilities.
    /// </summary>
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Abilities.Assigned + 1; } }

    /// <summary>
    /// Returns the maximum amount of unlocked abilities.
    /// </summary>
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Abilities.Unlocked; } }

    /// <summary>
    /// Returns the resource path of the abilities.
    /// </summary>
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Abilities; } }

    /// <summary>
    /// Loads the data from a saved game.
    /// </summary>
    /// <param name="save">The saved game data.</param>
    public override void Load(SaveGame save)
    {
        AddAssigned("Defend"); // Always have defend ability

        if (save != null)
        {
            foreach (var ability in save.UnlockedAbilities) AddUnlocked(ability);
            foreach (var ability in save.AssignedAbilities) AddAssigned(ability);
        }

        foreach (var ability in GameManager.GameSettings.CharacterStart.Abilities)
        {
            if (!unlocked.Contains(ability)) AddUnlocked(ability);
        }
    }

    /// <summary>
    /// Fills a save game with ability data.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public override void Save(ref SaveGame save)
    {
        save.UnlockedAbilities = Unlocked;
        var assignedWithoutDefend = new List<string>(Assigned);
        assignedWithoutDefend.Remove("Defend");
        save.AssignedAbilities = assignedWithoutDefend;
    }
}