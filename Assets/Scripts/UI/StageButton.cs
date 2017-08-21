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

        CenterIfLastStage();
    }

    /// <summary>
    /// Loads the stage when the button is clicked.
    /// </summary>
    public void LoadStage()
    {
        GameManager.LoadStage(stage);
    }

    /// <summary>
    /// Centers the scroll view on this stage if it was the last stage visited.
    /// </summary>
    protected void CenterIfLastStage()
    {
        if (GameManager.WorldManager.LastStage != stage.SceneName) return;

        var scrollRect = GetComponentInParent<ScrollRect>();
        var buttonRect = GetComponent<RectTransform>();

        scrollRect.content.anchoredPosition -= buttonRect.anchoredPosition;
        scrollRect.horizontalNormalizedPosition = Mathf.Clamp(scrollRect.horizontalNormalizedPosition, 0f, 1f);
        scrollRect.verticalNormalizedPosition = Mathf.Clamp(scrollRect.verticalNormalizedPosition, 0f, 1f);
    }
}