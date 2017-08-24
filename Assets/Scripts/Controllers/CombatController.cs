using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;
using Random = UnityEngine.Random;

/// <summary>
/// Controls the combat for a character.
/// </summary>
public class CombatController : MonoBehaviour
{
    protected GameCharacterController characterControllerReference;

    protected int currentEnergy;

    protected int currentHealth;

    protected bool isStunned = false;

    protected float lastAttackTime;

    protected float stunDuration;

    protected GameCharacterController targetControllerReference;

    protected bool hasAppliedReward = false;

    protected float partialHealth;

    protected float partialEnergy;

    /// <summary>
    /// Sets up the combat controller.
    /// </summary>
    protected virtual void Start()
    {
        characterControllerReference = GetComponent<GameCharacterController>();
        if (characterControllerReference == null)
        {
            Debug.LogError(gameObject.name + ": Combat controller could not find a reference to the character controller.");
            return;
        }

        currentHealth = CharacterController.Attributes.Health;
        currentEnergy = CharacterController.Attributes.Energy;
        lastAttackTime = Time.time - (1 / CharacterController.Attributes.AttackSpeed);
    }

    /// <summary>
    /// Updates the combat controller every frame.
    /// </summary>
    protected virtual void Update()
    {
        if (IsStunned) UpdateStun();

        if (CharacterController.CharacterState == CharacterState.Dead) return;
        if (CharacterController.isCombatDummy) return;

        UpdateTarget();
        UpdateRegeneration();
        PerformCombatRound();
    }

    /// <summary>
    /// Updates the health and energy based on regeneration rates.
    /// </summary>
    protected virtual void UpdateRegeneration()
    {
        partialHealth += CharacterController.Attributes.HealthRegeneration * Time.deltaTime;
        partialEnergy += CharacterController.Attributes.EnergyRegeneration * Time.deltaTime;

        var newHealth = Mathf.FloorToInt(partialHealth);
        var newEnergy = Mathf.FloorToInt(partialEnergy);

        if (newHealth > 0) partialHealth -= newHealth;
        if (newEnergy > 0) partialEnergy -= newEnergy;

        currentHealth = Mathf.Min(CharacterController.Attributes.Health, currentHealth + newHealth);
        currentEnergy = Mathf.Min(CharacterController.Attributes.Energy, currentEnergy + newEnergy);
    }

    /// <summary>
    /// Removes stun from character after duration.
    /// </summary>
    protected void UpdateStun()
    {
        if (isStunned) stunDuration -= Time.time;
        if (stunDuration <= 0.0f) isStunned = false;
    }

    /// <summary>
    /// Returns whether or not the character can attack.
    /// </summary>
    public bool CanAttack
    {
        get
        {
            return TargetController != null // Need a target
                && CharacterController.CharacterState != CharacterState.Dead // Can't be dead
                && CharacterController.CharacterState != CharacterState.Walk // Can't be walking
                && CharacterController.CharacterState != CharacterState.Defend // Can't be defending
                && TargetController.CharacterState != CharacterState.Dead // Target must be alive
                && HasHostileTarget // Target must be hostile
                && HasTargetInRange // Target must be in range
                && IsTimeToAttack; // Enough time since last attack
        }
    }

    /// <summary>
    /// The character this combat controller belongs to.
    /// </summary>
    public GameCharacterController CharacterController { get { return characterControllerReference; } set { characterControllerReference = value; } }

    /// <summary>
    /// Returns the character's current energy.
    /// </summary>
    public int CurrentEnergy { get { return currentEnergy; } }

    /// <summary>
    /// Returns the character's current health.
    /// </summary>
    public int CurrentHealth { get { return currentHealth; } }

