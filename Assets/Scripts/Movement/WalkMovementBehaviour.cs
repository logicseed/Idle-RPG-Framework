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
    public WalkMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, Vector2 location)
         : base(movementBehaviour, agent, null) { this.location = location; }

    /// <summary>
    /// The steering vector desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal steering vector to accomplish this movement behaviour.</returns>
    public override Vector2 Steering()
    {
        return movementBehaviour.Steering();
    }
}
