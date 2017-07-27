using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityAssignList : MonoBehaviour
{
    public Transform contentPanel;

	// Use this for initialization
	void Start ()
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
        foreach (var ability in GameManager.AbilityManager.Unlocked)
        {
            var button = Instantiate(Resources.Load("UI/AbilityAssignButton")) as GameObject;
            button.transform.SetParent(contentPanel, false);
            button.transform.name = ability;

            var abilityAssignButton = button.GetComponent<AbilityAssignButton>();
            abilityAssignButton.Setup(ability);
        }
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
