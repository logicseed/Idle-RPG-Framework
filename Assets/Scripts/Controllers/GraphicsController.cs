using System;
using UnityEngine;

/// <summary>
/// Responsible for updating character graphics.
/// </summary>
public class GraphicsController : MonoBehaviour
{
    protected Animator animator;
    protected GameCharacterController character;
    protected SpriteRenderer spriteRenderer;

    /// <summary>
    /// Sets up the character graphics.
    /// </summary>
    protected void Start()
    {
        GetCharacterComponent();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Updates the character every frame.
    /// </summary>
    protected void Update()
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
            animator.StopPlayback();
            animator.Play(GetStateAnimationString());
        }
        catch (NullReferenceException)
        {
            animator = GetComponent<Animator>();
        }
    }

    /// <summary>
    /// Gets the character and subscribes to stage change events.
    /// </summary>
    public void GetCharacterComponent()
    {
        character = GetComponent<GameCharacterController>();

        if (character != null)
        {
            character.OnStateChanged += CharacterStateChanged;
            character.OnDirectionChanged += CharacterStateChanged;
        }
    }

    /// <summary>
    /// Combines a character's state and direction to become an animation state.
    /// </summary>
    /// <returns>A string in the form of (state)(direction) (e.g. "WalkLeft").</returns>
    public string GetStateAnimationString()
    {
        try
        {
            if (character.CharacterState == CharacterState.Dead)
            {
                return character.CharacterState.ToString();
            }
            else
            {
                return character.CharacterState.ToString() + character.LastDirection.ToString();
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
    public void UpdateSortingOrder()
    {
        try
        {
            spriteRenderer.sortingOrder = (int)(transform.position.y * -100);
            if (character.CharacterState == CharacterState.Dead) spriteRenderer.sortingOrder -= 2000;
        }
        catch (NullReferenceException)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
}