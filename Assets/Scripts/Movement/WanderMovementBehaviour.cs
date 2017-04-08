using System;
using UnityEngine;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to wander
/// around the stage.
/// </summary>
public class WanderMovementBehaviour : AbstractMovementDecorator
{
    /// <summary>
    /// Constructor for WanderMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="location">The original location from which the agent will wander.</param>
    /// <param name="radius">The radius at which this behaviour will wander.</param>
    public WanderMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, Vector2 location, float radius)
         : base(movementBehaviour, agent, null, radius) { }

    /// <summary>
    /// The velocity desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal velocity vector to accomplish this movement behaviour.</returns>
    public override Vector2 CalculateDesiredVelocity()
    {
        // Determine location to move to
        //var desiredVelocity = CalculateMaximumVelocity(agent.transform.position, location);
        //Debug.DrawRay(agent.transform.position, (Vector2)agent.transform.position + desiredVelocity, Color.blue);
        //return desiredVelocity + movementBehaviour.CalculateDesiredVelocity();
        return movementBehaviour.CalculateDesiredVelocity();
    }
}
