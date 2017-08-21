using UnityEngine;

/// <summary>
/// Represents a piece of equipment.
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Equipment")]
public class Equipment : ListableEntity
{
    [SerializeField]
    protected EquipmentType equipmentType;

    [SerializeField]
    protected EquipmentSlot equipmentSlot;

    [SerializeField]
    [Tooltip("This only applies to weapons.")]
    protected AttackType attackType;

    [SerializeField]
    protected BaseAttributes attributeModifiers;

    /// <summary>
    /// Attack type of this equipment if it is a weapon.
    /// </summary>
    public AttackType AttackType { get { return attackType; } }

    /// <summary>
    /// Modifications to attributes when equipment is assigned.
    /// </summary>
    public BaseAttributes AttributeModifiers { get { return attributeModifiers; } }

    /// <summary>
    /// Slot equipment is assigned to.
    /// </summary>
    public EquipmentSlot EquipmentSlot { get { return equipmentSlot; } }

    /// <summary>
    /// Type of equipment.
    /// </summary>
    public EquipmentType EquipmentType { get { return equipmentType; } }

    /// <summary>
    /// Type of lists this equipment belongs to.
    /// </summary>
    public override ListableEntityType ListableType { get { return ListableEntityType.Inventory; } }
}