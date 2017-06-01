using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : CharacterManager
{
    public int experience = 0;
    protected InventoryManager inventoryManagerReference;
    protected RosterManager rosterManagerReference;
    protected AbilityManager abilityManagerReference;

    protected override void Start()
    {
        inventoryManagerReference = GetComponent<InventoryManager>();
        base.Start();
    }

    protected override void CalculateBonusAttributes()
    {
        bonusAttributes = inventoryManagerReference.attributeModifiers;
    }

    protected override void GetMovementController()
    {
        movementControllerReference = GetComponent<HeroMovementController>();
    }

    protected override void CreateCombatController()
    {
        combatControllerReference = gameObject.AddComponent<HeroCombatController>();
    }

    protected override void CreateMovementController()
    {
        movementControllerReference = gameObject.AddComponent<HeroMovementController>();
    }
}
