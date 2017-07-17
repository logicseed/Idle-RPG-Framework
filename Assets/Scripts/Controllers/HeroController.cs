using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : GameCharacterController
{
    public override CharacterType type { get { return CharacterType.Hero; } }

    public Hero hero;

    private Transform spawn1;
    private Transform spawn2;
    private Transform spawn3;

    public void Awake()
    {
        hero = Resources.Load("Heroes/Hero") as Hero;
}

    protected void Start()
    {
        derivedAttributes = new DerivedAttributes(hero);

        CreateSpriteRenderer(hero.avatar);
        CreateAnimator(hero.animator);
        CreateGraphicsController();
        CreateCombatController();
        CreateRigidbody2D();
        CreateCapsuleCollider2D();
        CreateMovementController(derivedAttributes.movementSpeed);

        GameManager.Instance.heroManager.Register(this);

        spawn1 = transform.Find("Spawn1");
        spawn2 = transform.Find("Spawn2");
        spawn3 = transform.Find("Spawn3");
        SpawnAllies();
    }

    private void SpawnAllies()
    {
        var rosterManager = GameManager.Instance.rosterManager;

        if (rosterManager.assignedAllies.Count > 0)
        {
            var allyName = rosterManager.assignedAllies[0];
            var ally = Instantiate(Resources.Load("Ally"), spawn1.position, Quaternion.identity) as GameObject;
            ally.GetComponent<AllyController>().ally = rosterManager.GetAlly(allyName);
            ally.name = allyName;
        }

        if (rosterManager.assignedAllies.Count > 1)
        {
            var allyName = rosterManager.assignedAllies[1];
            var ally = Instantiate(Resources.Load("Ally"), spawn2.position, Quaternion.identity) as GameObject;
            ally.GetComponent<AllyController>().ally = rosterManager.GetAlly(allyName);
            ally.name = allyName;
        }

        if (rosterManager.assignedAllies.Count > 2)
        {
            var allyName = rosterManager.assignedAllies[2];
            var ally = Instantiate(Resources.Load("Ally"), spawn3.position, Quaternion.identity) as GameObject;
            ally.GetComponent<AllyController>().ally = rosterManager.GetAlly(allyName);
            ally.name = allyName;
        }

        Destroy(spawn1.gameObject);
        Destroy(spawn2.gameObject);
        Destroy(spawn3.gameObject);
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
        GameManager.Instance.heroManager.Unregister(this);
    }

    public override AttackType attack
    {
        get
        {
            return hero.attack;
        }
    }
}
