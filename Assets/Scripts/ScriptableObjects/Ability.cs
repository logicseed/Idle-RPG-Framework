using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
[CreateAssetMenu(menuName = "Idle RPG/Ability")]
public class Ability : ScriptableObject
{
    public bool isRanged;
    public float cooldown;
    public float potency;
    public Texture2D texture;

    /// <summary>
    ///
    /// </summary>
    /// <param name="target"></param>
    public void ApplyEffect(GameObject target)
    {

    }
}
