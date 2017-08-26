using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls a button to go back from a popup window.
/// </summary>
public class PopupBackButton : MonoBehaviour
{
    [SerializeField]
    protected GameObject popupContainer;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(ClosePopup);
    }

    /// <summary>
    /// Closes the popup when the button is clicked.
    /// </summary>
    public void ClosePopup()
    {
        GameManager.Instance.SaveGame();
        Destroy(popupContainer);
    }
}