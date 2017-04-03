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
    public WanderMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent)
         : base(movementBehaviour, agent, null) { }

    /// <summary>
    /// The steering vector desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal sterring vector to accomplish this movement behaviour.</returns>
    public override Vector2 Steering()
    {
        return movementBehaviour.Steering();
    }
}
