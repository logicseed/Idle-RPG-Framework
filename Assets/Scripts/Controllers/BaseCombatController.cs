using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
///
/// </summary>
public abstract class BaseCombatController : MonoBehaviour
{
    public GameObject characterTarget;
    public BaseCharacterAttributeManager attributeManager;

    /// <summary>
    /// Character state change delegate signature.
    /// </summary>
    /// <param name="newState">The new state of the character.</param>
    public delegate void CharacterStateChanged(CharacterState newState);

    /// <summary>
    /// Event handler for a character's state changing.
    /// </summary>
    /// <remarks>
    /// Subscribe in <c>Start()</c>, unsubscribe in <c>OnDestroy()</c>, and implement event method with signature
    /// Subscribe: <c>combatController.OnStateChanged += CharacterStateChanged;</c>
    /// Unsubscribe: <c>combatController.OnStateChanged -= CharacterStateChanged;</c>
    /// Signature: <c>public void CharacterStateChanged(CharacterState newState) { }</c>
    /// </remarks>
    public static event CharacterStateChanged OnStateChanged;

    /// <summary>
    /// The current state of the character.
    /// </summary>
    private CharacterState characterState;

    /// <summary>
    /// Get or set the current state of the character.
    /// </summary>
    /// <remarks>Raises the state change event if the state changed.</remarks>
    public CharacterState CharacterState
    {
        get { return characterState; }
        set
        {
            if (characterState != value)
            {
                characterState = value;
                if (OnStateChanged != null) OnStateChanged(characterState);
            }
        }
    }

    private void Start()
    {
        attributeManager = GetComponent<BaseCharacterAttributeManager>();
    }

    private void Update()
    {
        UpdateCharacterTarget();
    }

    /// <summary>
    /// Finds an appropriate target for the character if one exists on the stage.
    /// </summary>
    public virtual void UpdateCharacterTarget()
    {
        if (characterTarget == null)
        {
            try
            {
                switch (attributeManager.characterType)
                {
                    case CharacterType.Ally:
                        GetClosestHostile(GameManager.Instance.AllEnemies);
                        break;

                    case CharacterType.Boss:
                    case CharacterType.Enemy:
                        GetClosestHostile(GameManager.Instance.AllFriendlies);
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                attributeManager = GetComponent<BaseCharacterAttributeManager>();
            }
        }
    }

    /// <summary>
    /// Finds the closest hostile on the stage.
    /// </summary>
    /// <param name="hostiles">A list of hostile GameObjects.</param>
    private void GetClosestHostile(List<GameObject> hostiles)
    {
        GameObject closestHostile = null;

        foreach (var hostile in hostiles)
        {
            // First hostile is closest
            if (closestHostile == null)
            {
                closestHostile = hostile;
                continue;
            }

            var currentDistance = Vector2.Distance(transform.position, closestHostile.transform.position);
            var newDistance = Vector2.Distance(transform.position, hostile.transform.position);

            if (newDistance < currentDistance) closestHostile = hostile;
        }

        if (closestHostile != null) characterTarget = closestHostile;
    }

    /// <summary>
    ///
    /// </summary>
    public abstract void PerformCombatRound();

    //public abstract void GetAttributeManager();
}
