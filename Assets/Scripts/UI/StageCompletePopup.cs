using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StageCompletePopup : MonoBehaviour
{
    [SerializeField]
    protected Button button;

    /// <summary>
    /// Sets up the popup.
    /// </summary>
    protected void Start()
    {
        button.onClick.AddListener(EndStage);
        GameManager.OnStage = false;
    }

    /// <summary>
    /// Ends the stage when the button is clicked.
    /// </summary>
    private void EndStage()
    {
        GameManager.InitializeWorld();
    }
}
