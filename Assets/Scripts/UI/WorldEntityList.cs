using UnityEngine;
using System.Collections;
using System;

public class WorldEntityList : MonoBehaviour
{
    public ListableEntityType entityType;
    public ButtonAction buttonAction;
    public Transform contentPanel;

    void Start()
    {
        RefreshDisplay();
    }

    void RefreshDisplay()
    {
        RemoveButtons();
        AddButtons();
    }

    private void RemoveButtons()
    {
        while (contentPanel.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    private void AddButtons()
    {
        var manager = GameManager.GetManagerByType(entityType);

        foreach (var entity in manager.Unlocked)
        {
            var button = Instantiate(Resources.Load("UI/WorldEntityButton")) as GameObject;
            button.transform.SetParent(contentPanel, false);
            button.transform.name = entity;

            var worldEntityButton = button.GetComponent<WorldEntityButton>();
            worldEntityButton.Initialize(entity, buttonAction, manager);
        }
    }
}
