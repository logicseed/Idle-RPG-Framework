using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Represents a random collection of loot.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Loot Collection - Random")]
public class RandomLootCollection : LootCollection
{
    /// <summary>
    /// Whether or not equipment dropped.
    /// </summary>
    public override bool DropEquipment
    {
        get
        {
            return Random.Range(0.0f, 1.0f) <= GameManager.GameSettings.Constants.EquipmentDropChance;
        }
    }

    /// <summary>
    /// Get the next piece of equipment that drops.
    /// </summary>
    /// <returns>Equipment object that dropped.</returns>
    public override Equipment GetNextEquipment()
    {
        return equipment[Random.Range(0, equipment.Count)];
    }
}