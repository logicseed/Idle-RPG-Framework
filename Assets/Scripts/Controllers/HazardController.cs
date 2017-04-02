using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class HazardController : PlaceableController
{
    public HazardType type;
    public float potency;
    public bool isOneTime;
    public bool isPathable;

    [HideInInspector]
    public bool hasTriggered;

    /// <summary>
    ///
    /// </summary>
    public void ApplyEffect()
    {

    }

    /// <summary>
    ///
    /// </summary>
    public void OnTriggerEnter2D()
    {

    }
}
