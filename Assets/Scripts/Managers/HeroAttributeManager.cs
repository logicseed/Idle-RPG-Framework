using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class HeroAttributeManager : BaseCharacterAttributeManager
{
    public override CharacterType characterType { get { return CharacterType.Hero; } }

    /// <summary>
    ///
    /// </summary>
    public override void CalculateAttributes()
    {
        throw new NotImplementedException();
    }

}
