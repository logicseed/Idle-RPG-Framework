using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public abstract class BaseCharacterAttributeManager : MonoBehaviour
{

    public BaseCharacterAttributes baseAttributes;
    public BaseCharacterAttributes finalAttributes;
    public int currentHealth;
    public int currentEnergy;

    /// <summary>
    ///
    /// </summary>
    public abstract void CalculateAttributes();
}
