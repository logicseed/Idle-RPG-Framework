using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreatePopupButton : MonoBehaviour
{
    public GameObject popup;

    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPopup);
    }
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("UiCanvas");
        Instantiate(popup, canvas.transform, false);
    }
}
