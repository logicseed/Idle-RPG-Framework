using UnityEngine;
using System.Collections;

public class DirectAbilityController : MonoBehaviour
{
    [HideInInspector]
    public GameCharacterController target;
    [HideInInspector]
    public GameCharacterController caster;

    public RuntimeAnimatorController animator;
    public float speed;
    public int damage;
    public float criticalModifier;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        if (transform.position.SqrDistance(target.location) < GameManager.GameSettings.Constants.Range.DirectAbilityHit)
        {
            target.GetComponent<CombatController>().ApplyDamage(damage, criticalModifier > 1);
            Destroy(gameObject);
            return;
        }

        transform.up = target.location - transform.position;
        transform.Translate(transform.up * speed, Space.World);
    }
}
