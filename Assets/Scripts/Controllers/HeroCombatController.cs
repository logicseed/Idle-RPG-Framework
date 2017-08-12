using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class HeroCombatController : CombatController
{
    private Dictionary<string, float> abilityCooldowns;
    public Dictionary<string, float> Cooldowns { get { return abilityCooldowns; } }

    private bool isDefending = false;
    private float defenseLength;

    /// <summary>
    ///
    /// </summary>
    public override void PerformCombatRound()
    {
        base.PerformCombatRound();
    }

    /// <summary>
    /// 
    /// </summary>
    public override void UpdateTarget()
    {
        if (target != null &&
            target.GetComponent<GameCharacterController>().state == CharacterState.Dead)
        {
            target = null;
        }
    }

    protected override void Start()
    {
        character = GetComponent<HeroController>();
        currentHealth = character.attributes.health;
        currentEnergy = character.attributes.energy;
        lastAttackTime = Time.time - (1 / character.attributes.attackSpeed);
        abilityCooldowns = new Dictionary<string, float>();
        
        // TODO: Spawn ability bar
    }

    protected override void Update()
    {
        if (character.state == CharacterState.Dead) return;

        UpdateDefend();
        UpdateCooldowns();
        UpdateTarget();
        PerformCombatRound();
    }

    private void UpdateDefend()
    {
        if (isDefending)
        {
            defenseLength -= Time.deltaTime;
            if (defenseLength < 0)
            {
                isDefending = false;
                Debug.Log("Hero no longer defending.");
            }
        }
    }

    private void UpdateCooldowns()
    {
        var cooldownsToUpdate = new List<string> (Cooldowns.Keys);
        foreach (var cooldown in cooldownsToUpdate)
        {
            Cooldowns[cooldown] -= Time.deltaTime;
            if (Cooldowns[cooldown] < 0) Cooldowns.Remove(cooldown);
        }
    }

    public void PerformDefendAbility(Ability ability)
    {
        isDefending = true;
        defenseLength = ability.potency * GameManager.GameSettings.Constants.DefenseLength;
        Debug.Log("Hero is defending.");
    }

    public void PerformStormAbility(Ability ability, GameCharacterController target)
    {
        SpawnStorm(target.location + new Vector3(0.0f, 1.0f, 0.0f), target);

        var enemies = GameManager.AllEnemies;
        foreach (var enemy in enemies)
        {
            if (enemy == target) continue;
            if (enemy.location.SqrDistance(target.location) < 1.2f)
            {
                SpawnStorm(enemy.location + new Vector3(0.0f, 1.0f, 0.0f), enemy);
            }
        }
    }

    public void SpawnStorm(Vector3 location, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Storm, location, damage, target, criticalModifier);
    }

    public void PerformFireball(Ability ability, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.abilityDamage * criticalModifier);
        SpawnProjectile(GameManager.GameSettings.Prefab.Effect.Fireball, transform.position, damage, target, criticalModifier);
    }

    public void PerformCleaveAbility(Ability ability, GameCharacterController target)
    {
        var criticalModifier = CriticalModifier();
        var damage = (int)(character.attributes.attackDamage * criticalModifier);

        target.combat.ApplyDamage(damage, criticalModifier > 1);

        var enemies = GameManager.AllEnemies;
        foreach (var enemy in enemies)
        {
            if (enemy == target) continue;
            if (enemy.location.SqrDistance(target.location) < 1.2f)
            {
                enemy.combat.ApplyDamage(damage, criticalModifier > 1);
            }
        }
    }

    public override void ApplyDamage(int damage, bool isCritical = false)
    {
        if (isDefending) damage = (int)(damage * GameManager.GameSettings.Constants.DefensePercent);
        base.ApplyDamage(damage, isCritical);
    }
}
