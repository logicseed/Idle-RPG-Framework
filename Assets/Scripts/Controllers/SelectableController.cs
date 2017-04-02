using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public abstract class SelectableController : MonoBehaviour
{
    public bool isLocked;

    /// <summary>
    ///
    /// </summary>
    public abstract void UnlockNext();

    /// <summary>
    ///
    /// </summary>
    public abstract void RefreshSprite();
}
