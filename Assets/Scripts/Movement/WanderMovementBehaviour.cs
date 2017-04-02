using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class WanderMovementBehaviour : AbstractMovementDecorator
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="movementBehaviour"></param>
    /// <param name="movementSpeed"></param>
    public WanderMovementBehaviour(AbstractMovementBehaviour movementBehaviour, float movementSpeed)
        : base(movementBehaviour, movementSpeed) { }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override Vector2 Steering()
    {
        throw new NotImplementedException();
    }
}
