using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Loot Collection - Static")]
public class StaticLootCollection : LootCollection
{
    [HideInInspector]
    public int currencyAmount;
    public List<Equipment> equipment;
    public bool loopEquipment = false;
    private int equipmentIterator = -1;

    public override bool DropEquipment()
    {
        Debug.Log("Checking drop equipment.");
        if (equipment.Count == 0) return false;
        if (loopEquipment == false && equipmentIterator >= equipment.Count) return false;
        Debug.Log("Checking drop chance.");
        return Random.Range(0.0f, 1.0f) >= 0.5f;
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override int GetCurrency()
    {
        return currencyAmount;
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override Equipment GetEquipment()
    {
        if (DropEquipment())
        {
            Debug.Log("Getting equipment.");
            equipmentIterator++;
            if (loopEquipment && equipmentIterator >= equipment.Count) equipmentIterator = 0;
            if (equipmentIterator >= equipment.Count) return null;
            return equipment[equipmentIterator];
        }
        else return null;
    }
}
