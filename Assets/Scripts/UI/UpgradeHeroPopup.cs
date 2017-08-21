using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the upgrade hero popup.
/// </summary>
public class UpgradeHeroPopup : MonoBehaviour
{
    [SerializeField]
    protected Text attributesText;

    [SerializeField]
    protected Image spriteImage;

    [SerializeField]
    protected Button upgradeButton;

    [SerializeField]
    protected Text upgradeButtonText;

    /// <summary>
    /// Sets up the popup.
    /// </summary>
    protected void Start()
    {
        upgradeButton.onClick.AddListener(UpgradeHero);
        RefreshHeroData();
    }

    /// <summary>
    /// Upgrades the hero when the button is clicked.
    /// </summary>
    protected void UpgradeHero()
    {
        GameManager.UpgradeHero();
        RefreshHeroData();
    }

    /// <summary>
    /// Refreshes the hero data displayed on the popup.
    /// </summary>
    public void RefreshHeroData()
    {
        spriteImage.sprite = GameManager.HeroManager.HeroObject.Icon;

        var attributes = new DerivedAttributes(GameManager.HeroManager.HeroObject);
        // Attribute text
        var text = new StringBuilder();
        text.Append("Level: ");
        text.AppendLine(GameManager.HeroManager.Level.ToString());
        text.Append("Attack Damage: ");
        text.AppendLine(attributes.AttackDamage.ToString());
        text.Append("Ability Damage: ");
        text.AppendLine(attributes.AbilityDamage.ToString());
        text.Append("Defense: ");
        text.AppendLine(attributes.Defense.ToString());
        text.Append("Health: ");
        text.AppendLine(attributes.Health.ToString());
        text.Append("Health Regen: ");
        text.AppendLine(attributes.HealthRegeneration.ToString());
        text.Append("Energy: ");
        text.AppendLine(attributes.Energy.ToString());
        text.Append("Energy Regen: ");
        text.AppendLine(attributes.EnergyRegeneration.ToString());
        text.Append("Attack Speed: ");
        text.AppendLine(attributes.AttackSpeed.ToString());
        text.Append("Critical Hit Chance: ");
        text.AppendLine(attributes.CriticalHitChance.ToString());
        text.Append("Critical Hit Damage: ");
        text.AppendLine(attributes.CriticalHitDamage.ToString());
        text.Append("Cooldown Reduction: ");
        text.AppendLine(attributes.CooldownReduction.ToString());
        text.Append("Life Drain: ");
        text.AppendLine(attributes.LifeDrain.ToString());
        text.Append("Movement Speed: ");
        text.AppendLine(attributes.MovementSpeed.ToString());
        attributesText.text = text.ToString();

        // Upgrade button text
        text = new StringBuilder();
        text.AppendLine("UPGRADE");
        text.Append(GameManager.UpgradeHeroCost.ToString());
        text.Append(" XP");
        upgradeButtonText.text = text.ToString();
        upgradeButton.interactable = GameManager.CanUpgradeHero;
    }
}