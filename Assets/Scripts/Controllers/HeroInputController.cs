using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    private void ProcessTap(Vector2 position)
    {
        movementController.SetLocationTarget(Camera.main.ScreenToWorldPoint(position));
    }
}
