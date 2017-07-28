using UnityEngine;
using System.Collections;
using System;
using Debug = ConditionalDebug;

public class EnemyController : GameCharacterController
{
    public override CharacterType type { get { return CharacterType.Enemy; } }

    public Enemy enemy;

    // Use this for initialization
    void Start()
    {
        derivedAttributes = new DerivedAttributes(enemy);

        CreateCombatController();
        CreateSpriteRenderer(enemy.icon);
        CreateAnimator(enemy.animator);
        CreateGraphicsController();
        CreateMovementController(derivedAttributes.movementSpeed);
        CreateRigidbody2D();
        CreateCapsuleCollider2D();

        
        if (type != CharacterType.Hero)
        {
            floatingHealthBarReference = Instantiate(GameManager.GameSettings.Prefab.UI.FloatingBar, transform);
            Debug.Log(floatingHealthBarReference);
        }

        GameManager.Instance.enemyManager.Register(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        GameManager.Instance.enemyManager.Unregister(this);
    }

    public override AttackType attack
    {
        get
        {
            return enemy.attackType;
        }
    }
}
