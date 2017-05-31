using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class InventoryManager : MonoBehaviour
{
    public Dictionary<EquipmentSlot, Equipment> equipped;
    public List<Equipment> inventory;

    private void Awake()
    {
        equipped = new Dictionary<EquipmentSlot, Equipment>();
        inventory = new List<Equipment>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="equipment"></param>
    public void Drop(Equipment equipment)
    {
        if (equipped.ContainsKey(equipment.slot))
        {
            if (equipped[equipment.slot] == equipment)
            {
                equipped.Remove(equipment.slot);
            }
        }
        inventory.Remove(equipment);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="equipment"></param>
    public void Equip(Equipment equipment)
    {
        if (equipped.ContainsKey(equipment.slot))
        {
            equipped.Remove(equipment.slot);
            equipped.Add(equipment.slot, equipment);
        }
    }

    public BaseAttributes attributeModifiers
    {
        get
        {
            var attributeModifiers = new BaseAttributes();
            foreach (var equipment in equipped)
            {
                attributeModifiers += equipment.Value.attributeModifiers;
            }
            return attributeModifiers;
        }
    }
}
