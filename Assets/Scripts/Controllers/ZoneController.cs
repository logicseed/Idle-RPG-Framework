using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class ZoneController : SelectableController
{
    public List<ZoneController> goesTo;
    public List<ZoneController> comesFrom;
    public Texture2D zoneMap;

    /// <summary>
    ///
    /// </summary>
    public override void RefreshSprite()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///
    /// </summary>
    public override void UnlockNext()
    {
        throw new NotImplementedException();
    }
}
