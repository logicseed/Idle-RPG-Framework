using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the combat for the hero.
/// </summary>
public class HeroCombatController : CombatController
{
    protected Dictionary<string, float> abilityCooldowns;

    protected float defenseDuration;

    protected bool isDefending = false;

    /// <summary>
    /// Sets up the hero combat controller.
    /// </summary>
    protected override void Start()
    {
        characterControllerReference = GetComponent<HeroController>();
        currentHealth = CharacterController.Attributes.health;
        currentEnergy = CharacterController.Attributes.energy;
        lastAttackTime = Time.time - (1 / CharacterController.Attributes.attackSpeed);
        abilityCooldowns = new Dictionary<string, float>();
    }

    /// <summary>
    /// Updates the hero every frame.
    /// </summary>
    protected override void Update()
    {
        if (CharacterController.CharacterState == CharacterState.Dead) return;

        UpdateDefend();
        UpdateCooldowns();
        UpdateTarget();
        PerformCombatRound();
    }

    /// <summary>
    /// A collection of all abilities that are on cooldown, and the duration of their cooldown.
    /// The key is the name of the cooldown; value is the duration.
    /// </summary>
    public Dictionary<string, float> AbilityCooldowns { get { return abilityCooldowns; } }

    /// <summary>
    /// Applies damage to the hero.
    /// </summary>
    /// <param name="damage">The amount of damage to apply.</param>
    /// <param name="isCritical">Whether or not the damage includes critical damage.</param>
    public override void ApplyDamage(int damage, bool isCritical = false)
    {
        if (isDefending) damage = (int)(damage * GameManager.GameSettings.Constants.DefensePercent);
        base.ApplyDamage(damage, isCritical);
    }

    /// <summary>
    /// Performs a combat round.
    /// </summary>
    public override void PerformCombatRound()
    {
        if (!isDefending) base.PerformCombatRound();
    }

    /// <summary>
    /// Performs a defend ability.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    public void PerformDefendAbility(Ability ability)
    {
        isDefending = true;
        defenseDuration = ability.potency * GameManager.GameSettings.Constants.DefenseLength;
        Debug.Log(gameObject.name + ": Started defending.");
    }

    /// <summary>
    /// Spawns a fireball projectile.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    public void PerformFireball(Ability ability, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.abilityDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Fireball, transform.position, damage, target, criticalModifier);
    }

    /// <summary>
    /// Performs a melee area ability.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    public void PerformMeleeAreaAbility(Ability ability, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.attackDamage * criticalModifier);

        target.CombatController.ApplyDamage(damage, criticalModifier > 1);

        var enemies = GameManager.AllEnemies;
        foreach (var enemy in enemies)
        {
            if (enemy == target) continue;
            if (enemy.Location.SqrDistance(target.Location) < 1.2f)
            {
                enemy.CombatController.ApplyDamage(damage, criticalModifier > 1);
            }
        }
    }

    /// <summary>
    /// Performs a ranged area ability.
    /// </summary>
    /// <param name="ability">The ability to perform.</param>
    /// <param name="target">The target of the ability.</param>
    public void PerformRangedAreaAbility(Ability ability, GameCharacterController target)
    {
        SpawnStorm(target.Location + new Vector3(0.0f, 1.0f, 0.0f), target);

        var enemies = GameManager.AllEnemies;
        foreach (var enemy in enemies)
        {
            if (enemy == target) continue;
            if (enemy.Location.SqrDistance(target.Location) < 1.2f)
            {
                SpawnStorm(enemy.Location + new Vector3(0.0f, 1.0f, 0.0f), enemy);
            }
        }
    }

    /// <summary>
    /// Spawns a storm projectile.
    /// </summary>
    /// <param name="location">The location to spawn the storm projectile.</param>
    /// <param name="target">The target of the storm projectile.</param>
    public void SpawnStorm(Vector3 location, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.attackDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Storm, location, damage, target, criticalModifier);
    }

    /// <summary>
    /// Updates all ability cooldowns based on time passed.
    /// </summary>
    public void UpdateCooldowns()
    {
        var cooldownsToUpdate = new List<string>(AbilityCooldowns.Keys);

        foreach (var cooldown in cooldownsToUpdate)
        {
            AbilityCooldowns[cooldown] -= Time.deltaTime;
            if (AbilityCooldowns[cooldown] < 0)
            {
                AbilityCooldowns.Remove(cooldown);
                Debug.Log(gameObject.name + ": " + cooldown + " came off cooldown.");
            }
        }
    }

    /// <summary>
    /// Updates the state of the hero's defend ability.
    /// </summary>
    public void UpdateDefend()
    {
        if (isDefending)
        {
            defenseDuration -= Time.deltaTime;
            if (defenseDuration < 0)
            {
                isDefending = false;
                Debug.Log(gameObject.name + ": Stopped defending.");
            }
        }
    }
}