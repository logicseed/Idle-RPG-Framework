using UnityEngine;
using UnityEngine.UI;

public class StageButton : MonoBehaviour
{
    public SceneField stage;

    // Use this for initialization
    void Start()
    {
        var buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(HandlePress);

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

    private void HandlePress()
    {
        GameManager.LoadStage(stage);
    }
}
