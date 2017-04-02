using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public abstract class BaseCharacterAttributeManager : MonoBehaviour
{
    public CharacterAttributes baseAttributes;
    public CharacterAttributes finalAttributes;
    public int currentHealth;
    public int currentEnergy;

    /// <summary>
    ///
    /// </summary>
    public abstract void CalculateAttributes();
}
