using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[System.Serializable]
public class ZoneManager
{
    public List<string> unlockedZones;

    public void Save(ref SaveGame save)
    {
        save.unlockedZones = unlockedZones;
    }

    public static ZoneManager Load(SaveGame save = null)
    {
        var zoneManager = new ZoneManager();

        if (save != null)
        {
            zoneManager.unlockedZones = save.unlockedZones;
        }

        return zoneManager;
    }
}
