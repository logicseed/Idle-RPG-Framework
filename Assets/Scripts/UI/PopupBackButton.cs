using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopupBackButton : MonoBehaviour
{
    public GameObject popupContainer;

    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(ClosePopup);
    }

    public void ClosePopup()
    {
        GameManager.Instance.SaveGame();
        Destroy(popupContainer);
    }
}
