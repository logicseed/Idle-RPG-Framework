using UnityEngine;

public class HeroMovementController : MovementController
{
    protected bool hasLocationTarget;
    protected Vector2 locationTarget;

    /// <summary>
    /// Generates movement behaviour to seek a location, or to seek a target if not seeking
    /// a location, or does nothing if the hero has neither a location target not a character
    /// target.
    /// </summary>
    protected override void GenerateSeekBehaviour()
    {
        // Location targets have a higher move priority than character targets.
        if (hasLocationTarget)
        {
            // Check if hero has reached location.
            if (transform.position.SqrDistance(locationTarget) < GameManager.GameSettings.Constants.Range.SeekLocationSqr)
            {
                hasLocationTarget = false;
            }
            else // Otherwise attempt to walk to location.
            {
                movementBehaviour = new WalkMovementBehaviour(
                    movementBehaviour, gameObject, locationTarget, GameManager.GameSettings.Constants.Range.SeekLocation);
            }
        }

        // Check for character target
        base.GenerateSeekBehaviour();
    }

    /// <summary>
    /// Sets up the hero movement controller.
    /// </summary>
    protected override void Start()
    {
        locationTarget = transform.position;
        character = GameManager.Hero;
    }

    public bool HasLocationTarget { get { return hasLocationTarget; } set { hasLocationTarget = value; } }

    /// <summary>
    /// Gets or sets the location target of the hero.
    /// </summary>
    public Vector2 Location
    {
        get
        {
            if (!hasLocationTarget) return Vector2.zero;
            return locationTarget;
        }

        set
        {
            hasLocationTarget = true;
            locationTarget = value;
        }
    }
}