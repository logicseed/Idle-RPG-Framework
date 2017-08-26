using UnityEngine;

/// <summary>
/// Controls an ability that travels directly towards its target.
/// </summary>
public class DirectAbilityController : MonoBehaviour
{
    [SerializeField]
    protected RuntimeAnimatorController animator;

    protected GameCharacterController caster;

    protected float criticalModifier;

    protected int damage;

    [SerializeField]
    protected float speed;

    protected GameCharacterController target;

    /// <summary>
    /// Updates the ability every frame.
    /// </summary>
    protected void Update()
    {
        if (Target == null)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position.SqrDistance(Target.Location) < GameManager.GameSettings.Constants.Range.DirectAbilityHit)
        {
            Target.CombatController.ApplyDamage(Damage, CriticalModifier > 1);
            Destroy(gameObject);
            return;
        }

        transform.up = Target.Location - transform.position;
        transform.Translate(transform.up * speed, Space.World);
    }

    /// <summary>
    /// The caster of the ability.
    /// </summary>
    public GameCharacterController Caster { get { return caster; } }

    /// <summary>
    /// The critical modifier of the ability.
    /// </summary>
    public float CriticalModifier { get { return criticalModifier; } set { criticalModifier = value; } }

    /// <summary>
    /// The damage the ability will apply upon contact.
    /// </summary>
    public int Damage { get { return damage; } set { damage = value; } }

    /// <summary>
    /// The target of the ability.
    /// </summary>
    public GameCharacterController Target { get { return target; } set { target = value; } }
}