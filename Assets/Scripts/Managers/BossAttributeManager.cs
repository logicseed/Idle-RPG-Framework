using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class BossAttributeManager : EnemyAttributeManager
{
    public override CharacterType characterType { get { return CharacterType.Boss; } }
}
