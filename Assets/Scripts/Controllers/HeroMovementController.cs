using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class HeroMovementController : MovementController
{
    public const float SEEK_LOCATION_DISTANCE = 0.2f;
    public const float SEEK_LOCATION_DISTANCE_SQR = SEEK_LOCATION_DISTANCE * SEEK_LOCATION_DISTANCE;

    public bool seekLocation;
    public Vector2 locationTarget;

    /// <summary>
    /// Gets or sets the location target of the hero.
    /// </summary>
    public Vector2 location
    {
        get
        {
            if (!seekLocation) return Vector2.zero;
            return locationTarget;
        }

        set
        {
            seekLocation = true;
            locationTarget = value;
        }
    }

    protected override void Start()
    {
        locationTarget = transform.position;
        character = GetComponent<CharacterManager>();
    }

    /// <summary>
    /// Generates movement behaviour to seek a location, or to seek a target if not seeking
    /// a location, or does nothing if the hero has neither a location target not a character
    /// target.
    /// </summary>
    protected override void GenerateSeekBehaviour()
    {
        // Location targets have a higher move priority than character targets.
        if (seekLocation)
        {
            // Check if hero has reached location.
            if (transform.position.SqrDistance(locationTarget) < SEEK_TARGET_DISTANCE_SQR)
            {
                seekLocation = false;
                character.state = CharacterState.Idle;
                // Fall through to check for character target.
            }
            else // Otherwise attempt to walk to location.
            {
                movementBehaviour = new WalkMovementBehaviour(
                    movementBehaviour, gameObject, locationTarget, SEEK_LOCATION_DISTANCE);
                character.state = CharacterState.Walk;
            }
        }

        // Check for character target
        base.GenerateSeekBehaviour();
    }
}

