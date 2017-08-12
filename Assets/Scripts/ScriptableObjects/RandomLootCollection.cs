using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Loot Collection - Random")]
public class RandomLootCollection : LootCollection
{
    public int lowCurrencyAmount;
    public int highCurrencyAmount;
    public List<Equipment> equipment;

    public override bool DropEquipment()
    {
        if (highCurrencyAmount == 0 && equipment.Count > 0) return true;
        if (highCurrencyAmount > 0 && equipment.Count <= 0) return false;

        return Random.Range(0.0f, 1.0f) >= 0.5f;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetCurrency()
    {
        return Random.Range(lowCurrencyAmount, highCurrencyAmount + 1);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override Equipment GetEquipment()
    {
        if (DropEquipment())
        {
            return equipment[Random.Range(0, equipment.Count)];
        }
        return null;
    }
}
