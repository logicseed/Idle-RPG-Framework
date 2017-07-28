using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

public class HeroController : GameCharacterController
{
    public override CharacterType type { get { return CharacterType.Hero; } }

    public Hero hero;
    public List<Transform> spawnPoints;

    public void Awake()
    {
        hero = Resources.Load("Heroes/Hero") as Hero;
    }

    protected void Start()
    {
        derivedAttributes = new DerivedAttributes(hero);

        CreateSpriteRenderer(hero.icon);
        CreateAnimator(hero.animator);
        CreateGraphicsController();
        CreateCombatController();
        CreateRigidbody2D();
        CreateCapsuleCollider2D();
        CreateMovementController(derivedAttributes.movementSpeed);

        GameManager.HeroManager.Register(this);

        SpawnAllies();
    }

    private void SpawnAllies()
    {
        var rosterManager = GameManager.RosterManager;

        for (int i = 0; i < rosterManager.Assigned.Count && i < spawnPoints.Count; i++)
        {
            var allyName = rosterManager.Assigned[i];
            var ally = Instantiate(GameManager.GameSettings.AllyPrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
            ally.GetComponent<AllyController>().ally = rosterManager.GetEntityObject(allyName) as Ally;
            ally.name = allyName;
        }

        foreach (var spawnPoint in spawnPoints) Destroy(spawnPoint.gameObject);        
    }

    protected override void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<HeroCombatController>();
    }

    protected override void CreateMovementController(float maxSpeed)
    {
        movementControllerReference = gameObject.AddComponent<HeroMovementController>();
        movementControllerReference.maxSpeed = maxSpeed;
    }

    private void OnDestroy()
    {
        GameManager.HeroManager.Unregister(this);
    }

    public override AttackType attack
    {
        get
        {
            return hero.attackType;
        }
    }
}
