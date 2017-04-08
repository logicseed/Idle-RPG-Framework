using System;
using UnityEngine;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to move
/// to a location.
/// </summary>
public class WalkMovementBehaviour : DirectMovementBehaviour
{
    /// <summary>
    /// Location this behaviour will desire to walk toward.
    /// </summary>
    private Vector2 location;

    /// <summary>
    /// Constructor for WalkMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="location">The target of this movement behaviour.</param>
    public WalkMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, 
                                 Vector2 location, float radius)
         : base(movementBehaviour, agent, null, radius) { this.location = location; }

    /// <summary>
    /// The velocity desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal velocity vector to accomplish this movement behaviour.</returns>
    public override Vector2 CalculateDesiredVelocity()
    {
        var desiredVelocity = CalculateMaximumVelocity(agent.transform.position, location);

        var distance = Vector2.Distance(agent.transform.position, location);
        var radiusFactor = Mathf.Clamp(distance / radius, 0.0f, 1.0f);
        desiredVelocity *= radiusFactor;

        Debug.DrawRay(agent.transform.position, (Vector2)agent.transform.position + desiredVelocity, Color.yellow);
        return desiredVelocity + movementBehaviour.CalculateDesiredVelocity();
    }
}
