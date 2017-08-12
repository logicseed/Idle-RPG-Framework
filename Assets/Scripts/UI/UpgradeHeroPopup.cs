using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;

public class UpgradeHeroPopup : MonoBehaviour
{
    public Image spriteImage;
    public Text attributesText;
    public Button upgradeButton;
    public Text upgradeButtonText;


    // Use this for initialization
    void Start()
    {
        upgradeButton.onClick.AddListener(UpgradeHero);
        RefreshHeroData();
    }

    private void UpgradeHero()
    {
        GameManager.UpgradeHero();
        RefreshHeroData();
    }

    public void RefreshHeroData()
    {
        spriteImage.sprite = GameManager.HeroManager.HeroObject.icon;

        var attributes = new DerivedAttributes(GameManager.HeroManager.HeroObject);
        // Attribute text
        var text = new StringBuilder();
        text.Append("Level: ");
        text.AppendLine(GameManager.HeroManager.level.ToString());
        text.Append("Attack Damage: ");
        text.AppendLine(attributes.attackDamage.ToString());
        text.Append("Ability Damage: ");
        text.AppendLine(attributes.abilityDamage.ToString());
        text.Append("Defense: ");
        text.AppendLine(attributes.defense.ToString());
        text.Append("Health: ");
        text.AppendLine(attributes.health.ToString());
        text.Append("Health Regen: ");
        text.AppendLine(attributes.healthRegeneration.ToString());
        text.Append("Energy: ");
        text.AppendLine(attributes.energy.ToString());
        text.Append("Energy Regen: ");
        text.AppendLine(attributes.energyRegeneration.ToString());
        text.Append("Attack Speed: ");
        text.AppendLine(attributes.attackSpeed.ToString());
        text.Append("Critical Hit Chance: ");
        text.AppendLine(attributes.criticalHitChance.ToString());
        text.Append("Critical Hit Damage: ");
        text.AppendLine(attributes.criticalHitDamage.ToString());
        text.Append("Cooldown Reduction: ");
        text.AppendLine(attributes.cooldownReduction.ToString());
        text.Append("Life Drain: ");
        text.AppendLine(attributes.lifeDrain.ToString());
        text.Append("Movement Speed: ");
        text.AppendLine(attributes.movementSpeed.ToString());
        attributesText.text = text.ToString();

        // Upgrade buttont text
        text = new StringBuilder();
        text.AppendLine("UPGRADE");
        text.Append(GameManager.UpgradeHeroCost().ToString());
        text.Append(" XP");
        upgradeButtonText.text = text.ToString();
        upgradeButton.interactable = GameManager.CanUpgradeHero();
    }
}
