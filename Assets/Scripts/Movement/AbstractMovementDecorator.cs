using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public abstract class AbstractMovementDecorator : AbstractMovementBehaviour
{
    protected AbstractMovementBehaviour movementBehaviour;
    protected float movementSpeed;

    /// <summary>
    ///
    /// </summary>
    /// <param name="movementBehaviour"></param>
    /// <param name="movementSpeed"></param>
    public AbstractMovementDecorator(AbstractMovementBehaviour movementBehaviour, float movementSpeed)
    {
        this.movementBehaviour = movementBehaviour;
        this.movementSpeed = movementSpeed;
    }
}
