using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using UnityEngine;

/// <summary>
/// Stores everything that needs to be persisted across plays.
/// </summary>
[Serializable]
public class SaveGame : ISerializable
{
    public int experience;
    public List<string> unlockedAllies;
    public List<string> assignedAllies;
    public List<string> unlockedZones;
    public List<string> unlockedStages;
    public List<string> unlockedEquipment;
    public List<string> assignedEquipment;
    public List<string> unlockedAbilities;
    public List<string> assignedAbilities;
    public string lastStage;
    public DateTime lastStageTime;
    public bool isFilled = false;

    public SaveGame() { }

    public SaveGame(SerializationInfo info, StreamingContext context)
    {
        experience = info.GetInt32("experience");
        unlockedAllies = (List<string>)info.GetValue("unlockedAllies", typeof(List<string>));
        assignedAllies = (List<string>)info.GetValue("assignedAllies", typeof(List<string>));
        unlockedZones = (List<string>)info.GetValue("unlockedZones", typeof(List<string>));
        unlockedStages = (List<string>)info.GetValue("unlockedStages", typeof(List<string>));
        unlockedEquipment = (List<string>)info.GetValue("unlockedEquipment", typeof(List<string>));
        assignedEquipment = (List<string>)info.GetValue("assignedEquipment", typeof(List<string>));
        unlockedAbilities = (List<string>)info.GetValue("unlockedAbilities", typeof(List<string>));
        assignedAbilities = (List<string>)info.GetValue("assignedAbilities", typeof(List<string>));
        lastStage = info.GetString("lastStage");
        lastStageTime = (DateTime)info.GetValue("lastStageTime", typeof(DateTime));
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("experience", experience);
        info.AddValue("unlockedAllies", unlockedAllies);
        info.AddValue("assignedAllies", assignedAllies);
        info.AddValue("unlockedZones", unlockedZones);
        info.AddValue("unlockedStages", unlockedStages);
        info.AddValue("unlockedEquipment", unlockedEquipment);
        info.AddValue("assignedEquipment", assignedEquipment);
        info.AddValue("unlockedAbilities", unlockedAbilities);
        info.AddValue("assignedAbilities", assignedAbilities);
        info.AddValue("lastStage", lastStage);
        info.AddValue("lastStageTime", lastStageTime);
    }
}

