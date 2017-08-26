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

    public bool showHeroLevel = false;
    public bool showAllyLevels = false;

    void Update ()
    {
        var frameText = new StringBuilder();
        frameText.AppendLine("SCENE INFO");

        if (showSceneTime) frameText.AppendLine("Time: " + Time.timeSinceLevelLoad);
        if (showExperience) frameText.AppendLine("Experience: " + GameManager.HeroManager.Experience);

        if (showUnlockedAbilities) frameText.AppendLine("Unlocked Abilities: " + GameManager.AbilityManager.Unlocked.ToDelimitedString());
        if (showAssignedAbilities) frameText.AppendLine("Assigned Abilities: " + GameManager.AbilityManager.Assigned.ToDelimitedString());

        if (showUnlockedEquipment) frameText.AppendLine("Unlocked Equipment: " + GameManager.InventoryManager.Unlocked.ToDelimitedString());
        if (showAssignedEquipment) frameText.AppendLine("Assigned Equipment: " + GameManager.InventoryManager.Assigned.ToDelimitedString());

        if (showUnlockedAllies) frameText.AppendLine("Unlocked Allies: " + GameManager.RosterManager.Unlocked.ToDelimitedString());
        if (showAssignedAllies) frameText.AppendLine("Assigned Allies: " + GameManager.RosterManager.Assigned.ToDelimitedString());

        if (showFireballCooldown)
        {
            if (GameManager.Hero.HeroCombatController.AbilityCooldowns.ContainsKey("Defend"))
                frameText.AppendLine("Defend Cooldown: " + GameManager.Hero.HeroCombatController.AbilityCooldowns["Defend"]);
            else
                frameText.AppendLine("Defend not on cooldown.");
        }
        if (showFireballCooldown)
        {
            if (GameManager.Hero.HeroCombatController.AbilityCooldowns.ContainsKey("Fireball"))
                frameText.AppendLine("Fireball Cooldown: " + GameManager.Hero.HeroCombatController.AbilityCooldowns["Fireball"]);
            else
                frameText.AppendLine("Fireball not on cooldown.");
        }
        if (showCleaveCooldown)
        {
            if (GameManager.Hero.HeroCombatController.AbilityCooldowns.ContainsKey("Cleave"))
                frameText.AppendLine("Cleave Cooldown: " + GameManager.Hero.HeroCombatController.AbilityCooldowns["Cleave"]);
            else
                frameText.AppendLine("Cleave not on cooldown.");
        }
        if (showStormCooldown)
        {
            if (GameManager.Hero.HeroCombatController.AbilityCooldowns.ContainsKey("Storm"))
                frameText.AppendLine("Storm Cooldown: " + GameManager.Hero.HeroCombatController.AbilityCooldowns["Storm"]);
            else
                frameText.AppendLine("Storm not on cooldown.");
        }

        if (showHeroLevel) frameText.AppendLine("Hero Level: " + GameManager.HeroManager.Level);
        if (showAllyLevels)
        {
            foreach (var allyName in GameManager.RosterManager.Unlocked)
            {
                if (!GameManager.RosterManager.AllyLevels.ContainsKey(allyName)) GameManager.RosterManager.AllyLevels.Add(allyName, 1);
                frameText.AppendLine(allyName + " Level: " + GameManager.RosterManager.AllyLevels[allyName]);
            }
        }

        displayText.text = frameText.ToString();
	}
}
