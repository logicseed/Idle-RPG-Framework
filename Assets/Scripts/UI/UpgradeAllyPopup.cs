using System;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAllyPopup : MonoBehaviour
{
    public Transform contentPanel;

    private List<UpgradeAllyButton> buttons;

    void Start()
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

    public void RefreshButtons()
    {
        foreach (var button in buttons) button.RefreshButton();
    }
}
