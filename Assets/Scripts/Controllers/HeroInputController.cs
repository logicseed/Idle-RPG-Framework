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

    public void Awake()
    {
        movementController = gameObject.GetComponent<MovementController>();
    }

    public void Update()
    {
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

        if (Input.GetMouseButton(0))
        {
            ProcessTap(Input.mousePosition);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("World"); }
    }

    private void ProcessTap(Vector2 position)
    {
        movementController.SetLocationTarget(Camera.main.ScreenToWorldPoint(position));
    }
}
