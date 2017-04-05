using UnityEngine;

/// <summary>
/// Movement behaviours that can be wrapped around other movement behaviours
/// to add additional movement desires.
/// </summary>
public abstract class AbstractMovementDecorator : AbstractMovementBehaviour
{
    /// <summary>
    /// Movement behaviour that will be decorated by this movement behaviour.
    /// </summary>
    protected AbstractMovementBehaviour movementBehaviour;

    /// <summary>
    /// Maximum number of Unity units moved per second.
    /// </summary>
    protected float maxSpeed;

    /// <summary>
    /// Maximum change in speed per second.
    /// </summary>
    protected float maxAccel;

    /// <summary>
    /// GameObject that desires this movement behaviour.
    /// </summary>
    protected GameObject agent;

    /// <summary>
    /// Agent's movement controller.
    /// </summary>
    protected MovementController controller;

    /// <summary>
    /// Target of this movement behaviour.
    /// </summary>
    protected GameObject target;

    /// <summary>
    /// Base constructor for movement decorators.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="target">The target of this movement behaviour.</param>
    public AbstractMovementDecorator(AbstractMovementBehaviour movementBehaviour,
                                     GameObject agent, GameObject target)
    {
        this.agent = agent;
        this.controller = agent.GetComponent<MovementController>();
        this.maxSpeed = controller.maxSpeed;
        this.maxAccel = controller.maxAccel;
        this.target = target;
    }
}
