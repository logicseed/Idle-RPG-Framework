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

    private void Start()
    {
        movementController = gameObject.GetComponent<MovementController>();
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
        try
        {
            movementController.SetLocationTarget(Camera.main.ScreenToWorldPoint(position));
        }
        catch (NullReferenceException)
        {
            movementController = gameObject.GetComponent<MovementController>();
        }
    }
}
