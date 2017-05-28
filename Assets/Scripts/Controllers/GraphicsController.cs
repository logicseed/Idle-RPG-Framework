using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsController : MonoBehaviour
{
    /*
	 * Animation States:
	 * 0 : Idle Left
	 * 1 : Idle Right
     * 2 : Walk Left
     * 3 : Walk Right
	 */

    private SpriteRenderer spriteRenderer;
    private MovementController movementController;
    private Animator anim;

    // Use this for initialization
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movementController = GetComponent<MovementController>();
        anim = GetComponent<Animator>();
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
        //Update the movement animation
        MovementAnimationState();
    }

    /// <summary>
    /// Keeps track of the movement animation states and updates them accordingly
    /// </summary>
    private void MovementAnimationState()
    {
        // Get the last move direction
        try
        {
            var lastMoveDirection = movementController.LastMoveDirection;

            // Update animtion based on direction
            if(lastMoveDirection == MoveDirection.None)
            {
                //If prev animation played is left
                if(anim.GetInteger("state") == 2)
                    anim.SetInteger("state", 0);

                //If prev animation played is right
                if (anim.GetInteger("state") == 3)
                    anim.SetInteger("state", 1);
            }
            else if(lastMoveDirection == MoveDirection.Left)
                anim.SetInteger("state", 2);
            else if (lastMoveDirection == MoveDirection.Right)
                anim.SetInteger("state", 3);
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
