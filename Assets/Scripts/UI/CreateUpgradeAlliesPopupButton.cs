using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateUpgradeAlliesPopupButton : MonoBehaviour
{
    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPopup);
    }
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("UiCanvas");
        Instantiate(GameManager.GameSettings.Prefab.UI.UpgradeAlliesPopup, canvas.transform, false);
    }
}
