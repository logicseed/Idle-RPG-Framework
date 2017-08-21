using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

/// <summary>
/// Stores everything that needs to be persisted across plays.
/// </summary>
[Serializable]
public class SaveGame : ISerializable
{
    // Fields to save
    public int Experience;
    public List<string> UnlockedAllies;
    public List<string> AssignedAllies;
    public List<string> UnlockedZones;
    public List<string> UnlockedStages;
    public List<string> UnlockedEquipment;
    public List<string> AssignedEquipment;
    public List<string> UnlockedAbilities;
    public List<string> AssignedAbilities;
    public string LastStage;
    public string LastZone;
    public float LastIdleFactor;
    public DateTime LastRewardTime = DateTime.MinValue;
    public bool IsFilled = false;
    public int Level = 1;
    public Dictionary<string, int> AllyLevels;

    // To add fields to the save game, they must be added above, and then
    // into the serialization methods below.

    public SaveGame() { }

    /// <summary>
    /// Constructor for deserializing save game data.
    /// </summary>
    public SaveGame(SerializationInfo info, StreamingContext context)
    {
        Experience = info.GetInt32("experience");

        UnlockedAllies = (List<string>)info.GetValue("unlockedAllies", typeof(List<string>));
        if (UnlockedAllies == null) UnlockedAllies = new List<string>();

        AssignedAllies = (List<string>)info.GetValue("assignedAllies", typeof(List<string>));
        if (AssignedAllies == null) AssignedAllies = new List<string>();

        UnlockedZones = (List<string>)info.GetValue("unlockedZones", typeof(List<string>));
        if (UnlockedZones == null) UnlockedZones = new List<string>();

        UnlockedStages = (List<string>)info.GetValue("unlockedStages", typeof(List<string>));
        if (UnlockedStages == null) UnlockedStages = new List<string>();

        UnlockedEquipment = (List<string>)info.GetValue("unlockedEquipment", typeof(List<string>));
        if (UnlockedEquipment == null) UnlockedEquipment = new List<string>();

        AssignedEquipment = (List<string>)info.GetValue("assignedEquipment", typeof(List<string>));
        if (AssignedEquipment == null) AssignedEquipment = new List<string>();

        UnlockedAbilities = (List<string>)info.GetValue("unlockedAbilities", typeof(List<string>));
        if (UnlockedAbilities == null) UnlockedAbilities = new List<string>();

        AssignedAbilities = (List<string>)info.GetValue("assignedAbilities", typeof(List<string>));
        if (AssignedAbilities == null) AssignedAbilities = new List<string>();

        LastStage = info.GetString("lastStage");
        LastZone = info.GetString("lastZone");
        LastIdleFactor = (float)info.GetValue("lastIdleFactor", typeof(float));

        LastRewardTime = (DateTime)info.GetValue("lastRewardTime", typeof(DateTime));

        Level = info.GetInt32("level");

        AllyLevels = (Dictionary<string, int>)info.GetValue("allyLevels", typeof(Dictionary<string, int>));
        if (AllyLevels == null) AllyLevels = new Dictionary<string, int>();
    }

    /// <summary>
    /// Prepares fields for serialization.
    /// </summary>
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("experience", Experience);
        info.AddValue("unlockedAllies", UnlockedAllies);
        info.AddValue("assignedAllies", AssignedAllies);
        info.AddValue("unlockedZones", UnlockedZones);
        info.AddValue("unlockedStages", UnlockedStages);
        info.AddValue("unlockedEquipment", UnlockedEquipment);
        info.AddValue("assignedEquipment", AssignedEquipment);
        info.AddValue("unlockedAbilities", UnlockedAbilities);
        info.AddValue("assignedAbilities", AssignedAbilities);
        info.AddValue("lastStage", LastStage);
        info.AddValue("lastZone", LastZone);
        info.AddValue("lastIdleFactor", LastIdleFactor);
        info.AddValue("lastRewardTime", LastRewardTime);
        info.AddValue("level", Level);
        info.AddValue("allyLevels", AllyLevels);
    }
}

