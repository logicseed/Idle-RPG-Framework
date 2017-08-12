using UnityEngine;
using System.Collections;

public class HeroEnergyBar : MonoBehaviour
{
    public RectTransform foreground;

    private void OnGUI()
    {
        float percent = GameManager.Hero.heroCombat.currentEnergy / (float)GameManager.Hero.attributes.energy;
        foreground.localScale = new Vector3(percent, foreground.localScale.y, foreground.localScale.z);
    }
}
