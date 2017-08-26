using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Represents a static collection of equipment loot.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Loot Collection - Static")]
public class StaticLootCollection : LootCollection
{
    protected int equipmentIterator = -1;

    [SerializeField]
    protected bool loopEquipment = false;

    /// <summary>
    /// Whether or not a piece of equipment dropped.
    /// </summary>
    public override bool DropEquipment
    {
        get
        {
            if (equipment.Count == 0) return false;

            if (loopEquipment == false && equipmentIterator >= equipment.Count) return false;

            return Random.Range(0.0f, 1.0f) <= GameManager.GameSettings.Constants.EquipmentDropChance;
        }
    }

    /// <summary>
    /// Gets the next piece of equipment to drop.
    /// </summary>
    /// <returns>An equipment object.</returns>
    public override Equipment GetNextEquipment()
    {
        equipmentIterator++;
        if (equipmentIterator >= equipment.Count) equipmentIterator = 0;
        if (equipmentIterator >= equipment.Count) return null;
        return equipment[equipmentIterator];
    }
}