    /// <summary>
    /// Returns the desired combat range based on attack type.
    /// </summary>
    public float DesiredCombatRange
    {
        get
        {
            if (CharacterController.AttackType == AttackType.Ranged) return GameManager.GameSettings.Constants.Range.RangedAttack;
            else if (CharacterController.AttackType == AttackType.Caster) return GameManager.GameSettings.Constants.Range.CasterAttack;
            else return GameManager.GameSettings.Constants.Range.MeleeAttack;
        }
    }

    /// <summary>
    /// Returns whether or not the target is hostile.
    /// </summary>
    public bool HasHostileTarget
    {
        get
        {
            if (CharacterController.CharacterType == CharacterType.Ally || CharacterController.CharacterType == CharacterType.Hero)
                return TargetController.CharacterType == CharacterType.Enemy || TargetController.CharacterType == CharacterType.Boss;

            if (CharacterController.CharacterType == CharacterType.Enemy || CharacterController.CharacterType == CharacterType.Boss)
                return TargetController.CharacterType == CharacterType.Ally || TargetController.CharacterType == CharacterType.Hero;

            return false;
        }
    }

    /// <summary>
    /// Whether or not the target is within the desired combat range.
    /// </summary>
    public bool HasTargetInRange
    {
        get
        {
            var squaredDistance = CharacterController.Location.SqrDistance(TargetController.Location);

            var combatRangeSquared = DesiredCombatRange * DesiredCombatRange;

            // Add a little variance
            combatRangeSquared = combatRangeSquared + GameManager.GameSettings.Constants.Range.AttackRangeVariance;

            return squaredDistance <= combatRangeSquared;
        }
    }

    /// <summary>
    /// Returns whether or not the character is stunned.
    /// </summary>
    public bool IsStunned { get { return isStunned; } }

    /// <summary>
    /// Whether or not the character's attack speed allows them to attack.
    /// </summary>
    public bool IsTimeToAttack
    {
        get
        {
            // Since attack speed is in (attacks/sec) finding the reciprical
            // will give us (secs/attack)
            var attackTime = 1 / CharacterController.Attributes.AttackSpeed;

            return Time.time - lastAttackTime >= attackTime;
        }
    }

    public GameCharacterController TargetController { get { return targetControllerReference; } set { targetControllerReference = value; } }

    /// <summary>
    /// Applies damage to the character.
    /// </summary>
    /// <param name="damage">Amount of damage to apply.</param>
    /// <param name="isCritical">Whether or not damage has critical damage included.</param>
    public virtual void ApplyDamage(int damage, bool isCritical = false)
    {
        // How much damage made it through defense; negative values won't heal.
        var unblockedDamage = damage - CharacterController.Attributes.Defense;

        // Create floating combat text.
        var textObject = Instantiate(GameManager.GameSettings.Prefab.UI.CombatText, transform);
        var textController = textObject.GetComponent<CombatTextController>();

        // No unblocked damage
        if (unblockedDamage <= 0)
        {
            textController.Text = GameManager.GameSettings.Constants.CombatText.BlockedText;
            textController.Color = GameManager.GameSettings.Constants.Colors.CombatTextBlocked;
            return;
        }

        // Some damage made it through
        if (isCritical)
        {
            textController.Text = GameManager.GameSettings.Constants.CombatText.CriticalText + " " + unblockedDamage;
            textController.Color = GameManager.GameSettings.Constants.Colors.CombatTextCritical;
        }
        else
        {
            textController.Text = GameManager.GameSettings.Constants.CombatText.NormalText + " " + unblockedDamage;
            textController.Color = GameManager.GameSettings.Constants.Colors.CombatTextNormal;
        }

        // Combat dummies don't take damage
        if (CharacterController.isCombatDummy) return;

        currentHealth = Mathf.Max(currentHealth - unblockedDamage, 0);

        // Handle character death
        if (CurrentHealth < 1)
        {
            CharacterController.CharacterState = CharacterState.Dead;

            // Get experience and rewards if an enemy
            if (!CharacterController.IsFriendly && !hasAppliedReward)
            {
                hasAppliedReward = true;
                ApplyExperience();
                ApplyReward();
            }

            if (CharacterController.CharacterType != CharacterType.Hero)
            {
                CharacterController.Unregister();

                // Despawn body after some amount of time
                Invoke("Despawn", GameManager.GameSettings.Constants.CombatTime.DespawnBodyDelay);
            }
        }
    }

