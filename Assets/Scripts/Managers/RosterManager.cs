using System.Collections.Generic;

/// <summary>
/// Manages the roster of allies; keeping track of unlocked allies, assigned allies, etc.
/// </summary>
[System.Serializable]
public class RosterManager : WorldEntityManager
{
    protected Dictionary<string, int> allyLevels;

    /// <summary>
    /// Constructs the roster manager from saved game data.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public RosterManager(SaveGame save = null) : base(save) { }
    //public RosterManager(SaveGame save = null)
    //{
    //    allyLevels = new Dictionary<string, int>();
    //    unlocked = new List<string>();
    //    assigned = new List<string>();
    //    objects = new Dictionary<string, ListableEntity>();

    //    Load(save);
    //}

    /// <summary>
    /// Returns a collection of ally levels; key is ally name, value is level.
    /// </summary>
    public Dictionary<string, int> AllyLevels { get { return allyLevels; } set { allyLevels = value; } }

    /// <summary>
    /// Returns the maximum amount of assigned allies.
    /// </summary>
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Allies.Assigned; } }

    /// <summary>
    /// Returns the maximum amount of unlocked allies.
    /// </summary>
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Allies.Unlocked; } }

    /// <summary>
    /// Returns the resource path for ally objects.
    /// </summary>
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Allies; } }

    /// <summary>
    /// Adds an unlocked ally to the roster.
    /// </summary>
    /// <param name="name">The name of the ally to unlock.</param>
    /// <param name="level">The level of the unlocked ally.</param>
    /// <param name="raiseChangeEvent">Whether or not to raise an event for the roster change.</param>
    public void AddUnlocked(string name, int level, bool raiseChangeEvent = true)
    {
        if (!Unlocked.Contains(name))
        {
            this.AddUnlocked(name, raiseChangeEvent);
            allyLevels.Add(name, level);

            var entity = GetEntityObject(name) as Ally;
            var manager = GameManager.GetManagerByType(ListableEntityType.Ability);
            if (manager != null) manager.AddUnlocked(entity.Lesson.name, false);
        }
    }

    /// <summary>
    /// Loads data from a save game into the roster manager.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public override void Load(SaveGame save)
    {
        
        allyLevels = new Dictionary<string, int>();

        if (save != null)
        {
            if (save.UnlockedAllies != null)
            {
                foreach (var ally in save.UnlockedAllies)
                {
                    int allyLevel;
                    if (save.AllyLevels != null && save.AllyLevels.ContainsKey(ally)) allyLevel = save.AllyLevels[ally];
                    else allyLevel = 1;

                    AddUnlocked(ally, allyLevel, false);
                }
            }

            if (save.AssignedAllies != null)
            {
                foreach (var ally in save.AssignedAllies)
                {
                    AddAssigned(ally, false);
                }
            }

            RaiseChangeEvent(WorldEntityListType.Unlocked);
            RaiseChangeEvent(WorldEntityListType.Assigned);
        }

        foreach (var ally in GameManager.GameSettings.CharacterStart.Roster)
        {
            if (!unlocked.Contains(ally))
            {
                unlocked.Add(ally);
                allyLevels.Add(ally, 1);
            }
        }
    }

    /// <summary>
    /// Removes an ally from the roster.
    /// </summary>
    /// <param name="name">The name of the ally to remove.</param>
    /// <param name="raiseChangeEvent">Whether or not to raise an event for the roster change.</param>
    public override void RemoveUnlocked(string name, bool raiseChangeEvent = true)
    {
        base.RemoveUnlocked(name, raiseChangeEvent);

        if (allyLevels.ContainsKey(name)) allyLevels.Remove(name);
    }

    /// <summary>
    /// Fills a save game with data from the roster manager.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public override void Save(ref SaveGame save)
    {
        save.UnlockedAllies = Unlocked;
        save.AssignedAllies = Assigned;
        save.AllyLevels = allyLevels;
    }
}