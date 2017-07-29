using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

public class HeroController : GameCharacterController
{
    public override CharacterType type { get { return CharacterType.Hero; } }

    public Hero HeroObject;
    public List<Transform> spawnPoints;

    private HeroInputController inputControllerReference;
    public HeroInputController InputController { get { return inputControllerReference; } }

    public HeroCombatController heroCombat;

    public void Awake()
    {
        HeroObject = Resources.Load("Heroes/Hero") as Hero;
    }

    protected void Start()
    {
        derivedAttributes = new DerivedAttributes(HeroObject);

        CreateSpriteRenderer(HeroObject.icon);
        CreateAnimator(HeroObject.animator);
        CreateGraphicsController();
        CreateCombatController();
        CreateRigidbody2D();
        CreateCapsuleCollider2D();
        CreateMovementController(derivedAttributes.movementSpeed);
        CreateHeroInputController();

        GameManager.HeroManager.Register(this);

        SpawnAllies();
    }

    private void SpawnAllies()
    {
        var rosterManager = GameManager.RosterManager;

        for (int i = 0; i < rosterManager.Assigned.Count && i < spawnPoints.Count; i++)
        {
            var allyName = rosterManager.Assigned[i];
            var ally = Instantiate(GameManager.GameSettings.Prefab.Ally, spawnPoints[i].position, Quaternion.identity) as GameObject;
            ally.GetComponent<AllyController>().ally = rosterManager.GetEntityObject(allyName) as Ally;
            ally.name = allyName;
        }

        foreach (var spawnPoint in spawnPoints) Destroy(spawnPoint.gameObject);        
    }

    public void UseAbility(Ability ability)
    {
        if (heroCombat.Cooldowns.ContainsKey(ability.name))
        {
            Debug.Log("Ability is on cooldown: " + ability.name);
            return;
        }

        if (ability.abilityRange == AbilityRange.Self) PerformAbility(ability, this);

        if (ability.abilityRange == AbilityRange.Melee || ability.abilityRange == AbilityRange.Ranged)
        {
            if (combat.target == null)
            {
                Debug.Log("Awaiting target for " + ability.name);
                InputController.AwaitTarget(ability);
            }
            else
            {
                PerformAbility(ability, combat.target);
            }
        }
        
    }

    private void PerformAbility(Ability ability, GameCharacterController target)
    {
        heroCombat.Cooldowns.Add(ability.name, ability.cooldown);

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

    private void PerformAreaAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log("Performing area ability " + ability.name + " on " + target.name);
        var heroCombat = combat as HeroCombatController;

        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                heroCombat.PerformCleaveAbility(ability, target);
                break;
            case AbilityRange.Ranged:
                heroCombat.PerformStormAbility(ability, target);
                break;
            case AbilityRange.Self:
                break;

            default: break;
        }
    }

    private void PerformDirectAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log("Performing direct ability " + ability.name + " on " + target.name);
        var heroCombat = combat as HeroCombatController;

        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                combat.PerformMeleeAttack();
                break;
            case AbilityRange.Ranged:
                heroCombat.PerformFireball(ability, target);
                break;
            case AbilityRange.Self:
                break;

            default: break;
        }
    }

    private void PerformHealAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log("Performing heal ability " + ability.name + " on " + target.name);
        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                break;
            case AbilityRange.Ranged:
                break;
            case AbilityRange.Self:
                break;

            default: break;
        }
    }

    private void PerformShieldAbility(Ability ability, GameCharacterController target)
    {
        Debug.Log("Performing shield ability " + ability.name + " on " + target.name);
        switch (ability.abilityRange)
        {
            case AbilityRange.Melee:
                combat.PerformMeleeAttack();
                break;
            case AbilityRange.Ranged:
                combat.PerformRangedAttack();
                break;
            case AbilityRange.Self:
                heroCombat.PerformDefendAbility(ability);
                break;

            default: break;
        }
    }

    protected override void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<HeroCombatController>();
        heroCombat = combat as HeroCombatController;
    }

    protected override void CreateMovementController(float maxSpeed)
    {
        movementControllerReference = gameObject.AddComponent<HeroMovementController>();
        movementControllerReference.maxSpeed = maxSpeed;
    }

    private void CreateHeroInputController()
    {
        inputControllerReference = gameObject.AddComponent<HeroInputController>();
    }

    private void OnDestroy()
    {
        GameManager.HeroManager.Unregister(this);
    }

    public override AttackType attack
    {
        get
        {
            return HeroObject.attackType;
        }
    }
}