    /// <summary>
    /// Apply experience to the hero for this character's death.
    /// </summary>
    public void ApplyExperience()
    {
        GameManager.HeroManager.Experience += (int)(CharacterController.Level * GameManager.GameSettings.Constants.ExperiencePerLevel);
    }

    /// <summary>
    /// Apply rewards to the hero for this character's death.
    /// </summary>
    public void ApplyReward()
    {
        // Rewards are stage dependent
        GameManager.StageManager.GetReward(CharacterController.Location);
    }

    /// <summary>
    /// Applies a stun to the character.
    /// </summary>
    /// <param name="duration">Duration of stun in seconds.</param>
    public void ApplyStun(float duration)
    {
        isStunned = true;
        if (duration > stunDuration) stunDuration = duration; // Shorter stun won't overwrite longer stun
    }

    /// <summary>
    /// Determines the critical modifier of an attack. The default value is 1.0 or 100% normal
    /// damage, which is equivalent to no critical hit.
    /// </summary>
    /// <returns></returns>
    public float CriticalModifier()
    {
        if (Random.Range(0.0f, 1.0f) <= CharacterController.Attributes.CriticalHitChance)
        {
            return CharacterController.Attributes.CriticalHitDamage;
        }
        return 1.0f;
    }

    /// <summary>
    /// Despawns the character. Used to invoke after a delay.
    /// </summary>
    public void Despawn()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Changes character animation to face the direction of the target.
    /// </summary>
    public void FaceTarget()
    {
        if (TargetController.Location.x > CharacterController.Location.x)
        {
            CharacterController.LastDirection = MoveDirection.Right;
        }
        else if (TargetController.Location.x < CharacterController.Location.x)
        {
            CharacterController.LastDirection = MoveDirection.Left;
        }
    }

    /// <summary>
    /// Returns the closest hostile from a list of characters.
    /// </summary>
    /// <param name="hostiles">List of hostile characters.</param>
    public void GetClosestHostile(List<GameCharacterController> hostiles)
    {
        GameCharacterController closestHostile = null;
        var closestSquaredDistance = Mathf.Infinity;

        foreach (var hostile in hostiles)
        {
            var directionToHostile = hostile.Location - CharacterController.Location;
            var squaredDistance = directionToHostile.sqrMagnitude;

            if (squaredDistance < closestSquaredDistance)
            {
                closestSquaredDistance = squaredDistance;
                closestHostile = hostile;
            }
        }

        TargetController = closestHostile;
    }

    /// <summary>
    /// Performs a caster attack on the current target.
    /// </summary>
    public virtual void PerformCasterAttack()
    {
        // Update state
        CharacterController.CharacterState = CharacterState.Idle; // Make sure event is fired.
        CharacterController.CharacterState = CharacterState.Cast;

        Invoke("SpawnCasterball", GameManager.GameSettings.Constants.CombatTime.SpawnCasterBallDelay);
    }

    /// <summary>
    /// Performs a combat round.
    /// </summary>
    public virtual void PerformCombatRound()
    {
        // Make sure we can attack
        if (!CanAttack) return;

        FaceTarget();

        // Character passes all attack checks, and it can attack
        if (CharacterController.AttackType == AttackType.Caster) PerformCasterAttack();
        else if (CharacterController.AttackType == AttackType.Ranged) PerformRangedAttack();
        else PerformMeleeAttack();

        lastAttackTime = Time.time;
    }

    /// <summary>
    /// Performs a melee attack on the current target.
    /// </summary>
    public virtual void PerformMeleeAttack()
    {
        // Update state
        CharacterController.CharacterState = CharacterState.Idle; // Make sure event is fired.
        CharacterController.CharacterState = CharacterState.Melee;

        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.AttackDamage * criticalModifier);

