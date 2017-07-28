using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using Debug = ConditionalDebug;

public class WorldEntityList : MonoBehaviour
{
    public ListableEntityType entityType;
    public WorldEntityListType listType;
    public ButtonAction buttonAction;
    public Transform contentPanel;
    private WorldEntityManager manager;
    private List<GameObject> buttons;

    void Start()
    {
        buttons = new List<GameObject>();
        manager = GameManager.GetManagerByType(entityType);

        if (listType == WorldEntityListType.Unlocked) manager.OnUnlockedListChanged += RefreshDisplay;
        else manager.OnAssignedListChanged += RefreshDisplay;

        RefreshDisplay();
    }

    void RefreshDisplay()
    {
        Debug.Log("Refreshing display: " + gameObject.name);
        RemoveButtons();
        AddButtons();
    }

    private void RemoveButtons()
    {
        foreach (var button in buttons)
        {
            Destroy(button);
        }
        buttons = new List<GameObject>();
    }

    private void AddButtons()
    {
        List<string> entityList;
        if (listType == WorldEntityListType.Unlocked) entityList = manager.Unlocked;
        else entityList = manager.Assigned;

        foreach (var entity in entityList)
        {
            var button = Instantiate(GameManager.GameSettings.Prefab.UI.WorldEntityButton) as GameObject;
            button.transform.SetParent(contentPanel, false);
            button.transform.name = entity;
            buttons.Add(button);

            var worldEntityButton = button.GetComponent<WorldEntityButton>();
            worldEntityButton.Initialize(entity, buttonAction, manager);
        }
    }

    private void OnDestroy()
    {
        if (listType == WorldEntityListType.Unlocked) manager.OnUnlockedListChanged -= RefreshDisplay;
        else manager.OnAssignedListChanged -= RefreshDisplay;
    }
}
