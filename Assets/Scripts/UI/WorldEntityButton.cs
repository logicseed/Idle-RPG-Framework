using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class WorldEntityButton : MonoBehaviour
{
    public Button buttonComponent;
    private Image imageComponent;
    public string entityName;

    private ButtonAction buttonAction = ButtonAction.None;
    private WorldEntityManager manager = null;

    void Awake()
    {
        buttonComponent.onClick.AddListener(HandleClick);
        imageComponent = buttonComponent.GetComponent<Image>();
    }

    public void Initialize(string entityName, ButtonAction buttonAction, WorldEntityManager manager)
    {
        this.entityName = entityName;
        this.buttonAction = buttonAction;
        this.manager = manager;
        var entityObject = manager.GetEntityObject(entityName);
        imageComponent.sprite = entityObject.icon;
    }

    public void HandleClick()
    {
        switch (buttonAction)
        {
            case ButtonAction.Assign:
                HandleAssignClick();
                break;
            case ButtonAction.Use:
                HandleUseClick();
                break;
            case ButtonAction.None:
            default:
                break;
        }
    }

    private void HandleAssignClick()
    {
        if (manager.Assigned.Contains(entityName)) manager.RemoveAssigned(entityName);
        else manager.AddAssigned(entityName);
    }

    private void HandleUseClick()
    {
        throw new NotImplementedException();
    }
}
