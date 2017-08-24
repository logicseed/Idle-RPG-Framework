using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Creates the upgrade ally popup when the button is clicked.
/// </summary>
public class CreateUpgradeAlliesPopupButton : MonoBehaviour
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
    /// Spawns the upgrade ally popup when the button is clicked.
    /// </summary>
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("PopupCanvas");
        if (canvas == null) canvas = Instantiate(GameManager.GameSettings.Prefab.UI.UiCanvas);
        canvas.name = "PopupCanvas";
        Instantiate(GameManager.GameSettings.Prefab.UI.UpgradeAlliesPopup, canvas.transform, false);
    }
}