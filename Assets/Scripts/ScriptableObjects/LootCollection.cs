using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public abstract class LootCollection : ScriptableObject
{
    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public abstract int GetCurrency();

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public abstract List<Equipment> GetEquipment();
}
