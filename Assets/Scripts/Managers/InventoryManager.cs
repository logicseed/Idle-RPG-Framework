using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
///
/// </summary>
[System.Serializable]
public class InventoryManager : WorldEntityManager
{
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Equipment.Unlocked; } }
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Equipment.Assigned; } }
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Equipment; } }

    public InventoryManager(SaveGame save = null) : base(save) { }

    public override void Load(SaveGame save)
    {
        if (save != null)
        {
            foreach (var equipment in save.unlockedEquipment) AddUnlocked(equipment);
            foreach (var equipment in save.assignedEquipment) AddAssigned(equipment);
        }

        foreach (var equipment in GameManager.GameSettings.CharacterStart.Inventory)
        {
            if (!unlocked.Contains(equipment)) AddUnlocked(equipment);
        }
        
    }

    public override void Save(ref SaveGame save)
    {
        save.unlockedEquipment = Unlocked;
        save.assignedEquipment = Assigned;
    }

    public override void AddAssigned(string name, bool raiseChangeEvent = true)
    {
        var equipmentObject = GetEntityObject(name) as Equipment;
        var slot = equipmentObject.equipmentSlot;

        var listToRemove = new List<string>();

        foreach (var equipment in Assigned)
        {
            var checkEquipment = GetEntityObject(equipment) as Equipment;
            var checkSlot = checkEquipment.equipmentSlot;

            if (slot == EquipmentSlot.TwoHand)
            {
                if (checkSlot == EquipmentSlot.LeftHand || 
                    checkSlot == EquipmentSlot.RightHand)
                {
                    listToRemove.Add(equipment);
                }
            }
            else
            {
                if (checkSlot == slot ||
                    (checkSlot == EquipmentSlot.TwoHand &&
                     (slot == EquipmentSlot.LeftHand ||
                      slot == EquipmentSlot.RightHand)))
                {
                    listToRemove.Add(equipment);
                }
            }
        }

        foreach (var equipment in listToRemove) RemoveAssigned(equipment, false);

        if (!Assigned.Contains(name) && Assigned.Count < MaxAssigned)
        {
            Debug.Log("Added to assigned: " + name);
            Assigned.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
        }
    }


    public BaseAttributes attributeModifiers
    {
        get
        {
            var attributeModifiers = new BaseAttributes();
            foreach (var equipment in Assigned)
            {
                var equipmentObject = GetEntityObject(equipment) as Equipment;
                attributeModifiers += equipmentObject.attributeModifiers;
            }
            return attributeModifiers;
        }
    }
}
