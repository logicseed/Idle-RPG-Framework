using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Creates the upgrade hero popup when the button is clicked.
/// </summary>
public class CreateUpgradeHeroPopupButton : MonoBehaviour
{
    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPopup);
    }

    /// <summary>
    /// Spawns the upgrade hero popup when the button is clicked.
    /// </summary>
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("UiCanvas");
        Instantiate(GameManager.GameSettings.Prefab.UI.UpgradeHeroPopup, canvas.transform, false);
    }
}