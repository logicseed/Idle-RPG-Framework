using UnityEngine;

/// <summary>
/// Controls interactions with hazards.
/// </summary>
public class HazardController : MonoBehaviour
{
    protected bool hasTriggered;

    [SerializeField]
    protected HazardType type;

    [SerializeField]
    protected float potency;

    [SerializeField]
    protected bool isOneTime;

    [SerializeField]
    protected bool isPathable;

    /// <summary>
    /// Triggers the hazard's effect.
    /// </summary>
    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered || !isOneTime)
        {
            var character = other.gameObject.GetComponent<GameCharacterController>();
            if (character == null) return;

            if (isOneTime) hasTriggered = true;
            ApplyEffect(character);
        }
    }

    /// <summary>
    /// Applies the hazard's effect to a character.
    /// </summary>
    public void ApplyEffect(GameCharacterController character)
    {
        switch (type)
        {
            case HazardType.Damage:
                character.CombatController.ApplyDamage((int)potency);
                break;

            case HazardType.Force:
                character.MovementController.ApplyForce(potency, transform.position);
                break;

            case HazardType.Stun:
                character.CombatController.ApplyStun(potency);
                break;

            default:
                break;
        }
    }
}