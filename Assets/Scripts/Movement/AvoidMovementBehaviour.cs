using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to avoid obstacles and
/// other characters.
/// </summary>
public class AvoidMovementBehaviour : AbstractMovementDecorator
{
    /// <summary>
    /// Constructor for AvoidMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="target">The target of this movement behaviour.</param>
    /// <param name="radius">The radius at which this behaviour is completed.</param>
    public AvoidMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, GameObject target, float radius) 
        : base(movementBehaviour, agent, target, radius) { }

    public override Vector2 CalculateDesiredVelocity()
    {
        var desiredVelocity = movementBehaviour.CalculateDesiredVelocity();

        var layerMask = LayerMask.GetMask("Hazard","Obstacle");

        var centerDirection = desiredVelocity.normalized;
        var leftDirection = (Vector2)(Quaternion.Euler(0, 0, 45) * centerDirection);
        var rightDirection = (Vector2)(Quaternion.Euler(0, 0, -45) * centerDirection);

        var avoidCenter = false;
        var avoidLeft = false;
        var avoidRight = false;

        RaycastHit2D hit = Physics2D.Raycast(agent.transform.position, centerDirection, radius, layerMask);
        if (hit.collider != null)
        {
            var hazard = hit.transform.gameObject.GetComponent<HazardController>();
            if ((hazard != null && hazard.IsPathable) || hazard == null)
            {
                avoidCenter = true;
                //desiredVelocity += -centerDirection * radius * hit.fraction;
            }
        }

        hit = Physics2D.Raycast(agent.transform.position, leftDirection, radius, layerMask);
        if (hit.collider != null)
        {
            var hazard = hit.transform.gameObject.GetComponent<HazardController>();
            if ((hazard != null && hazard.IsPathable) || hazard == null)
            {
                //desiredVelocity += -leftDirection * radius * hit.fraction;
                avoidLeft = true;
            }
        }

        hit = Physics2D.Raycast(agent.transform.position, rightDirection, radius, layerMask);
        if (hit.collider != null)
        {
            var hazard = hit.transform.gameObject.GetComponent<HazardController>();
            if ((hazard != null && hazard.IsPathable) || hazard == null)
            {
                //desiredVelocity += -rightDirection * radius * hit.fraction;
                avoidRight = true;
            }
        }

        Debug.DrawRay(agent.transform.position, centerDirection * radius, avoidCenter ? Color.red : Color.blue);
        Debug.DrawRay(agent.transform.position, leftDirection * radius, avoidLeft ? Color.red : Color.blue);
        Debug.DrawRay(agent.transform.position, rightDirection * radius, avoidRight ? Color.red : Color.blue);

        var angle = 0.0f;
        // Center only
        if ((avoidCenter && !avoidLeft && !avoidRight) ||
            (avoidCenter && avoidLeft && avoidRight))
        {
            angle = 70;
            if (avoidCenter && avoidLeft && avoidRight) angle = 90;

            if (centerDirection.x < 0) angle *= -1;
            if (agent.transform.position.y >= 0) angle *= -1;
        }
        // Center and left
        else if (avoidCenter && avoidLeft && !avoidRight) angle = -50;
        // Center and right
        else if (avoidCenter && !avoidLeft && avoidRight) angle = 50;
        // Left only
        else if (!avoidCenter && avoidLeft && !avoidRight) angle = -30;
        // Right only
        else if (!avoidCenter && !avoidLeft && avoidRight) angle = 30;
        // All
        else if (avoidCenter && avoidLeft && avoidRight) angle = 180;

        desiredVelocity = (Vector2)(Quaternion.Euler(0, 0, angle) * desiredVelocity);

        return desiredVelocity;
    }
}
