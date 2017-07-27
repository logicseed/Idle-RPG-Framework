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
	
	void Update ()
    {
        var frameText = new StringBuilder();
        frameText.AppendLine("SCENE INFO");

        if (showSceneTime) frameText.AppendLine("Time: " + Time.timeSinceLevelLoad);
        if (showExperience) frameText.AppendLine("Experience: " + GameManager.HeroManager.experience);
        if (showUnlockedAbilities) frameText.AppendLine("Unlocked Abilities: " + GameManager.AbilityManager.unlockedAbilities.ToDelimitedString());
        if (showAssignedAbilities) frameText.AppendLine("Assigned Abilities: " + GameManager.AbilityManager.assignedAbilities.ToDelimitedString());

        displayText.text = frameText.ToString();
	}
}
