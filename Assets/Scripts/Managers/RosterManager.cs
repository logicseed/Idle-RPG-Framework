using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
///
/// </summary>
[System.Serializable]
public class RosterManager : WorldEntityManager
{
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Allies.Unlocked; } }
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Allies.Assigned; } }
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Allies; } }

    public Dictionary<string, int> levels = new Dictionary<string, int>();

    public RosterManager(SaveGame save = null)
    {
        levels = new Dictionary<string, int>();
        unlocked = new List<string>();
        assigned = new List<string>();
        objects = new Dictionary<string, ListableEntity>();

        Load(save);
    }

    public override void Load(SaveGame save)
    {
        if (save != null)
        {
            foreach (var ally in save.unlockedAllies)
            {
                int allyLevel;
                if (save.allyLevels != null && save.allyLevels.ContainsKey(ally)) allyLevel = save.allyLevels[ally];
                else allyLevel = 1;

                AddUnlocked(ally, allyLevel, false);
            }

            foreach (var ally in save.assignedAllies)
            {
                AddAssigned(ally, false);
            }

            RaiseChangeEvent(WorldEntityListType.Unlocked);
            RaiseChangeEvent(WorldEntityListType.Assigned);
        }

        foreach (var ally in GameManager.GameSettings.CharacterStart.Roster)
        {
            if (!unlocked.Contains(ally))
            {
                unlocked.Add(ally);
                levels.Add(ally, 1);
            }
        }
    }

    public override void Save(ref SaveGame save)
    {
        save.unlockedAllies = Unlocked;
        save.assignedAllies = Assigned;
        save.allyLevels = levels;
    }

    public void AddUnlocked(string name, int level, bool raiseChangeEvent = true)
    {
        if (!Unlocked.Contains(name))
        {
            this.AddUnlocked(name, raiseChangeEvent);
            levels.Add(name, level);

            var entity = GetEntityObject(name) as Ally;
            var manager = GameManager.GetManagerByType(ListableEntityType.Ability);
            if (manager != null) manager.AddUnlocked(entity.lesson.name, false);
            Debug.Log("Added to abilities: " + entity.lesson.name);
        }
    }

    public override void RemoveUnlocked(string name, bool raiseChangeEvent = true)
    {
        base.RemoveUnlocked(name, raiseChangeEvent);

        if (levels.ContainsKey(name)) levels.Remove(name);
    }
}
