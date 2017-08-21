using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the hero on the stage, and provides easy access to common hero functionality.
/// </summary>
[Serializable]
public class HeroManager : RegisterList<HeroController>
{
    protected int experience = 0;

    protected Hero heroObject;

    protected int level = 1;

    /// <summary>
    /// Constructs the hero manager.
    /// </summary>
    public HeroManager() : base() { }

    /// <summary>
    /// Gets or sets the hero's experience.
    /// </summary>
    public int Experience { get { return experience; } set { experience = value; } }

    /// <summary>
    /// Returns the hero controller.
    /// </summary>
    public HeroController Hero { get { if (list.Count > 0) return list[0]; else return null; } }

    /// <summary>
    /// Gets or sets the hero's scriptable object.
    /// </summary>
    public Hero HeroObject { get { return heroObject; } set { heroObject = value; } }

    /// <summary>
    /// Gets or sets the hero's level.
    /// </summary>
    public int Level { get { return level; } set { level = value; } }

    /// <summary>
    /// Loads the hero manager from a saved game.
    /// </summary>
    /// <param name="save">Saved game data.</param>
    /// <returns>A hero manager filled with saved data.</returns>
    public static HeroManager Load(SaveGame save = null)
    {
        var heroManager = new HeroManager();

        if (save != null)
        {
            heroManager.Experience = save.experience;
            heroManager.Level = save.level;
        }
        else
        {
            heroManager.Experience = GameManager.GameSettings.CharacterStart.Experience;
            heroManager.Level = GameManager.GameSettings.CharacterStart.Level;
        }

        heroManager.HeroObject = Resources.Load("Heroes/Hero") as Hero;
        heroManager.HeroObject.level = heroManager.Level;

        return heroManager;
    }

    /// <summary>
    /// Adds hero to the list.
    /// </summary>
    /// <param name="addToList">The list to add the hero to.</param>
    public void AddHeroToList(ref List<GameCharacterController> addToList)
    {
        if (list.Count > 0) addToList.Add(list[0]);
    }

    /// <summary>
    /// Saves the experience and level.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public void Save(ref SaveGame save)
    {
        save.experience = Experience;
        save.level = Level;
    }
}