using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
/// Provides easy access to references to the various components of a character.
/// </summary>
public class GameCharacterController : MonoBehaviour
{
    protected Animator animatorReference;
    protected CapsuleCollider2D capsuleCollider2DReference;
    protected Character characterObjectReference;
    protected CharacterState characterState = CharacterState.Idle;
    protected CombatController combatControllerReference;
    protected DerivedAttributes derivedAttributes;
    protected GameObject floatingHealthBarReference;
    protected GraphicsController graphicsControllerReference;
    protected MoveDirection lastDirection = MoveDirection.Right;
    protected MovementController movementControllerReference;
    protected Rigidbody2D rigidbodyReference;
    protected SpriteRenderer spriteRendererReference;

    /// <summary>
    /// Returns the Character ScriptableObject.
    /// </summary>
    protected virtual Character CharacterObject { get { return characterObjectReference; } }

    /// <summary>
    /// Creates the animator controller for the character.
    /// </summary>
    protected virtual void CreateAnimator()
    {
        animatorReference = gameObject.AddComponent<Animator>();
        animatorReference.runtimeAnimatorController = CharacterObject.Animator;
        animatorReference.Play("IdleRight");
    }

    /// <summary>
    /// Creates the capsule collider for the character.
    /// </summary>
    protected virtual void CreateCapsuleCollider2D()
    {
        capsuleCollider2DReference = gameObject.AddComponent<CapsuleCollider2D>();
        capsuleCollider2DReference.offset = GameManager.GameSettings.Constants.Character.ColliderOffset;
        capsuleCollider2DReference.size = GameManager.GameSettings.Constants.Character.ColliderSize;
        capsuleCollider2DReference.direction = GameManager.GameSettings.Constants.Character.ColliderDirection;
    }

