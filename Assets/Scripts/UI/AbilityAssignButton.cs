using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityAssignButton : MonoBehaviour
{
    public Button buttonComponent;
    private Image imageComponent;
    public string abilityName;

	void Awake()
    {
        buttonComponent.onClick.AddListener(HandleClick);
        imageComponent = buttonComponent.GetComponent<Image>();
    }
	
	public void Setup(string abilityName)
    {
        var ability = GameManager.AbilityManager.GetEntityObject(abilityName);
        this.abilityName = abilityName;
        imageComponent.sprite = ability.icon;
    }

    public void HandleClick()
    {
        // if in assigned; remove
        if (GameManager.AbilityManager.Assigned.Contains(abilityName))
        {
            GameManager.AbilityManager.RemoveAssigned(abilityName);
        }

        // if not in assigned and less than 3 assigned; assign
        else GameManager.AbilityManager.AddAssigned(abilityName);
    }
}
