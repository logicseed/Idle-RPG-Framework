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
    public DirectMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, GameObject target)
         : base(movementBehaviour, agent, target) { }


}
