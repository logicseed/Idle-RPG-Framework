using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Processes clocks on the back to world button.
/// </summary>
public class BackToWorldButton : MonoBehaviour
{
    /// <summary>
    /// Sets up the back to world button.
    /// </summary>
    protected void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadWorld);
    }

    /// <summary>
    /// Loads the world scene when the button is clicked.
    /// </summary>
    public void LoadWorld()
    {
        GameManager.LoadWorld();
    }
}