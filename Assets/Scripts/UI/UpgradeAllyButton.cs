using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the button that upgrades an ally.
/// </summary>
public class UpgradeAllyButton : MonoBehaviour
{
    protected string allyName;

    [SerializeField]
    protected Button buttonComponent;

    [SerializeField]
    protected Image imageComponent;

    protected UpgradeAllyPopup list;

    [SerializeField]
    protected Text textComponent;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Awake()
    {
        buttonComponent.onClick.AddListener(UpgradeAlly);
    }

    /// <summary>
    /// Upgrades the ally when the button is clicked.
    /// </summary>
    protected void UpgradeAlly()
    {
        GameManager.UpgradeAlly(allyName);
        list.RefreshButtons();
    }
    /// <summary>
    /// Initializes the values of the button with an ally.
    /// </summary>
    /// <param name="allyName">The name of the ally.</param>
    /// <param name="list">The popup list of allies.</param>
    public void Initialize(string allyName, UpgradeAllyPopup list)
    {
        this.allyName = allyName;
        this.list = list;
        RefreshButton();
    }

    /// <summary>
    /// Refreshes the button based on ally data.
    /// </summary>
    public void RefreshButton()
    {
        var allyObject = GameManager.RosterManager.GetEntityObject(allyName);
        imageComponent.sprite = allyObject.Icon;

        var text = new StringBuilder();
        text.Append("Level: ");
        text.AppendLine(GameManager.RosterManager.AllyLevels[allyName].ToString());
        text.AppendLine();
        text.AppendLine("Upgrade");
        text.Append(GameManager.UpgradeAllyCost(allyName).ToString());
        text.Append(" XP");
        textComponent.text = text.ToString();

        buttonComponent.interactable = GameManager.CanUpgradeAlly(allyName);
    }
}