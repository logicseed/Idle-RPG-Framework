using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[System.Serializable]
public class StageManager
{
    public string lastStage;
    public List<string> unlockedStages;

    public void Save(ref SaveGame save)
    {
        save.unlockedStages = unlockedStages;
        save.lastStage = lastStage;
    }

    public static StageManager Load(SaveGame save = null)
    {
        var stageManager = new StageManager();

        if (save != null)
        {
            stageManager.unlockedStages = save.unlockedStages;
            stageManager.lastStage = save.lastStage;
        }

        return stageManager;
    }
}
