using System;
using UnityEngine;

/// <summary>
/// Controls the movement of the character.
/// </summary>
public class MovementController : MonoBehaviour
{
    protected GameCharacterController character;
    protected Vector2 currentVelocity;
    protected float maxSpeed;
    protected AbstractMovementBehaviour movementBehaviour;

    /// <summary>
    /// Updates the character's movement every physics tick.
    /// </summary>
    protected virtual void FixedUpdate()
    {
        if (character.CharacterState == CharacterState.Dead) return;

        GenerateMovementBehaviours();
        Move();
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
            if (character.CombatController.TargetController != null)
            {
                var squareDistance = transform.position.SqrDistance(character.CombatController.TargetController.transform.position);

                if (squareDistance > SeekTargetDistanceSquared)
                {
                    var location = character.CombatController.TargetController.transform.position;
                    movementBehaviour = new WalkMovementBehaviour(
                        movementBehaviour, gameObject, location, SeekTargetDistance);
                }
            }
            else if (character.CombatController.TargetController == null)
            {
                // Have allies walk back to hero when they don't have a target.
                if (character.CharacterType == CharacterType.Ally) //TODO: Make this more generic.
                {
                    var squareDistance = transform.position.SqrDistance(GameManager.Hero.Location);

                    if (squareDistance > SeekTargetDistanceSquared)
                    {
                        var location = GameManager.Hero.Location;
                        movementBehaviour = new WalkMovementBehaviour(
                            movementBehaviour, gameObject, location, SeekTargetDistance);
                    }
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
        var desiredVelocity = movementBehaviour.Steering().normalized * MaxSpeed * GameManager.GameSettings.Constants.Character.VelocityFactor;

        // Update state and direction
        if (desiredVelocity != Vector2.zero)
        {
            try
            {
                // Maintain proper character state
                character.CharacterState = CharacterState.Walk;
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
                        character.LastDirection = MoveDirection.Left;
                    }
                    else
                    {
                        character.LastDirection = MoveDirection.Right;
                    }
                }
            }
            catch (NullReferenceException)
            {
                character = GetComponent<GameCharacterController>();
            }
        }

        if (desiredVelocity == Vector2.zero && character.CharacterState == CharacterState.Walk)
        {
            character.CharacterState = CharacterState.Idle;
        }

        // Finally move to new position
        character.Rigidbody.velocity = desiredVelocity;
        transform.rotation = Quaternion.identity;
    }

    /// <summary>
    /// Sets up the character's movement.
    /// </summary>
    protected virtual void Start()
    {
        character = GetComponent<GameCharacterController>();
    }

    /// <summary>
    /// The current velocity of the character.
    /// </summary>
    public Vector2 CurrentVelocity { get { return character.Rigidbody.velocity; } }

    /// <summary>
    /// Gets or sets the maximum speed of the character.
    /// </summary>
    public float MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }

    /// <summary>
    /// How close the character wants to get to their target.
    /// </summary>
    public float SeekTargetDistance
    {
        get
        {
            return character.CombatController.DesiredCombatRange;
        }
    }

    /// <summary>
    /// The seek target distance squared for more efficient vector calculations.
    /// </summary>
    public float SeekTargetDistanceSquared
    {
        get
        {
            return character.CombatController.DesiredCombatRange * character.CombatController.DesiredCombatRange;
        }
    }

    /// <summary>
    /// Applies an external force to the character.
    /// </summary>
    /// <param name="potency">The potency of the force to apply.</param>
    /// <param name="position">The position to apply force from.</param>
    public void ApplyForce(float potency, Vector3 position)
    {
        throw new NotImplementedException(); // TODO: Finish this
    }

    /// <summary>
    /// Decorates the base idle movement behaviour with other movement behaviours
    /// appropriate to the character and situation.
    /// </summary>
    public void GenerateMovementBehaviours()
    {
        movementBehaviour = new IdleMovementBehaviour();
        GenerateFleeBehaviours();
        GenerateSeekBehaviour();
        movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, null, 1.0f);
    }
}