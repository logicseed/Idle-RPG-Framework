using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private MovementController movementController;

    // Use this for initialization
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movementController = GetComponent<MovementController>();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateSortingOrder();
        UpdateAnimationState();
    }

    /// <summary>
    ///
    /// </summary>
    private void UpdateAnimationState()
    {
        // Get the last move direction
        try
        {
            var lastMoveDirection = movementController.LastMoveDirection;
            // Update animtion based on direction
        }
        catch (NullReferenceException)
        {
            movementController = GetComponent<MovementController>();
        }
    }

    /// <summary>
    /// Updates the rendering order of the game object based on vertical position.
    /// Objects higher on the screen are rendered behind objects that are lower.
    /// </summary>
    private void UpdateSortingOrder()
    {
        try
        {
            //spriteRenderer.sortingOrder = Convert.ToInt32( Mathf.Ceil(transform.position.y * -100) );
            spriteRenderer.sortingOrder = (int) (transform.position.y * -100);
        }
        catch (NullReferenceException)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
}
