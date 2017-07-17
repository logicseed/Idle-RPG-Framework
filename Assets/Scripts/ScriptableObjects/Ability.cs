using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Ability")]
public class Ability : ScriptableObject
{
    //public SpriteAttribute icontest;
    public Sprite icon;
    public Sprite effect;
    public AbilityRange range;
    public AbilityType type;
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
