using System;
using UnityEngine;

/// <summary>
/// Responsible for updating character graphics.
/// </summary>
public class GraphicsController : MonoBehaviour
{
    private CharacterManager character;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Start()
    {
        GetCharacterComponent();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void GetCharacterComponent()
    {
        character = GetComponent<CharacterManager>();

        if (character != null)
        {
            character.OnStateChanged += CharacterStateChanged;
            character.OnDirectionChanged += CharacterStateChanged;
        }
    }

    private void Update()
    {
        UpdateSortingOrder();
    }

    /// <summary>
    /// Event handler for a character's state changing. Updates the character's
    /// animation based on the new state.
    /// </summary>
    public void CharacterStateChanged()
    {
        try
        {
            animator.Play(GetStateAnimationString());
        }
        catch (NullReferenceException)
        {
            animator = GetComponent<Animator>();
        }
    }

    /// <summary>
    /// Combines a character's state and direction to become an animation state.
    /// </summary>
    /// <returns>A string in the form of (state)(direction) (e.g. "WalkLeft").</returns>
    private string GetStateAnimationString()
    {
        try
        {
            if (character.state == CharacterState.Dead)
            {
                return character.state.ToString();
            }
            else
            {
                return character.state.ToString() + character.direction.ToString();
            }
        }
        catch (NullReferenceException)
        {
            GetCharacterComponent();
            return String.Empty;
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
            spriteRenderer.sortingOrder = (int) (transform.position.y * -100);
        }
        catch (NullReferenceException)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    ///// <summary>
    /////
    ///// </summary>
    //private void UpdateAnimationState()
    //{
    //    //Update the movement animation
    //    MovementAnimationState();
    //}

    ///// <summary>
    ///// Keeps track of the movement animation states and updates them accordingly
    ///// </summary>
    //private void MovementAnimationState()
    //{
    //    // Get the last move direction
    //    try
    //    {
    //        var lastMoveDirection = movementController.LastMoveDirection;

    //        // Update animtion based on direction
    //        if(lastMoveDirection == MoveDirection.None)
    //        {
    //            //If prev animation played is left
    //            if(animator.GetInteger("state") == 2)
    //                animator.SetInteger("state", 0);

    //            //If prev animation played is right
    //            if (animator.GetInteger("state") == 3)
    //                animator.SetInteger("state", 1);
    //        }
    //        else if(lastMoveDirection == MoveDirection.Left)
    //            animator.SetInteger("state", 2);
    //        else if (lastMoveDirection == MoveDirection.Right)
    //            animator.SetInteger("state", 3);
    //    }
    //    catch (NullReferenceException)
    //    {
    //        movementController = GetComponent<MovementController>();
    //    }
    //}

}
