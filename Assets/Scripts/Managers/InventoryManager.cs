using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[System.Serializable]
public class InventoryManager
{
    public const string EQUIPMENT_PATH = "Equipment/";

    public List<string> unlockedEquipment;
    public List<string> assignedEquipment;

    public Dictionary<string, Equipment> equipmentObjects;

    public InventoryManager()
    {
        unlockedEquipment = new List<string>();
        assignedEquipment = new List<string>();
        equipmentObjects = new Dictionary<string, Equipment>();
    }

    public void AddToInventory(string equipment)
    {
        if (!unlockedEquipment.Contains(equipment))
        {
            unlockedEquipment.Add(equipment);
            var equipmentObject = Resources.Load(EQUIPMENT_PATH + equipment) as Equipment;
            equipmentObjects.Add(equipment, equipmentObject);
        }
    }

    public void RemoveFromInventory(string equipment)
    {
        if (unlockedEquipment.Contains(equipment))
        {
            unlockedEquipment.Remove(equipment);
            equipmentObjects.Remove(equipment);
            if (assignedEquipment.Contains(equipment)) assignedEquipment.Remove(equipment);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="equipment"></param>
    public void Equip(string equipment)
    {
        var equipmentObject = equipmentObjects[equipment];
        var slot = equipmentObject.slot;

        foreach (var assigned in assignedEquipment)
        {
            if (equipmentObjects[equipment].slot == slot) assignedEquipment.Remove(assigned);
        }
    }

    public void Unequip(string equipment)
    {
        if (assignedEquipment.Contains(equipment)) assignedEquipment.Remove(equipment);
    }

    public BaseAttributes attributeModifiers
    {
        get
        {
            var attributeModifiers = new BaseAttributes();
            foreach (var equipment in assignedEquipment)
            {
                attributeModifiers += equipmentObjects[equipment].attributeModifiers;
            }
            return attributeModifiers;
        }
    }

    public Equipment GetEquipment(string equipment)
    {
        if (unlockedEquipment.Contains(equipment))
        {
            if (equipmentObjects.ContainsKey(equipment))
            {
                return equipmentObjects[equipment];
            }
            else
            {
                var equipmentObject = Resources.Load(EQUIPMENT_PATH + equipment) as Equipment;
                equipmentObjects.Add(equipment, equipmentObject);
                return equipmentObject;
            }
        }
        return Resources.Load(EQUIPMENT_PATH + equipment) as Equipment;
    }

    public List<Equipment> GetEquipped()
    {
        var equippedEquipment = new List<Equipment>();

        foreach (var equipment in assignedEquipment)
        {
            equippedEquipment.Add(equipmentObjects[equipment]);
        }

        return equippedEquipment;
    }

    internal void Save(ref SaveGame save)
    {
        save.unlockedEquipment = unlockedEquipment;
        save.assignedEquipment = assignedEquipment;
    }

    public static InventoryManager Load(SaveGame save)
    {
        var inventoryManager = new InventoryManager();

        if (save != null)
        {
            foreach (var equipment in save.unlockedEquipment)
            {
                inventoryManager.AddToInventory(equipment);
            }

            foreach (var equipment in save.assignedEquipment)
            {
                inventoryManager.Equip(equipment);
            }
        }

        return inventoryManager;
    }
}
