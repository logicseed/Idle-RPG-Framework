using System;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
/// Manages the state of the world, such as unlocked zones and stages.
/// </summary>
[System.Serializable]
public class WorldManager
{
    [SerializeField]
    protected string lastStage;

    [SerializeField]
    protected float lastIdleFactor = 1.0f;

    [SerializeField]
    protected List<string> unlockedStages;

    [SerializeField]
    protected List<string> unlockedZones;

    /// <summary>
    /// Constructs the world manager from save game data.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public WorldManager(SaveGame save = null)
    {
        unlockedZones = new List<string>();
        unlockedStages = new List<string>();
        if (save != null)
        {
            unlockedZones = save.UnlockedZones;
            unlockedStages = save.UnlockedStages;
            lastStage = save.LastStage;
            lastIdleFactor = save.LastIdleFactor;
        }

        foreach (var zone in GameManager.GameSettings.CharacterStart.Zones)
        {
            if (!unlockedZones.Contains(zone)) unlockedZones.Add(zone);
        }
        foreach (var stage in GameManager.GameSettings.CharacterStart.Stages)
        {
            if (!unlockedStages.Contains(stage)) unlockedStages.Add(stage);
        }
    }

    /// <summary>
    /// Returns the last stage the hero was on.
    /// </summary>
    public string LastStage { get { return lastStage; } }

    /// <summary>
    /// Returns the idle factor of the highest stage.
    /// </summary>
    public float LastIdleFactor { get { return lastIdleFactor; } }

    /// <summary>
    /// Sets the idle factor to a new value if it is larger.
    /// </summary>
    /// <param name="idleRewardsFactor">New potential idle factor.</param>
    public void SetIdleFactor(float idleRewardsFactor)
    {
        lastIdleFactor = Math.Max(idleRewardsFactor, lastIdleFactor);
    }

    /// <summary>
    /// Returns the list of unlocked stages.
    /// </summary>
    public List<string> UnlockedStages { get { return unlockedStages; } }

    /// <summary>
    /// Returns the list of unlocked zones.
    /// </summary>
    public List<string> UnlockedZones { get { return unlockedZones; } }

    /// <summary>
    /// Fills a save game with world manager data.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public void Save(ref SaveGame save)
    {
        save.LastStage = lastStage;
        save.UnlockedZones = unlockedZones;
        save.UnlockedStages = unlockedStages;
        save.LastIdleFactor = lastIdleFactor;
    }

    /// <summary>
    /// Sets the last stage the hero was on.
    /// </summary>
    /// <param name="stage">The name of the stage.</param>
    public void SetLastStage(string stage)
    {
        lastStage = "Scenes/Stages/" + stage;
        Debug.Log("Last stage set: " + stage);
    }

    /// <summary>
    /// Unlocks a stage.
    /// </summary>
    /// <param name="stage">The name of the stage to unlock.</param>
    public void UnlockStage(string stage)
    {
        if (!unlockedStages.Contains("Scenes/Stages/" + stage))
        {
            unlockedStages.Add("Scenes/Stages/" + stage);
            Debug.Log("Unlocked stage: " + stage);
        }
    }

    /// <summary>
    /// Unlocks a zone.
    /// </summary>
    /// <param name="zone">The name of the zone to unlock.</param>
    public void UnlockZone(string zone)
    {
        if (!unlockedZones.Contains("Scenes/Zones/" + zone))
        {
            unlockedZones.Add("Scenes/Zones/" + zone);
            Debug.Log("Unlocked zone: " + zone);
        }
    }
}