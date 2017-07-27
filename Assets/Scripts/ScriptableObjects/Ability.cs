using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Ability")]
public class Ability : ListableEntity
{
    //public SpriteAttribute icontest;
    
    public Sprite effect;
    public AbilityRange abilityRange;
    public AbilityType abilityType;
    public float cooldown;
    [Range(0,10)]
    public float potency;

    /// <summary>
    ///
    /// </summary>
    /// <param name="target"></param>
    public void ApplyEffect(GameObject target)
    {

    }
}
