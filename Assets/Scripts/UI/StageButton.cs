using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls a button that takes the player to a stage.
/// </summary>
public class StageButton : MonoBehaviour
{
    [SerializeField]
    protected SceneField stage;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(LoadStage);

        var image = GetComponent<Image>();

        if (GameManager.WorldManager.UnlockedStages.Contains(stage.SceneName))
        {
            buttonComponent.interactable = true;
            image.color = Color.green;
        }
        else
        {
            buttonComponent.interactable = false;
            image.color = Color.gray;
        }
    }

    /// <summary>
    /// Loads the stage when the button is clicked.
    /// </summary>
    public void LoadStage()
    {
        GameManager.LoadStage(stage);
    }
}