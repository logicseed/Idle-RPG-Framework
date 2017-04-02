using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Equipment")]
public class Equipment : ScriptableObject
{
    public EquipmentType type;
    public EquipmentSlot slot;
    public Texture2D texture;
    public CharacterAttributes attributeModifiers;
}
