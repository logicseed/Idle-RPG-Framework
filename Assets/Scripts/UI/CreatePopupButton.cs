using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Creates a popup window when button is clicked. Used for listable entity popups; roster, inventory, etc.
/// </summary>
public class CreatePopupButton : MonoBehaviour
{
    [SerializeField]
    protected GameObject popup;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPopup);
    }

    /// <summary>
    /// Spawns the popup window when the button is clicked.
    /// </summary>
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("PopupCanvas");
        if (canvas == null) canvas = Instantiate(GameManager.GameSettings.Prefab.UI.UiCanvas);
        canvas.name = "PopupCanvas";
        Instantiate(popup, canvas.transform, false);
    }
}