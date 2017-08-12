using UnityEngine;
using UnityEngine.UI;

public class ZoneButton : MonoBehaviour
{
    public SceneField zone;

    // Use this for initialization
    void Start()
    {
        var buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(HandlePress);

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
    }

    private void HandlePress()
    {
        GameManager.LoadZone(zone);
    }
}
