using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///
/// </summary>
public class HeroInputController : MonoBehaviour
{
    MovementController movementController;
    BaseCombatController combatController;

    private void Start()
    {
        movementController = gameObject.GetComponent<MovementController>();
        combatController = gameObject.GetComponent<BaseCombatController>();
    }

    private void Update()
    {
        // Process touch input
        if (Input.touchCount > 0)
        {
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    ProcessTap(touch.position);
                }
            }
        }

        // Process keyboard input
        if (Input.GetMouseButton(0))
        {
            ProcessTap(Input.mousePosition);
        }

        // This works with the Android back button too
        if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("World"); }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="position"></param>
    private void ProcessTap(Vector2 position)
    {
        var worldPosition = Camera.main.ScreenToWorldPoint(position);

        // Character tap
        foreach ( var character in GameManager.Instance.AllCharacters)
        {
            if (Vector2.Distance(worldPosition, character.transform.position) < 0.1f) //TODO: No magic numbers
            {
                try
                {
                    combatController.characterTarget = character;
                    return;
                }
                catch (NullReferenceException)
                {
                    combatController = gameObject.GetComponent<BaseCombatController>();
                    return;
                }
            }
        }

        // Location tap
        try
        {
            movementController.SetLocationTarget(worldPosition);
        }
        catch (NullReferenceException)
        {
            movementController = gameObject.GetComponent<MovementController>();
        }
    }
}
