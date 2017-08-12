using UnityEngine;
using System.Collections;
using System;

public class AllyController : GameCharacterController
{
    public override CharacterType type { get { return CharacterType.Ally; } }

    public Ally ally;

    // Use this for initialization
    void Start()
    {
        derivedAttributes = new DerivedAttributes(ally);

        CreateCombatController();
        CreateSpriteRenderer(ally.icon);
        CreateAnimator(ally.animator);
        CreateGraphicsController();
        CreateMovementController(derivedAttributes.movementSpeed);
        CreateRigidbody2D();
        CreateCapsuleCollider2D();


        if (type != CharacterType.Hero)
        {
            floatingHealthBarReference = Instantiate(GameManager.GameSettings.Prefab.UI.FloatingBar, transform);
        }

        GameManager.Instance.allyManager.Register(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        try
        {
            GameManager.Instance.allyManager.Unregister(this);
        }
        catch (NullReferenceException)
        {
            // GameManager destroyed first, must be test environment, ignore exception.
        }
    }

    public override AttackType attack
    {
        get
        {
            return ally.attackType;
        }
    }

    public override void Unregister()
    {
        GameManager.AllyManager.Unregister(this);
    }
}
