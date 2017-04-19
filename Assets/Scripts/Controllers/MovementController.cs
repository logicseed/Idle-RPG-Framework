using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class MovementController : MonoBehaviour
{
    public bool demoMode;
    public float maxSpeed;
    public float maxAccel;

    public Vector2 locationTarget;

    [HideInInspector] public AbstractMovementBehaviour movementBehaviour;
    [HideInInspector] public Vector2 currentVelocity;

    public void Start()
    {
        locationTarget = transform.position;
    }

    public void FixedUpdate()
    {
        if (!demoMode)
        {
            GenerateMovementBehaviour();
            Move();
        }
    }

    /// <summary>
    ///
    /// </summary>
    public void GenerateMovementBehaviour()
    {
        movementBehaviour = new IdleMovementBehaviour();
        if (locationTarget != null)
        {
            movementBehaviour = new WalkMovementBehaviour(movementBehaviour, gameObject, locationTarget, 1f);
        }

        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, enemy, 1f);
        }
    }

    /// <summary>
    ///
    /// </summary>
    public void Move()
    {
        var newPosition = movementBehaviour.Steering().normalized * maxSpeed;
        transform.Translate(newPosition);
    }

    public void SetLocationTarget(Vector2 location)
    {
        locationTarget = location;
    }
}
