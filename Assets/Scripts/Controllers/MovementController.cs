using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class MovementController : MonoBehaviour
{
    public float maxSpeed;
    public float maxAccel;
    [HideInInspector] public AbstractMovementBehaviour movementBehaviour;
    [HideInInspector] public Vector2 currentVelocity;

    /// <summary>
    ///
    /// </summary>
    public void GenerateMovementBehaviour()
    {

    }

    /// <summary>
    ///
    /// </summary>
    public void Move()
    {

    }
}
