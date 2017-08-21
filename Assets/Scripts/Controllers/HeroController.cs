using System;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the Hero GameObject.
/// </summary>
public class HeroController : GameCharacterController
{
    private HeroInputController heroInputControllerReference;

    [SerializeField]
    private Hero heroObject;

    [SerializeField]
    private List<Transform> spawnPoints;

    /// <summary>
    /// Sets up the hero controller.
    /// </summary>
    private void Start()
    {
        if (heroObject == null) Debug.LogError(gameObject.name + ": HeroController was not provided a HeroObject.");

        CreateDerivedAttributes();
        CreateSpriteRenderer();
        CreateAnimator();
        CreateGraphicsController();
        CreateCombatController();
        CreateRigidbody2D();
        CreateCapsuleCollider2D();
        CreateMovementController();

        CreateHeroInputController();

        Register();

        SpawnAllies();
    }

    /// <summary>
    /// Returns the ScriptableObject for the character.
    /// </summary>
    protected override Character CharacterObject { get { return heroObject; } }

    /// <summary>
    /// Creates the hero's combat controller.
    /// </summary>
    protected override void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<HeroCombatController>();
    }

    /// <summary>
    /// Creates the derived attributes for the hero.
    /// </summary>
    protected override void CreateDerivedAttributes()
    {
        derivedAttributes = new DerivedAttributes(heroObject);
    }

    /// <summary>
    /// Creates the hero input controller.
    /// </summary>
    protected virtual void CreateHeroInputController()
    {
        heroInputControllerReference = gameObject.AddComponent<HeroInputController>();
    }

    protected override void CreateMovementController()
    {
        movementControllerReference = gameObject.AddComponent<HeroMovementController>();
        movementControllerReference.MaxSpeed = Attributes.movementSpeed;
    }

    /// <summary>
    /// Performs an ability on a target.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    protected void PerformAbility(Ability ability, GameCharacterController target)
    {
        HeroCombatController.AbilityCooldowns.Add(ability.name, ability.cooldown);

        switch (ability.abilityType)
        {
            case AbilityType.Area:
                PerformAreaAbility(ability, target);
                break;

            case AbilityType.Direct:
                PerformDirectAbility(ability, target);
                break;

            case AbilityType.Heal:
                PerformHealAbility(ability, target);
                break;

            case AbilityType.Shield:
                PerformShieldAbility(ability, target);
                break;

            default: break;
        }
    }

    /// <summary>
    /// Performs an area ability.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">Target at the center of the area ability.</param>
    protected void PerformAreaAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log(gameObject.name + ": Performing area ability " + ability.name + " on " + target.name);

        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                HeroCombatController.PerformMeleeAreaAbility(ability, target);
                break;

            case AbilityRange.Ranged:
                HeroCombatController.PerformRangedAreaAbility(ability, target);
                break;

            case AbilityRange.Self:
                // Not implemented
                break;

            default: break;
        }
    }

    /// <summary>
    /// Performs a direct ability on a target.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    protected void PerformDirectAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log(gameObject.name + ": Performing direct ability " + ability.name + " on " + target.name);

        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                HeroCombatController.PerformMeleeAttack();
                break;

            case AbilityRange.Ranged:
                HeroCombatController.PerformFireball(ability, target);
                break;

            case AbilityRange.Self:
                // Not implemented
                break;

            default: break;
        }
    }

    /// <summary>
    /// Performs a heal ability on a target. Placeholder.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    protected void PerformHealAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log(gameObject.name + ": Performing heal ability " + ability.name + " on " + target.name);

        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                // Not implemented
                break;

            case AbilityRange.Ranged:
                // Not implemented
                break;

            case AbilityRange.Self:
                // Not implemented
                break;

            default: break;
        }
    }

    /// <summary>
    /// Performs a shield ability on a target.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    protected void PerformShieldAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log(gameObject.name + ": Performing shield ability " + ability.name + " on " + target.name);
        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                // Not implemented
                break;

            case AbilityRange.Ranged:
                // Not implemented
                break;

            case AbilityRange.Self:
                HeroCombatController.PerformDefendAbility(ability);
                break;

            default: break;
        }
    }

    /// <summary>
    /// Registers the hero with the hero manager.
    /// </summary>
    protected override void Register()
    {
        try
        {
            GameManager.HeroManager.Register(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": Hero attempted to register with a HeroManager that doesn't exist.");
            Debug.LogException(e);
        }
    }

    /// <summary>
    /// Spawns the assigned allies.
    /// </summary>
    protected void SpawnAllies()
    {
        if (spawnPoints == null) spawnPoints = new List<Transform>();

        try
        {
            for (int i = 0; i < GameManager.RosterManager.Assigned.Count && i < spawnPoints.Count; i++)
            {
                var allyName = GameManager.RosterManager.Assigned[i];

                var allyGameObject = Instantiate(GameManager.GameSettings.Prefab.Ally, spawnPoints[i].position, Quaternion.identity) as GameObject;
                allyGameObject.name = allyName;

                var allyController = allyGameObject.GetComponent<AllyController>();
                allyController.AllyObject = GameManager.RosterManager.GetEntityObject(allyName) as Ally;

                Debug.Log(gameObject.name + " spawned " + allyName + " as an ally.");
            }
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": Could not spawn allies.");
            Debug.LogException(e);
        }
        finally
        {
            foreach (var spawnPoint in spawnPoints) Destroy(spawnPoint.gameObject);
        }
    }

    /// <summary>
    /// Returns the attack type of the hero.
    /// </summary>
    public override AttackType AttackType
    {
        get
        {
            try
            {
                return HeroObject.attackType;
            }
            catch (NullReferenceException e)
            {
                Debug.LogError(gameObject.name + ": Tried to access AttackType of HeroController that lacks a Hero object.");
                Debug.LogException(e);
                return AttackType.Melee;
            }
        }
    }

    /// <summary>
    /// Returns the character type of the hero.
    /// </summary>
    public override CharacterType CharacterType { get { return CharacterType.Hero; } }

    /// <summary>
    /// Returns the HeroCombatController for the hero.
    /// </summary>
    public HeroCombatController HeroCombatController { get { return combatControllerReference as HeroCombatController; } }

    // Set in the inspector
    /// <summary>
    /// Reference to the HeroInputController.
    /// </summary>
    public HeroInputController HeroInputController { get { return heroInputControllerReference; } }

    public HeroMovementController HeroMovementController { get { return movementControllerReference as HeroMovementController; } }

    /// <summary>
    /// The ScritableObject of the hero.
    /// </summary>
    public Hero HeroObject { get { return heroObject; } set { heroObject = value; } }

    /// <summary>
    /// Unregisters the hero from the hero manager.
    /// </summary>
    public override void Unregister()
    {
        try
        {
            GameManager.HeroManager.Unregister(this);
        }
        catch (NullReferenceException e)
        {
            Debug.LogWarning(gameObject.name + ": GameManager destroyed before Hero could unregister; this should only happen in the editor.");
            Debug.LogException(e);
        }
    }

    /// <summary>
    /// Attempts to use an ability. Does nothing if the ability is on cooldown. Awaits
    /// a target if the ability requires one.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    public void UseAbility(Ability ability)
    {
        if (HeroCombatController.AbilityCooldowns.ContainsKey(ability.name))
        {
            Debug.Log(gameObject.name + ": " + ability.name + " is on cooldown.");
            return;
        }

        if (ability.abilityRange == AbilityRange.Self) PerformAbility(ability, this);

        if (ability.abilityRange == AbilityRange.Melee || ability.abilityRange == AbilityRange.Ranged)
        {
            if (HeroCombatController.TargetController == null)
            {
                Debug.Log(gameObject.name + ": Awaiting target for " + ability.name + ".");
                HeroInputController.AwaitTarget(ability);
            }
            else
            {
                PerformAbility(ability, CombatController.TargetController);
            }
        }
    }
}