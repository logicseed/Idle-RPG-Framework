using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(ResetGame);
    }
    public void ResetGame()
    {
        DestroyImmediate(GameManager.Instance.gameObject);
        var wasDeleted = SaveGameManager.DeleteSaveGame();
        Debug.Log("DELETED GAME: " + wasDeleted);
        SceneManager.LoadScene("Start");
    }
}
