using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateUpgradeHeroPopupButton : MonoBehaviour
{
    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(SpawnPopup);
    }
    public void SpawnPopup()
    {
        var canvas = GameObject.Find("UiCanvas");
        Instantiate(GameManager.GameSettings.Prefab.UI.UpgradeHeroPopup, canvas.transform, false);
    }
}
