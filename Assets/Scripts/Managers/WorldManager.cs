using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class WorldManager
{
    [SerializeField] private List<string> unlockedZones;
    [SerializeField] private string lastStage;
    [SerializeField] private List<string> unlockedStages;

    public List<string> UnlockedZones { get { return unlockedZones; } }
    public string LastStage { get { return lastStage; } }
    public List<string> UnlockedStages { get { return unlockedStages; } }

    public WorldManager(SaveGame save = null)
    {
        unlockedZones = new List<string>();
        unlockedStages = new List<string>();
        if (save != null)
        {
            unlockedZones = save.unlockedZones;
            unlockedStages = save.unlockedStages;
            lastStage = save.lastStage;
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

    internal void Save(ref SaveGame save)
    {
        save.lastStage = lastStage;
        save.unlockedZones = unlockedZones;
        save.unlockedStages = unlockedStages;
    }

    public void UnlockStage(string stage)
    {
        if (!unlockedStages.Contains("Scenes/Stages/" + stage)) unlockedStages.Add("Scenes/Stages/" + stage);
    }

    public void UnlockZone(string zone)
    {
        if (!unlockedZones.Contains("Scenes/Zones/" + zone)) unlockedZones.Add("Scenes/Zones/" + zone);
    }

    public void SetLastStage(string stage)
    {
        lastStage = "Scenes/Stages/" + stage;
    }
}
