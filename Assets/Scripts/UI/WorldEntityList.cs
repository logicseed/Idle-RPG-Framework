using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls a list of world entities.
/// </summary>
public class WorldEntityList : MonoBehaviour
{
    [SerializeField]
    protected WorldEntityListType listType;

    [SerializeField]
    protected ListableEntityType entityType;

    [SerializeField]
    protected ButtonAction buttonAction;

    [SerializeField]
    protected Transform contentPanel;

    protected List<GameObject> buttons;

    protected WorldEntityManager manager;

    /// <summary>
    /// Adds button based on the content of the list.
    /// </summary>
    protected void AddButtons()
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

    /// <summary>
    /// Unsubscribes from refresh events when destroyed.
    /// </summary>
    protected void OnDestroy()
    {
        if (listType == WorldEntityListType.Unlocked) manager.OnUnlockedListChanged -= RefreshDisplay;
        else manager.OnAssignedListChanged -= RefreshDisplay;
    }

    /// <summary>
    /// Refreshes the list.
    /// </summary>
    protected void RefreshDisplay()
    {
        RemoveButtons();
        AddButtons();
    }

    /// <summary>
    /// Removes all existing buttons.
    /// </summary>
    protected void RemoveButtons()
    {
        foreach (var button in buttons)
        {
            Destroy(button);
        }
        buttons = new List<GameObject>();
    }

    /// <summary>
    /// Sets up the list.
    /// </summary>
    protected void Start()
    {
        buttons = new List<GameObject>();
        manager = GameManager.GetManagerByType(entityType);

        if (listType == WorldEntityListType.Unlocked) manager.OnUnlockedListChanged += RefreshDisplay;
        else manager.OnAssignedListChanged += RefreshDisplay;

        RefreshDisplay();
    }
}