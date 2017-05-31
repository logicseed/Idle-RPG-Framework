using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides easy access to references to the various components of a character.
/// </summary>
public class CharacterManager : MonoBehaviour
{
    protected CombatController combatControllerReference;
    protected MovementController movementControllerReference;

    public BaseAttributes baseAttributes;
    public BaseAttributes bonusAttributes;
    protected DerivedAttributes derivedAttributes;

    public DerivedAttributes attributes { get { return derivedAttributes; } }

    public CharacterType type = CharacterType.None;
    public int level = 1;

    public delegate void CharacterDirectionChanged();
    public event CharacterDirectionChanged OnDirectionChanged;

    private MoveDirection lastDirection = MoveDirection.Right;
    public MoveDirection direction
    {
        get { return lastDirection; }
        set
        {
            if (lastDirection != value)
            {
                lastDirection = value;
                if (OnDirectionChanged != null) OnDirectionChanged();
            }
        }
    }

    /// <summary>
    /// Character state change delegate signature.
    /// </summary>
    public delegate void CharacterStateChanged();

    /// <summary>
    /// Event handler for a character's state changing.
    /// </summary>
    /// <remarks>
    /// Subscribe in <c>Start()</c>, unsubscribe in <c>OnDestroy()</c>, and implement event method with signature
    /// Subscribe: <c>combatController.OnStateChanged += CharacterStateChanged;</c>
    /// Unsubscribe: <c>combatController.OnStateChanged -= CharacterStateChanged;</c>
    /// Signature: <c>public void CharacterStateChanged() { }</c>
    /// </remarks>
    public event CharacterStateChanged OnStateChanged;

    /// <summary>
    /// The current state of the character.
    /// </summary>
    public CharacterState characterState = CharacterState.Idle; //TODO: protected after debug

    /// <summary>
    /// Get or set the current state of the character.
    /// </summary>
    /// <remarks>Raises the state change event if the state changed.</remarks>
    public CharacterState state
    {
        get { return characterState; }
        set
        {
            if (characterState != value)
            {
                characterState = value;
                if (OnStateChanged != null) OnStateChanged();
            }
        }
    }

    /// <summary>
    /// Returns a reference to the character's combat controller.
    /// </summary>
    public CombatController combat
    {
        get
        {
            if (combatControllerReference == null)
                combatControllerReference = GetComponent<CombatController>();

            return combatControllerReference;
        }
    }

    /// <summary>
    /// Returns a reference to the character's movement controller.
    /// </summary>
    public MovementController movement
    {
        get
        {
            if (movementControllerReference == null) GetMovementController();

            return movementControllerReference;
        }
    }


    protected virtual void Start()
    {
        combatControllerReference = GetComponent<CombatController>();
        GetMovementController();
        CalculateBonusAttributes();
        derivedAttributes = new DerivedAttributes(this);
    }

    protected virtual void CalculateBonusAttributes()
    {
        bonusAttributes = new BaseAttributes();
    }

    protected virtual void GetMovementController()
    {
        movementControllerReference = GetComponent<MovementController>();
    }
}
