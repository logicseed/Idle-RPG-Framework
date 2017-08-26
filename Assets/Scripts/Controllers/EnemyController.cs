using System;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the Enemy GameObject.
/// </summary>
public class EnemyController : GameCharacterController
{
    /// <summary>
    /// Sets up the enemy controller.
    /// </summary>
    private void Start()
    {
        if (characterObjectReference == null) Debug.LogError(gameObject.name + ": EnemyController was not provided an EnemyObject.");

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
    /// Creates derived attributes for the enemy.
    /// </summary>
    public override void CreateDerivedAttributes()
    {
        derivedAttributes = new DerivedAttributes(EnemyObject, Level);
    }

    /// <summary>
    /// Level of the enemy.
    /// </summary>
    public override int Level { get { return EnemyObject.Level; } }

    /// <summary>
    /// Registers the enemy with the enemy manager.
    /// </summary>
    protected override void Register()
    {
        try
        {
            GameManager.EnemyManager.Register(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": Enemy attempted to register with an EnemyManager that doesn't exist.");
            Debug.LogException(e);
        }
    }

    /// <summary>
    /// Returns the attack type of the enemy.
    /// </summary>
    public override AttackType AttackType
    {
        get
        {
            try
            {
                return EnemyObject.AttackType;
            }
            catch (NullReferenceException e)
            {
                Debug.LogError(gameObject.name + ": Tried to access AttackType of EnemyController that lacks an Enemy object.");
                Debug.LogException(e);
                return AttackType.Melee;
            }
        }
    }

    /// <summary>
    /// Returns the CharacterType of the enemy.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Enemy; } }

    /// <summary>
    /// Returns the scriptable object of the enemy.
    /// </summary>
    //public Enemy EnemyObject { get { return enemyObject; } set { enemyObject = value; } }
    public Enemy EnemyObject { get { return characterObjectReference as Enemy; } set { characterObjectReference = value; } }

    /// <summary>
    /// Unregisters the enemy with the enemy manager.
    /// </summary>
    public override void Unregister()
    {
        try
        {
            GameManager.EnemyManager.Unregister(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": GameManager destroyed before Enemy could unregister; this should only happen in the editor.");
            Debug.LogException(e);
        }
    }
}