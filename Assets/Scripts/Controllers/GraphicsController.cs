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
            if (!IsAttackAnimationPlaying()) animator.StopPlayback();

            var animationName = GetStateAnimationString();

            if (character.CharacterState == CharacterState.Melee ||
                character.CharacterState == CharacterState.Ranged ||
                character.CharacterState == CharacterState.Cast)
            {
                
                foreach (var clip in animator.runtimeAnimatorController.animationClips)
                {
                    if (clip.name == animationName)
                    {
                        if (clip.length > (1.0f / character.Attributes.AttackSpeed))
                        {
                            animator.speed = clip.length / (1.0f / character.Attributes.AttackSpeed);
                        }
                        else
                        {
                            animator.speed = 1.0f;
                        }
                        break;
                    }
                }

            }
            else
            {
                animator.speed = 1.0f;
            }

            animator.Play(animationName);
        }
        catch (NullReferenceException)
        {
            animator = GetComponent<Animator>();
        }
    }

    /// <summary>
    /// Whether or not an attack animation is playing.
    /// </summary>
    /// <returns>True if an attack animation is playing; false otherwise.</returns>
    public bool IsAttackAnimationPlaying()
    {
        var animLayer = animator.GetLayerIndex("Base Layer");
        if (animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Melee.ToString() + MoveDirection.Left.ToString()) ||
            animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Melee.ToString() + MoveDirection.Right.ToString()) ||
            animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Ranged.ToString() + MoveDirection.Left.ToString()) ||
            animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Ranged.ToString() + MoveDirection.Right.ToString()) ||
            animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Cast.ToString() + MoveDirection.Left.ToString()) ||
            animator.GetCurrentAnimatorStateInfo(animLayer).IsName(CharacterState.Cast.ToString() + MoveDirection.Right.ToString()))
        {
            return true;
        }
        else
        {
            return false;
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