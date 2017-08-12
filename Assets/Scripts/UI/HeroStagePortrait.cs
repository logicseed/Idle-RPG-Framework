using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeroStagePortrait : MonoBehaviour
{
    private Image icon;

    private void Start()
    {
        icon = GetComponent<Image>();
        icon.sprite = GameManager.HeroManager.HeroObject.icon;
    }
}
