using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : CharacterManager
{
    public int experience = 0;
    public InventoryManager inventory;

    protected override void Start()
    {
        inventory = GetComponent<InventoryManager>();
        base.Start();
    }

    protected override void CalculateBonusAttributes()
    {
        bonusAttributes = inventory.attributeModifiers;
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
