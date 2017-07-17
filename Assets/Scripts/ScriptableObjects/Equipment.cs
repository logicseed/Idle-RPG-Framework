using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Reward/Equipment")]
public class Equipment : ScriptableObject
{
    public EquipmentType type;
    public EquipmentSlot slot;
    public Sprite sprite;
    public BaseAttributes attributeModifiers;
}
