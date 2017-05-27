using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class AllyAttributeManager : BaseCharacterAttributeManager
{
    public override CharacterType characterType { get { return CharacterType.Ally; } }

    /// <summary>
    ///
    /// </summary>
    public override void CalculateAttributes()
    {
        throw new NotImplementedException();
    }
}
