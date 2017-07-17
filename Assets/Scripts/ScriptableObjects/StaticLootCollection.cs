using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Reward/Loot Collection - Static")]
public class StaticLootCollection : LootCollection
{
    public int currencyAmount;
    public List<Equipment> equipment;

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override int GetCurrency()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override List<Equipment> GetEquipment()
    {
        throw new NotImplementedException();
    }
}
