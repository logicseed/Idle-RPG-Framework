using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class EnemyAttributeManager : BaseCharacterAttributeManager
{
    public override CharacterType characterType { get { return CharacterType.Enemy; } }

    /// <summary>
    ///
    /// </summary>
    public override void CalculateAttributes()
    {
        throw new NotImplementedException();
    }
}
