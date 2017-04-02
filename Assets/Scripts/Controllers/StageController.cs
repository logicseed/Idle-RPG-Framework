using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///
/// </summary>
public class StageController : SelectableController
{
    public List<StageController> goesTo;
    public List<StageController> comesFrom;
    public Scene stageScene;
    public Vector2 locationInZone;

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
