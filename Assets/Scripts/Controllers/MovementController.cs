using System;
using UnityEngine;

/// <summary>
///
/// </summary>
public class MovementController : MonoBehaviour
{
    public const float AVOID_DISTANCE = 0.5f;
    public const float SEEK_TARGET_DISTANCE = 0.5f;
    public const float SEEK_TARGET_DISTANCE_SQR = SEEK_TARGET_DISTANCE * SEEK_TARGET_DISTANCE;

    // These will be derived from attributes
    public float maxSpeed;
    public float maxAccel;



    protected CharacterManager character;
    protected AbstractMovementBehaviour movementBehaviour;

    protected Vector2 currentVelocity;
    public Vector2 velocity { get { return currentVelocity; } }

    protected virtual void Start()
    {
        character = GetComponent<CharacterManager>();
    }

    internal void ApplyForce(float potency, Vector3 position)
    {
        throw new NotImplementedException();
    }

    protected virtual void FixedUpdate()
    {
        GenerateMovementBehaviours();
        Move();
    }

    /// <summary>
    /// Decorates the base idle movement behaviour with other movement behaviours
    /// appropriate to the character and situation.
    /// </summary>
    public void GenerateMovementBehaviours()
    {
        movementBehaviour = new IdleMovementBehaviour();
        GenerateAvoidBehaviours();
        GenerateSeekBehaviour();
    }

    /// <summary>
    /// Generates movement behaviours to avoid all other characters. Avoid in this sense
    /// means they will not move on top of them.
    /// </summary>
    protected void GenerateAvoidBehaviours()
    {
        var charactersToAvoid = GameManager.Instance.AllCharactersExcept(gameObject);

        foreach (var character in charactersToAvoid)
        {
            movementBehaviour = new AvoidMovementBehaviour(
                movementBehaviour, gameObject, character, AVOID_DISTANCE);
        }
    }

    /// <summary>
    /// Generates movement behaviour to seek the current target.
    /// </summary>
    protected virtual void GenerateSeekBehaviour()
    {
        try
        {
            if (character.combat.target != null)
            {
                var squareDistance = transform.position.SqrDistance(character.combat.target.transform.position);

                if (squareDistance > SEEK_TARGET_DISTANCE_SQR)
                {
                    var location = character.combat.target.transform.position;
                    movementBehaviour = new WalkMovementBehaviour(
                        movementBehaviour, gameObject, location, SEEK_TARGET_DISTANCE);
                    character.state = CharacterState.Walk;
                }
                else
                {
                    if (character.state == CharacterState.Walk) character.state = CharacterState.Idle;
                }
            }
        }
        catch (NullReferenceException)
        {
            character = GetComponent<CharacterManager>();
        }
    }

    /// <summary>
    /// Moves a character according to their current movement behaviours.
    /// </summary>
    protected void Move()
    {
        // Get desired position
        var newPosition = movementBehaviour.Steering().normalized * maxSpeed;

        // Update state and direction
        if (newPosition != Vector2.zero)
        {
            try
            {
                // Maintain proper character state
                character.state = CharacterState.Walk;
            }
            catch (NullReferenceException)
            {
                character = GetComponent<CharacterManager>();
            }

            try
            {
                // Maintain proper character direction
                if (newPosition.x != 0)
                {
                    if (newPosition.x < 0)
                    {
                        character.direction = MoveDirection.Left;
                    }
                    else
                    {
                        character.direction = MoveDirection.Right;
                    }
                }
            }
            catch (NullReferenceException)
            {
                character = GetComponent<CharacterManager>();
            }
        }

        // Finally move to new position
        transform.Translate(newPosition);
    }


}
