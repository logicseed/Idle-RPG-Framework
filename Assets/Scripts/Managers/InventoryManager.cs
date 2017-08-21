using System.Collections.Generic;

/// <summary>
/// Manages equipment in the inventory; keeping track of unlock equipment, assigned equipment, etc.
/// </summary>
[System.Serializable]
public class InventoryManager : WorldEntityManager
{
    /// <summary>
    /// Constructs the inventory manager from a saved game.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public InventoryManager(SaveGame save = null) : base(save) { }

    /// <summary>
    /// Returns the attribute modifiers of all assigned equipment.
    /// </summary>
    public BaseAttributes AttributeModifiers // TODO: apply equipment
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

    /// <summary>
    /// Returns the maximum amount of assigned equipment.
    /// </summary>
    public override int MaxAssigned { get { return GameManager.GameSettings.Max.Equipment.Assigned; } }

    /// <summary>
    /// Returns the maximum amount of unlocked equipment.
    /// </summary>
    public override int MaxUnlocked { get { return GameManager.GameSettings.Max.Equipment.Unlocked; } }

    /// <summary>
    /// Returns the resource path of equipment.
    /// </summary>
    public override string ResourcePath { get { return GameManager.GameSettings.Path.Equipment; } }

    /// <summary>
    /// Adds a piece of equipment to the assigned list.
    /// </summary>
    /// <param name="name">The name of the equipment to assign.</param>
    /// <param name="raiseChangeEvent">Whether or not the raise an event about the change.</param>
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
            Assigned.Add(name);
            if (raiseChangeEvent) RaiseChangeEvent(WorldEntityListType.Assigned);
        }
    }

    /// <summary>
    /// Loads inventory information from save game data.
    /// </summary>
    /// <param name="save">The save game data.</param>
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

    /// <summary>
    /// Fills a save game with inventory data.
    /// </summary>
    /// <param name="save">The save game data.</param>
    public override void Save(ref SaveGame save)
    {
        save.unlockedEquipment = Unlocked;
        save.assignedEquipment = Assigned;
    }
}