using UnityEngine;
using System.Collections;

public class HeroHealthBar : MonoBehaviour
{
    public RectTransform foreground;

    private void OnGUI()
    {
        float percent = GameManager.Hero.heroCombat.currentHealth / (float)GameManager.Hero.attributes.health;
        foreground.localScale = new Vector3(percent, foreground.localScale.y, foreground.localScale.z);
    }
}
