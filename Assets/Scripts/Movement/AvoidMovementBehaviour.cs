using UnityEngine;
using System.Collections;
using System;

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
        return Vector2.zero;
        //var steering = Vector3.zero;
        //var layerMask = LayerMask.GetMask("Hazard");

        //var maxDistance = 2.0f;
        //var sphereRadius = 0.5f;

        //// avoid obstacles in front
        //RaycastHit hit;

        //var rayDistance = (maxDistance * controller.maxSpeed) * controller.velocity;
        //    (agent.mover.velocity.magnitude / agent.mover.maxSpeed);

        //if (Physics.SphereCast(agent.transform.position, behaviour.sphereRadius, agent.mover.velocity, out hit, rayDistance, layerMask))
        //{
        //    var hitAgent = hit.collider.gameObject.GetComponent<AgentManager>();
        //    var direction = hit.point - hitAgent.position;

        //    steering = (direction.normalized * agent.mover.maxSpeed);

        //    if (debugRays)
        //    {
        //        // target
        //        Debug.DrawRay(agent.position, hit.transform.position - agent.position, MaterialColor.Grey);

        //        // look ahead
        //        Debug.DrawRay(agent.position, agent.mover.velocity.normalized * rayDistance, MaterialColor.Standard.AvoidRayDistance);

        //        // steering
        //        Debug.DrawRay(agent.position + agent.mover.velocity, steering, MaterialColor.Standard.AvoidSteering);
        //    }

        //}

        //// avoid obstacles around
        //var hitColliders = Physics.OverlapSphere(agent.position, behaviour.personalSpace, layerMask);

        //foreach (SphereCollider hitCollider in hitColliders)
        //{
        //    if (hitCollider.gameObject.transform.position == agent.position) continue;

        //    //var hitAgent = hitCollider.gameObject.GetComponent<AgentManager>();
        //    //Debug.Log("Agent Position: " + agent.position);
        //    //Debug.Log("Collider Position: " + hitCollider.transform.position);
        //    var direction = hitCollider.transform.position - agent.position;
        //    var distance = Mathf.Abs(direction.magnitude) - (hitCollider.radius + behaviour.personalSpace);
        //    //Debug.Log("Distance: " + distance);
        //    direction.Normalize();

        //    var importance = behaviour.personalSpace / distance;
        //    //Debug.Log("Importance: " + importance);

        //    steering += (direction * agent.mover.maxAccel) * importance;
        //}





        //if (debugRays)
        //{
        //    Debug.DrawRay(agent.position, agent.mover.velocity.normalized * rayDistance,
        //                  MaterialColor.Standard.AvoidRayDistance);
        //}

        //steering *= behaviour.priority;
        //return steering + parentBehaviour.Steering(debugRays);
    }
}
