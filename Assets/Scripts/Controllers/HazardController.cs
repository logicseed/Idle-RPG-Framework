using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardController : PlaceableBehaviour {

    public HazardType type;
    public float potency;
    public bool isOneTime;
    public bool isPathable;

    [HideInInspector]
    public bool hasTriggered;

    public void ApplyEffect()
    {

    }

    public void OnTriggerEnter2D()
    {

    }
}
