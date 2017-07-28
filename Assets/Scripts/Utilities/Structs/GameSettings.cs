using System;

[Serializable]
public class GameSettings
{
    public int MaxUnlockedAbilities = 9999;
    public int MaxAssignedAbilities = 3;
    public string AbilitiesPath = "Abilities/";

    public int MaxUnlockedEquipment = 9999;
    public int MaxAssignedEquipment = 9999;
    public string EquipmentPath = "Equipment/";

    public int MaxUnlockedAllies = 9999;
    public int MaxAssignedAllies = 3;
    public string AlliesPath = "Allies/";
}