        PerformLifeDrain(damage);

        // Apply damage
        TargetController.CombatController.ApplyDamage(damage, criticalModifier > 1);
    }

    /// <summary>
    /// Performs life steal based on the character attribute and the damage done.
    /// </summary>
    /// <param name="damage">Damage to life steal from.</param>
    public virtual void PerformLifeDrain(int damage)
    {
        var lifeDrain = damage * CharacterController.Attributes.LifeDrain;
        currentHealth = Mathf.Min(CharacterController.Attributes.Health, currentHealth + (int)lifeDrain);
    }

    /// <summary>
    /// Performs a ranged attack on the current target.
    /// </summary>
    public virtual void PerformRangedAttack()
    {
        // Update state
        CharacterController.CharacterState = CharacterState.Idle; // Make sure event is fired.
        CharacterController.CharacterState = CharacterState.Ranged;

        Invoke("SpawnArrow", GameManager.GameSettings.Constants.CombatTime.SpawnArrowDelay);
    }

    /// <summary>
    /// Spawns an arrow projectile that targets the current target.
    /// </summary>
    public void SpawnArrow()
    {
        var prefab = GameManager.GameSettings.Prefab.Effect.Arrow;
        var location = CharacterController.Location;
        var target = TargetController;
        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.AttackDamage * criticalModifier);

        PerformLifeDrain(damage);

        SpawnProjectile(prefab, location, damage, target, criticalModifier);
    }

    /// <summary>
    /// Spawns a caster ball projectile that targets the currrent target.
    /// </summary>
    public void SpawnCasterball()
    {
        var prefab = GameManager.GameSettings.Prefab.Effect.Casterball;
        var location = CharacterController.Location;
        var target = TargetController;
        var criticalModifier = CriticalModifier();
        var damage = (int)(CharacterController.Attributes.AbilityDamage * criticalModifier);

        PerformLifeDrain(damage);

        SpawnProjectile(prefab, location, damage, target, criticalModifier);
    }

    /// <summary>
    /// Spawns a projectile that travels to and strikes the target.
    /// </summary>
    /// <param name="prefab">The projectile to spawn.</param>
    /// <param name="location">The location to spawn the projectile.</param>
    /// <param name="damage">The damage the projectile will do upon contact.</param>
    /// <param name="target">The target of the projectile.</param>
    /// <param name="criticalModifier">The critical modifier of the projectile's damage.</param>
    public void SpawnProjectile(GameObject prefab, Vector3 location, int damage, GameCharacterController target, float criticalModifier)
    {
        var projectile = Instantiate(prefab, location, Quaternion.identity) as GameObject;

        var projectileController = projectile.GetComponent<DirectAbilityController>();
        projectileController.Target = target;
        projectileController.Damage = damage;
        projectileController.CriticalModifier = criticalModifier;
    }

    /// <summary>
    /// Finds an appropriate target for the character if one exists on the stage.
    /// </summary>
    public virtual void UpdateTarget()
    {
        if (CharacterController.GraphicsController.IsAttackAnimationPlaying()) return;

        if (TargetController == null || TargetController.CharacterState == CharacterState.Dead)
        {
            switch (CharacterController.CharacterType)
            {
                case CharacterType.Ally:
                case CharacterType.Hero:
                    GetClosestHostile(GameManager.AllEnemies);
                    break;

                case CharacterType.Boss:
                case CharacterType.Enemy:
                    GetClosestHostile(GameManager.AllFriendlies);
                    break;

                default:
                    break;
            }
        }
            if (TargetController == null && CharacterController.CharacterState != CharacterState.Walk)
            {
                if (!CharacterController.GraphicsController.IsAttackAnimationPlaying()) CharacterController.CharacterState = CharacterState.Idle;
            }
    }
}