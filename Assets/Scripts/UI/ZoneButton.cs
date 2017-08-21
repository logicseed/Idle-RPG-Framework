using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls a button that loads a zone.
/// </summary>
public class ZoneButton : MonoBehaviour
{
    [SerializeField]
    protected SceneField zone;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Start()
    {
        var buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(LoadZone);

        var image = GetComponent<Image>();

        if (GameManager.WorldManager.UnlockedZones.Contains(zone.SceneName))
        {
            buttonComponent.interactable = true;
            image.color = Color.green;
        }
        else
        {
            buttonComponent.interactable = false;
            image.color = Color.gray;
        }

        CenterIfLastZone();
    }

    /// <summary>
    /// Loads the zone scene when the button is clicked.
    /// </summary>
    public void LoadZone()
    {
        GameManager.LoadZone(zone);
    }

    /// <summary>
    /// Centers the scroll view on this butotn if it was the last zone visited.
    /// </summary>
    protected void CenterIfLastZone()
    {
        if (GameManager.WorldManager.LastZone != zone.SceneName) return;

        var scrollRect = GetComponentInParent<ScrollRect>();
        var buttonRect = GetComponent<RectTransform>();

        scrollRect.content.anchoredPosition -= buttonRect.anchoredPosition;
        scrollRect.horizontalNormalizedPosition = Mathf.Clamp(scrollRect.horizontalNormalizedPosition, 0f, 1f);
        scrollRect.verticalNormalizedPosition = Mathf.Clamp(scrollRect.verticalNormalizedPosition, 0f, 1f);
    }
}