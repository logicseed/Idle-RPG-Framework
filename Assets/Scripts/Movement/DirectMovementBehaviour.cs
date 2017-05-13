using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to move
/// in the most direct manner possible.
/// </summary>
public abstract class DirectMovementBehaviour : AbstractMovementDecorator
{
    /// <summary>
    /// Constructor for DirectMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="target">The target of this movement behaviour.</param>
    /// <param name="radius">The radius at which this behaviour is completed.</param>
    public DirectMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, GameObject target, float radius)
         : base(movementBehaviour, agent, target, radius) { }

    /// <summary>
    /// Calculates the maximum velocity of this direct movement behaviour.
    /// </summary>
    /// <param name="fromPosition">The start position.</param>
    /// <param name="toPosition">The end position.</param>
    /// <returns>Maximum velocity to go from start position to end position.</returns>
    public Vector2 CalculateMaximumVelocity(Vector2 fromPosition, Vector2 toPosition)
    {
        var maximumVelocity = (toPosition - fromPosition).normalized * maxSpeed;

        return maximumVelocity;
    }
}
