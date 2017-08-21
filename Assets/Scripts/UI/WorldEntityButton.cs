using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls a world entity button.
/// </summary>
public class WorldEntityButton : MonoBehaviour
{
    protected ButtonAction buttonAction = ButtonAction.None;

    [SerializeField]
    protected Button buttonComponent;

    protected string entityName;

    protected Image imageComponent;

    protected WorldEntityManager manager = null;

    /// <summary>
    /// Sets up the button.
    /// </summary>
    protected void Awake()
    {
        buttonComponent.onClick.AddListener(HandleClick);
        imageComponent = buttonComponent.GetComponent<Image>();
    }

    /// <summary>
    /// Assigns the world entity when the button is clicked.
    /// </summary>
    protected void HandleAssignClick()
    {
        if (entityName == "Defend") return;
        if (manager.Assigned.Contains(entityName)) manager.RemoveAssigned(entityName);
        else manager.AddAssigned(entityName);
    }

    /// <summary>
    /// Handles the button click based on the specified action.
    /// </summary>
    protected void HandleClick()
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

    /// <summary>
    /// Uses the world entity when the button is clicked.
    /// </summary>
    protected void HandleUseClick()
    {
        var entityObject = manager.GetEntityObject(entityName);
        if (entityObject.ListableType == ListableEntityType.Ability) GameManager.Hero.UseAbility(entityObject as Ability);
    }

    /// <summary>
    /// Updates the button based on world state.
    /// </summary>
    protected void Update()
    {
        if (buttonAction == ButtonAction.Use)
        {
            var entityObject = manager.GetEntityObject(entityName);
            if (entityObject.ListableType == ListableEntityType.Ability)
            {
                buttonComponent.interactable = !GameManager.Hero.HeroCombatController.AbilityCooldowns.ContainsKey(entityName);
            }
        }
    }

    /// <summary>
    /// Initializes the button with data from the world entity.
    /// </summary>
    /// <param name="entityName">The name of the entity.</param>
    /// <param name="buttonAction">The action taken when the button is clicked.</param>
    /// <param name="manager">The world entity manager for this type of entity.</param>
    public void Initialize(string entityName, ButtonAction buttonAction, WorldEntityManager manager)
    {
        this.entityName = entityName;
        this.buttonAction = buttonAction;
        this.manager = manager;
        var entityObject = manager.GetEntityObject(entityName);
        imageComponent.sprite = entityObject.Icon;
    }
}