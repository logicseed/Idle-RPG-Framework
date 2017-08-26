using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a collection of loot.
/// </summary>
public abstract class LootCollection : ScriptableObject
{
    [SerializeField]
    protected List<Equipment> equipment;

    /// <summary>
    /// Whether or not a piece of equipment dropped.
    /// </summary>
    /// <returns>True if equipment dropped; false otherwise.</returns>
    public abstract bool DropEquipment { get; }

    /// <summary>
    /// Gets the next piece of equipment from the loot collection.
    /// </summary>
    /// <returns>An equipment object.</returns>
    public abstract Equipment GetNextEquipment();
}