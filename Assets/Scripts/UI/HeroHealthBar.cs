using UnityEngine;

/// <summary>
/// Controls the hero health bar.
/// </summary>
public class HeroHealthBar : MonoBehaviour
{
    [SerializeField]
    protected RectTransform foreground;

    /// <summary>
    /// Refreshes the health bar every GUI refresh.
    /// </summary>
    protected void OnGUI()
    {
        float percent = 0.0f;
        if (GameManager.Hero != null) percent = GameManager.Hero.HeroCombatController.CurrentHealth / (float)GameManager.Hero.Attributes.Health;
        foreground.localScale = new Vector3(percent, foreground.localScale.y, foreground.localScale.z);
    }
}