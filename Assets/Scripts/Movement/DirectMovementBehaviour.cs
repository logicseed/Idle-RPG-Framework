using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to move
/// in the most direct manner possible.
/// </summary>
public abstract class DirectMovementBehaviour : AbstractMovementDecorator
{
    protected MovementController movementController;
    /// <summary>
    /// Constructor for DirectMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="target">The target of this movement behaviour.</param>
    public DirectMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, GameObject target)
         : base(movementBehaviour, agent, target) { }

    /// <summary>
    /// Calculates the desired steering of this direct movement behaviour.
    /// </summary>
    /// <param name="fromPosition">The start position.</param>
    /// <param name="toPosition">The end position.</param>
    /// <returns>Desired steering to go from start position to end position.</returns>
    protected Vector2 CalculateDesiredSteering(Vector2 fromPosition, Vector2 toPosition)
    {
        var desiredVelocity = (toPosition - fromPosition) * maxSpeed;
        var desiredAcceleration = (desiredVelocity - controller.currentVelocity).normalized * maxAccel;
        var desiredSteering = controller.currentVelocity - desiredAcceleration;

        return desiredSteering;
    }
}
