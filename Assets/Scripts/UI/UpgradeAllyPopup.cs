using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the popup list of ally upgrade buttons.
/// </summary>
public class UpgradeAllyPopup : MonoBehaviour
{
    protected List<UpgradeAllyButton> buttons;

    [SerializeField]
    protected Transform contentPanel;
    /// <summary>
    /// Sets up the popup.
    /// </summary>
    protected void Start()
    {
        buttons = new List<UpgradeAllyButton>();

        foreach (var ally in GameManager.RosterManager.Unlocked)
        {
            var button = Instantiate(GameManager.GameSettings.Prefab.UI.UpgradeAllyButton, contentPanel, false);

            var upgradeAllyButton = button.GetComponent<UpgradeAllyButton>();
            buttons.Add(upgradeAllyButton);
            upgradeAllyButton.Initialize(ally, this);
        }
    }

    /// <summary>
    /// Refreshes all of the upgrade ally buttons.
    /// </summary>
    public void RefreshButtons()
    {
        foreach (var button in buttons) button.RefreshButton();
    }
}