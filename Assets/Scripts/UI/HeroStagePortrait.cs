using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the hero portrait.
/// </summary>
public class HeroStagePortrait : MonoBehaviour
{
    protected Image icon;

    /// <summary>
    /// Sets up the portrait.
    /// </summary>
    protected void Start()
    {
        icon = GetComponent<Image>();
        icon.sprite = GameManager.HeroManager.HeroObject.Icon;
    }
}