    /// <summary>
    /// Creates the combat controller for the character.
    /// </summary>
    protected virtual void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<CombatController>();
    }

    /// <summary>
    /// Creates derived attributes based on the character.
    /// </summary>
    public virtual void CreateDerivedAttributes() { }

    /// <summary>
    /// Creates the floating health bar for the character.
    /// </summary>
    protected void CreateFloatingHealthBar()
    {
        if (CharacterType != CharacterType.Hero)
        {
            floatingHealthBarReference = Instantiate(GameManager.GameSettings.Prefab.UI.FloatingBar, transform);
        }
    }

    /// <summary>
    /// Creates the graphics controller for the character.
    /// </summary>
    protected virtual void CreateGraphicsController()
    {
        graphicsControllerReference = gameObject.AddComponent<GraphicsController>();
    }

    /// <summary>
    /// Creates the movement controller for the character.
    /// </summary>
    protected virtual void CreateMovementController()
    {
        movementControllerReference = gameObject.AddComponent<MovementController>();
        movementControllerReference.MaxSpeed = Attributes.MovementSpeed;
    }

    /// <summary>
    /// Creates the 2D rigid body for the character.
    /// </summary>
    protected virtual void CreateRigidbody2D()
    {
        rigidbodyReference = gameObject.AddComponent<Rigidbody2D>();

        rigidbodyReference.gravityScale = GameManager.GameSettings.Constants.Character.RigidbodyGravityScale;
        rigidbodyReference.drag = GameManager.GameSettings.Constants.Character.RigidbodyDrag;
        rigidbodyReference.angularDrag = GameManager.GameSettings.Constants.Character.RigidbodyAngularDrag;
        rigidbodyReference.mass = GameManager.GameSettings.Constants.Character.RigidbodyMass;
    }

    /// <summary>
    /// Creates the sprite renderer for the character.
    /// </summary>
    protected virtual void CreateSpriteRenderer()
    {
        spriteRendererReference = gameObject.AddComponent<SpriteRenderer>();
        spriteRendererReference.sortingLayerName = "Character";
        spriteRendererReference.sprite = CharacterObject.Icon;
    }

    /// <summary>
    /// Called when the game object is destroyed.
    /// </summary>
    protected virtual void OnDestroy()
    {
        Unregister();
    }

    /// <summary>
    /// Registers the character with its respective manager.
    /// </summary>
    protected virtual void Register() { }

    /// <summary>
    /// Whether or not the character is a combat dummy.
    /// </summary>
    public bool isCombatDummy = false;

    /// <summary>
    /// Character direction change delegate signature.
    /// </summary>
    public delegate void CharacterDirectionChanged();

    /// <summary>
    /// Character state change delegate signature.
    /// </summary>
    public delegate void CharacterStateChanged();

    /// <summary>
    /// Event handler for a character's direction changing.
    /// </summary>
    public event CharacterDirectionChanged OnDirectionChanged;

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
    /// Returns the Animator for the character.
    /// </summary>
    public Animator Animator { get { return animatorReference; } }

    /// <summary>
    /// Returns the AttackType of the character.
    /// </summary>
    public virtual AttackType AttackType { get { return AttackType.Melee; } }

    /// <summary>
    /// Returns the derived attributes of the character.
    /// </summary>
    public DerivedAttributes Attributes
    {
        get
        {
            if (derivedAttributes == null)
            {
                Debug.LogError(gameObject.name + ": Attempted to access derived attributes on null Ally.");
                // Try to recover
                CreateDerivedAttributes();
            }
            return derivedAttributes;
        }
    }

    /// <summary>
    /// Get or set the current state of the character.
    /// </summary>
    /// <remarks>Raises the state change event if the state changed.</remarks>
    public CharacterState CharacterState
    {
        get { return characterState; }
        set
        {
            if (characterState != value) // Check for actual change
            {
                characterState = value;
                if (OnStateChanged != null) OnStateChanged();

                if (characterState == CharacterState.Dead)
                {
                    GameObject.Destroy(floatingHealthBarReference);
                }
            }
        }
    }

    /// <summary>
    /// Returns the CharacterType of the character.
    /// </summary>
    public virtual CharacterType CharacterType { get { return CharacterType.None; } }

    /// <summary>
    /// Returns a reference to the character's combat controller.
    /// </summary>
    public CombatController CombatController
    {
        get
        {
            if (combatControllerReference == null) CreateCombatController();

            return combatControllerReference;
        }
    }

    /// <summary>
    /// Returns a reference to the character's graphics controller.
    /// </summary>
    public GraphicsController GraphicsController
    {
        get
        {
            if (graphicsControllerReference == null) CreateGraphicsController();

            return graphicsControllerReference;
        }
    }

    /// <summary>
    /// Returns whether or not the character is considered friendly to the hero.
    /// </summary>
    public bool IsFriendly
    {
        get
        {
            return CharacterType == CharacterType.Ally || CharacterType == CharacterType.Hero;
        }
    }

    /// <summary>
    /// Returns the last direction the character was facing.
    /// </summary>
    public MoveDirection LastDirection
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

    /// <summary>
    /// Returns the level of the character.
    /// </summary>
    public virtual int Level { get { return 1; } }

    /// <summary>
    /// Returns the location of the character.
    /// </summary>
    public Vector3 Location { get { return gameObject.transform.position; } }

    /// <summary>
    /// Returns a reference to the character's movement controller.
    /// </summary>
    public MovementController MovementController
    {
        get
        {
            if (combatControllerReference == null) CreateMovementController();

            return movementControllerReference;
        }
    }

    /// <summary>
    /// Returns a reference to the character's rigidbody.
    /// </summary>
    public Rigidbody2D Rigidbody { get { return rigidbodyReference; } }

    /// <summary>
    /// Unregisters the character from its respective manager.
    /// </summary>
    public virtual void Unregister() { }

    /// <summary>
    /// Whether or not the character is dead.
    /// </summary>
    public virtual bool IsDead { get { return characterState == CharacterState.Dead; } }
}