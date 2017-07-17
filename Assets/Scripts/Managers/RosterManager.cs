using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public class RosterManager
{
    public const int MAX_ACTIVE_ROSTER = 3;
    public const string ALLY_PATH = "Allies/";

    public List<string> unlockedAllies;
    public List<string> assignedAllies;

    public Dictionary<string, Ally> allyObjects;

    public Dictionary<string, int> allyLevels;

    public RosterManager()
    {
        unlockedAllies = new List<string>();
        assignedAllies = new List<string>();
        allyObjects = new Dictionary<string, Ally>();
        allyLevels = new Dictionary<string, int>();
    }

    public void AddToActive(string ally)
    {
        if (!assignedAllies.Contains(ally) && assignedAllies.Count < MAX_ACTIVE_ROSTER)
        {
            assignedAllies.Add(ally);
        }
    }

    public void RemoveFromActive(string ally)
    {
        if (assignedAllies.Contains(ally)) assignedAllies.Remove(ally);
    }

    public void AddToAllies(string ally, int experience)
    {
        if (!unlockedAllies.Contains(ally))
        {
            unlockedAllies.Add(ally);
            var allyObject = Resources.Load(ALLY_PATH + ally) as Ally;
            allyObjects.Add(ally, allyObject);
            allyLevels.Add(ally, experience);
        }
    }

    public void RemoveFromAllies(string ally)
    {
        if (unlockedAllies.Contains(ally))
        {
            unlockedAllies.Remove(ally);
            allyObjects.Remove(ally);
            allyLevels.Remove(ally);
        }
    }

    public Ally GetAlly(string ally)
    {
        if (unlockedAllies.Contains(ally))
        {
            if (allyObjects.ContainsKey(ally))
            {
                return allyObjects[ally];
            }
            else
            {
                var allyObject = Resources.Load(ALLY_PATH + ally) as Ally;
                allyObjects.Add(ally, allyObject);
                return allyObject;
            }
        }
        return Resources.Load(ALLY_PATH + ally) as Ally;
    }

    public List<Ally> GetActiveRoster()
    {
        var allies = new List<Ally>();

        foreach (var ally in assignedAllies)
        {
            allies.Add(allyObjects[ally]);
        }

        return allies;
    }

    public void Save(ref SaveGame save)
    {
        save.assignedAllies = assignedAllies;
        save.unlockedAllies = unlockedAllies;
        save.allyLevels = allyLevels;
    }

    public static RosterManager Load(SaveGame save = null)
    {
        var rosterManager = new RosterManager();

        if (save != null)
        {
            foreach (var ally in save.unlockedAllies)
            {
                int allyLevel;
                if (save.allyLevels != null && save.allyLevels.ContainsKey(ally)) allyLevel = save.allyLevels[ally];
                else allyLevel = 1;

                rosterManager.AddToAllies(ally, allyLevel);
            }

            foreach (var ally in save.assignedAllies)
            {
                rosterManager.AddToActive(ally);
            }
        }

        return rosterManager;
    }
}
