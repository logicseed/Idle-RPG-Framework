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

    public bool showUnlockedAllies = false;
    public bool showAssignedAllies = false;

    public bool showDefendCooldown = false;
    public bool showFireballCooldown = false;
    public bool showCleaveCooldown = false;
    public bool showStormCooldown = false;

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

        if (showUnlockedAllies) frameText.AppendLine("Unlocked Allies: " + GameManager.RosterManager.Unlocked.ToDelimitedString());
        if (showAssignedAllies) frameText.AppendLine("Assigned Allies: " + GameManager.RosterManager.Assigned.ToDelimitedString());

        if (showFireballCooldown)
        {
            if (GameManager.Hero.heroCombat.Cooldowns.ContainsKey("Defend"))
                frameText.AppendLine("Defend Cooldown: " + GameManager.Hero.heroCombat.Cooldowns["Defend"]);
            else
                frameText.AppendLine("Defend not on cooldown.");
        }
        if (showFireballCooldown)
        {
            if (GameManager.Hero.heroCombat.Cooldowns.ContainsKey("Fireball"))
                frameText.AppendLine("Fireball Cooldown: " + GameManager.Hero.heroCombat.Cooldowns["Fireball"]);
            else
                frameText.AppendLine("Fireball not on cooldown.");
        }
        if (showCleaveCooldown)
        {
            if (GameManager.Hero.heroCombat.Cooldowns.ContainsKey("Cleave"))
                frameText.AppendLine("Cleave Cooldown: " + GameManager.Hero.heroCombat.Cooldowns["Cleave"]);
            else
                frameText.AppendLine("Cleave not on cooldown.");
        }
        if (showStormCooldown)
        {
            if (GameManager.Hero.heroCombat.Cooldowns.ContainsKey("Storm"))
                frameText.AppendLine("Storm Cooldown: " + GameManager.Hero.heroCombat.Cooldowns["Storm"]);
            else
                frameText.AppendLine("Storm not on cooldown.");
        }

        displayText.text = frameText.ToString();
	}
}
