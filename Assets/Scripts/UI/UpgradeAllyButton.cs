using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;

public class UpgradeAllyButton : MonoBehaviour
{
    public Button buttonComponent;
    public Image imageComponent;
    public Text textComponent;
    public string allyName;

    private UpgradeAllyPopup list;

    void Awake()
    {
        buttonComponent.onClick.AddListener(UpgradeAlly);
    }

    private void UpgradeAlly()
    {
        GameManager.UpgradeAlly(allyName);
        list.RefreshButtons();
    }

    public void Initialize(string allyName, UpgradeAllyPopup list)
    {
        this.allyName = allyName;
        this.list = list;
        RefreshButton();
    }

    public void RefreshButton()
    {
        var allyObject = GameManager.RosterManager.GetEntityObject(allyName);
        imageComponent.sprite = allyObject.icon;

        var text = new StringBuilder();
        text.Append("Level: ");
        text.AppendLine(GameManager.RosterManager.levels[allyName].ToString());
        text.AppendLine();
        text.AppendLine("Upgrade");
        text.Append(GameManager.UpgradeAllyCost(allyName).ToString());
        text.Append(" XP");
        textComponent.text = text.ToString();

        buttonComponent.interactable = GameManager.CanUpgradeAlly(allyName);
    }
}
