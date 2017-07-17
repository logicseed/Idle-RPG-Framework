using UnityEngine;

/// <summary>
///
/// </summary>
public class HazardController : MonoBehaviour
{
    public HazardType type;
    public float potency;
    public bool isOneTime;
    public bool isPathable;

    [HideInInspector]
    public bool hasTriggered;

    /// <summary>
    ///
    /// </summary>
    public void ApplyEffect(GameCharacterController character)
    {
        switch (type)
        {
            case HazardType.Damage:
                character.combat.ApplyDamage((int)potency);
                break;
            case HazardType.Force:
                character.movement.ApplyForce(potency, transform.position);
                break;
            case HazardType.Stun:
                character.combat.ApplyStun(potency);
                break;
            default:
                break;
        }
    }

    /// <summary>
    ///
    /// </summary>
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasTriggered || !isOneTime)
        {
            var character = other.gameObject.GetComponent<GameCharacterController>();
            if (isOneTime) hasTriggered = true;
            ApplyEffect(character);
        }
    }
}
