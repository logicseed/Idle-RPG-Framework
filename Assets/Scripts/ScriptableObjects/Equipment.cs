using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Equipment")]
public class Equipment : ListableEntity
{
    public EquipmentType equipmentType;
    public EquipmentSlot equipmentSlot;
    public BaseAttributes attributeModifiers;
}
