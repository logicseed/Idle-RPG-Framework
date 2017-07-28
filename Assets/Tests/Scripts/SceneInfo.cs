using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class SceneInfo : MonoBehaviour
{
    public Text displayText;

    public bool showSceneTime = true;
    public bool showExperience = false;

    public bool showUnlockedAbilities = false;
    public bool showAssignedAbilities = false;

    public bool showUnlockedEquipment = false;
    public bool showAssignedEquipment = false;
	
	void Update ()
    {
        var frameText = new StringBuilder();
        frameText.AppendLine("SCENE INFO");

        if (showSceneTime) frameText.AppendLine("Time: " + Time.timeSinceLevelLoad);
        if (showExperience) frameText.AppendLine("Experience: " + GameManager.HeroManager.experience);

        if (showUnlockedAbilities) frameText.AppendLine("Unlocked Abilities: " + GameManager.AbilityManager.Unlocked.ToDelimitedString());
        if (showAssignedAbilities) frameText.AppendLine("Assigned Abilities: " + GameManager.AbilityManager.Assigned.ToDelimitedString());

        if (showUnlockedEquipment) frameText.AppendLine("Unlocked Equipment: " + GameManager.InventoryManager.Unlocked.ToDelimitedString());
        if (showAssignedEquipment) frameText.AppendLine("Assigned Equipment: " + GameManager.InventoryManager.Assigned.ToDelimitedString());

        displayText.text = frameText.ToString();
	}
}
