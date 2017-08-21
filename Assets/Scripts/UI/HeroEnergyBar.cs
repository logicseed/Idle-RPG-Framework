using UnityEngine;

/// <summary>
/// Controls the hero energy bar.
/// </summary>
public class HeroEnergyBar : MonoBehaviour
{
    [SerializeField]
    protected RectTransform foreground;

    /// <summary>
    /// Refreshes energy bar every GUI refresh.
    /// </summary>
    protected void OnGUI()
    {
        float percent = GameManager.Hero.HeroCombatController.CurrentEnergy / (float)GameManager.Hero.Attributes.Energy;
        foreground.localScale = new Vector3(percent, foreground.localScale.y, foreground.localScale.z);
    }
}