using System;
using UnityEngine;

/// <summary>
///
/// </summary>
public class MovementController : MonoBehaviour
{
    //public const float AVOID_DISTANCE = 0.5f;
    //public const float VELOCITY_FACTOR = 200;

    // These will be derived from attributes
    public float maxSpeed;
    //public float maxAccel = 0.1f;

    public float SeekTargetDistance
    {
        get
        {
            return character.combat.DesiredRange;
        }
    }

    public float SeekTargetDistanceSquared
    {
        get
        {
            return character.combat.DesiredRange * character.combat.DesiredRange;
        }
    }


    protected GameCharacterController character;
    protected AbstractMovementBehaviour movementBehaviour;

    protected Vector2 currentVelocity;
    public Vector2 velocity { get { return currentVelocity; } }

    protected virtual void Start()
    {
        character = GetComponent<GameCharacterController>();
    }

    internal void ApplyForce(float potency, Vector3 position)
    {
        throw new NotImplementedException();
    }

    protected virtual void FixedUpdate()
    {
        if (character.state == CharacterState.Dead) return;
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
        //GenerateFleeBehaviours();
        GenerateSeekBehaviour();
    }

    /// <summary>
    /// Generates movement behaviours to avoid all other characters. Avoid in this sense
    /// means they will not move on top of them.
    /// </summary>
    protected void GenerateFleeBehaviours()
    {
        var charactersToAvoid = GameManager.AllCharactersExcept(character);

        foreach (var character in charactersToAvoid)
        {
            movementBehaviour = new FleeMovementBehaviour(
                movementBehaviour, gameObject, character.gameObject, GameManager.GameSettings.Constants.Range.AvoidDistance);
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

                if (squareDistance > SeekTargetDistanceSquared)
                {
                    var location = character.combat.target.transform.position;
                    movementBehaviour = new WalkMovementBehaviour(
                        movementBehaviour, gameObject, location, SeekTargetDistance);
                    character.state = CharacterState.Walk;
                }
                else
                {
                    if (character.state == CharacterState.Walk) character.state = CharacterState.Idle;
                }
            }
            else if (character.combat.target == null)
            {
                // Have allies walk back to hero when they don't have a target.
                if (character.type == CharacterType.Ally) //TODO: Make this more generic.
                {
                    var squareDistance = transform.position.SqrDistance(GameManager.Instance.hero.transform.position);

                    if (squareDistance > SeekTargetDistanceSquared)
                    {
                        var location = GameManager.Instance.hero.transform.position;
                        movementBehaviour = new WalkMovementBehaviour(
                            movementBehaviour, gameObject, location, SeekTargetDistance);
                        character.state = CharacterState.Walk;
                    }
                }
                else
                {
                    //if (character.state == CharacterState.Walk) character.state = CharacterState.Idle;
                }
            }
        }
        catch (NullReferenceException)
        {
            character = GetComponent<GameCharacterController>();
        }
    }

    /// <summary>
    /// Moves a character according to their current movement behaviours.
    /// </summary>
    protected void Move()
    {
        // Get desired velocity
        var desiredVelocity = movementBehaviour.Steering().normalized * maxSpeed * GameManager.GameSettings.Constants.Character.VelocityFactor;

        // Update state and direction
        if (desiredVelocity != Vector2.zero)
        {
            try
            {
                // Maintain proper character state
                character.state = CharacterState.Walk;
            }
            catch (NullReferenceException)
            {
                character = GetComponent<GameCharacterController>();
            }

            try
            {
                // Maintain proper character direction
                if (desiredVelocity.x != 0)
                {
                    if (desiredVelocity.x < 0)
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
                character = GetComponent<GameCharacterController>();
            }
        }

        // Finally move to new position
        //character.rigidbodyReference.AddForce(desiredVelocity);
        character.rigidbodyReference.velocity = desiredVelocity;
        //transform.Translate(newPosition);
        transform.rotation = Quaternion.identity;
    }


}
