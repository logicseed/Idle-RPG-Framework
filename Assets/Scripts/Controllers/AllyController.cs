using System;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the Ally GameObject.
/// </summary>
public class AllyController : GameCharacterController
{
    /// <summary>
    /// Sets up the ally controller.
    /// </summary>
    private void Start()
    {
        if (characterObjectReference == null) Debug.LogError(gameObject.name + ": AllyController was not provided an AllyObject.");

        // Create all the pieces of the ally.
        CreateDerivedAttributes();
        CreateCombatController();
        CreateSpriteRenderer();
        CreateAnimator();
        CreateGraphicsController();
        CreateMovementController();
        CreateRigidbody2D();
        CreateCapsuleCollider2D();
        CreateFloatingHealthBar();

        Register();
    }

    /// <summary>
    /// Creates the derived attributes for the ally.
    /// </summary>
    protected override void CreateDerivedAttributes()
    {
        derivedAttributes = new DerivedAttributes(AllyObject);
    }

    /// <summary>
    /// Registers this Ally with the AllyManager.
    /// </summary>
    protected override void Register()
    {
        try
        {
            GameManager.AllyManager.Register(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": Ally attempted to register with an AllyManager that doesn't exist.");
            Debug.LogException(e);
        }
    }

    /// <summary>
    /// Returns the ScriptableObject that represents the Ally.
    /// </summary>
    public Ally AllyObject { get { return characterObjectReference as Ally; } set { characterObjectReference = value; } }

    /// <summary>
    /// Gets the AttackType of the Ally.
    /// </summary>
    public override AttackType AttackType
    {
        get
        {
            try
            {
                return AllyObject.AttackType;
            }
            catch (NullReferenceException e)
            {
                Debug.LogError(gameObject.name + ": Tried to access AttackType of AllyController that lacks an Ally object.");
                Debug.LogException(e);
                return AttackType.Melee;
            }
        }
    }

    /// <summary>
    /// Returns the CharacterType of the Ally.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Ally; } }

    /// <summary>
    /// Unregisters this Ally from the AllyManager.
    /// </summary>
    public override void Unregister()
    {
        try
        {
            GameManager.AllyManager.Unregister(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": GameManager destroyed before Ally could unregister; this should only happen in the editor.");
            Debug.LogException(e);
        }
    }
}