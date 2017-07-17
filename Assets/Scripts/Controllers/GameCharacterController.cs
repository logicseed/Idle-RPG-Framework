using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides easy access to references to the various components of a character.
/// </summary>
public class GameCharacterController : MonoBehaviour
{
    public bool isCombatDummy = false;

    public RuntimeAnimatorController animatorController;
    public Animator animatorReference;
    protected CombatController combatControllerReference;
    protected GraphicsController graphicsControllerReference;
    protected MovementController movementControllerReference;
    public Rigidbody2D rigidbodyReference;
    protected LootDropManager lootDropManagerReference;

    protected GameObject floatingHealthBarReference;

    protected SpriteRenderer spriteRenderer;
    protected CapsuleCollider2D capsuleCollider2D;

    public BaseAttributes baseAttributes;
    //public BaseAttributes bonusAttributes;
    protected DerivedAttributes derivedAttributes;
    public DerivedAttributes attributes { get { return derivedAttributes; } }

    //public CharacterType type = CharacterType.None;
    public int level = 1;

    public delegate void CharacterDirectionChanged();
    public event CharacterDirectionChanged OnDirectionChanged;

    private MoveDirection lastDirection = MoveDirection.Right;
    public MoveDirection direction
    {
        get { return lastDirection; }
        set
        {
            if (lastDirection != value)
            {
                lastDirection = value;
                if (OnDirectionChanged != null) OnDirectionChanged();
            }
        }
    }

    public virtual CharacterType type { get { return CharacterType.None; } }
    public Vector3 location { get { return gameObject.transform.position; } }

    /// <summary>
    /// Character state change delegate signature.
    /// </summary>
    public delegate void CharacterStateChanged();

    /// <summary>
    /// Event handler for a character's state changing.
    /// </summary>
    /// <remarks>
    /// Subscribe in <c>Start()</c>, unsubscribe in <c>OnDestroy()</c>, and implement event method with signature
    /// Subscribe: <c>combatController.OnStateChanged += CharacterStateChanged;</c>
    /// Unsubscribe: <c>combatController.OnStateChanged -= CharacterStateChanged;</c>
    /// Signature: <c>public void CharacterStateChanged() { }</c>
    /// </remarks>
    public event CharacterStateChanged OnStateChanged;

    /// <summary>
    /// The current state of the character.
    /// </summary>
    public CharacterState characterState = CharacterState.Idle; //TODO: protected after debug

    /// <summary>
    /// Get or set the current state of the character.
    /// </summary>
    /// <remarks>Raises the state change event if the state changed.</remarks>
    public CharacterState state
    {
        get { return characterState; }
        set
        {
            if (characterState != value)
            {
                characterState = value;
                if (OnStateChanged != null) OnStateChanged();
                // If dead we don't want it counted as a character anymore
                if (characterState == CharacterState.Dead)
                {
                    gameObject.tag = "DeadBody";
                    GameObject.Destroy(floatingHealthBarReference);
                }
            }
        }
    }

    /// <summary>
    /// Returns a reference to the character's combat controller.
    /// </summary>
    public CombatController combat
    {
        get
        {
            if (combatControllerReference == null)
                combatControllerReference = GetComponent<CombatController>();

            return combatControllerReference;
        }
    }

    /// <summary>
    /// Returns a reference to the character's movement controller.
    /// </summary>
    public MovementController movement
    {
        get
        {
            return movementControllerReference;
        }
    }

    protected virtual void CreateAnimator(RuntimeAnimatorController animatorController)
    {
        animatorReference = gameObject.AddComponent<Animator>();
        animatorReference.runtimeAnimatorController = animatorController;
        animatorReference.Play("IdleRight");
        //animatorReference.StartPlayback();
    }

    protected virtual void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<CombatController>();
    }

    protected virtual void CreateGraphicsController()
    {
        graphicsControllerReference = gameObject.AddComponent<GraphicsController>();
    }

    protected virtual void CreateMovementController(float maxSpeed)
    {
        movementControllerReference = gameObject.AddComponent<MovementController>();
        movementControllerReference.maxSpeed = maxSpeed;
    }

    protected virtual void CreateRigidbody2D()
    {
        rigidbodyReference = gameObject.AddComponent<Rigidbody2D>();
        //rigidbodyReference.bodyType = RigidbodyType2D.Kinematic;
        //rigidbodyReference.isKinematic = true;
        //rigidbodyReference.useFullKinematicContacts = true;

        rigidbodyReference.gravityScale = 0.0f;
        rigidbodyReference.drag = 100;
        rigidbodyReference.angularDrag = 100;
        rigidbodyReference.mass = 100;
    }

    protected virtual void CreateSpriteRenderer(Sprite avatar)
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sortingLayerName = "Character";
        spriteRenderer.sprite = avatar;
    }

    protected virtual void CreateCapsuleCollider2D()
    {
        capsuleCollider2D = gameObject.AddComponent<CapsuleCollider2D>();
        capsuleCollider2D.offset = new Vector2(0.0f, -0.275f);
        capsuleCollider2D.size = new Vector2(0.4f, 0.2f);
        capsuleCollider2D.direction = CapsuleDirection2D.Horizontal;
    }

    public virtual AttackType attack
    {
        get
        {
            return AttackType.Melee;
        }
    }

    public bool IsFriendly
    {
        get
        {
            return type == CharacterType.Ally || type == CharacterType.Hero;
        }
    }
}
