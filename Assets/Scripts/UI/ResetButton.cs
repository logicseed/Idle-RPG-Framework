using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the button that resets the game.
/// </summary>
public class ResetButton : MonoBehaviour
{
    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(ResetGame);
    }

    /// <summary>
    /// Resets the game when the button is clicked.
    /// </summary>
    public void ResetGame()
    {
        DestroyImmediate(GameManager.Instance.gameObject);
        var wasDeleted = SaveGameManager.DeleteSaveGame();
        Debug.Log("DELETED GAME: " + wasDeleted);
        SceneManager.LoadScene("Start");
    }
}
