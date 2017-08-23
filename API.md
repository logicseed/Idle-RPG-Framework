<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [Ability](#T-Ability 'Ability')
  - [AbilityRange](#P-Ability-AbilityRange 'Ability.AbilityRange')
  - [AbilityType](#P-Ability-AbilityType 'Ability.AbilityType')
  - [Cooldown](#P-Ability-Cooldown 'Ability.Cooldown')
  - [Effect](#P-Ability-Effect 'Ability.Effect')
  - [EnergyCost](#P-Ability-EnergyCost 'Ability.EnergyCost')
  - [ListableType](#P-Ability-ListableType 'Ability.ListableType')
  - [Potency](#P-Ability-Potency 'Ability.Potency')
- [AbilityManager](#T-AbilityManager 'AbilityManager')
  - [#ctor(save)](#M-AbilityManager-#ctor-SaveGame- 'AbilityManager.#ctor(SaveGame)')
  - [MaxAssigned](#P-AbilityManager-MaxAssigned 'AbilityManager.MaxAssigned')
  - [MaxUnlocked](#P-AbilityManager-MaxUnlocked 'AbilityManager.MaxUnlocked')
  - [ResourcePath](#P-AbilityManager-ResourcePath 'AbilityManager.ResourcePath')
  - [Load(save)](#M-AbilityManager-Load-SaveGame- 'AbilityManager.Load(SaveGame)')
  - [Save(save)](#M-AbilityManager-Save-SaveGame@- 'AbilityManager.Save(SaveGame@)')
- [AbilityRange](#T-AbilityRange 'AbilityRange')
  - [Melee](#F-AbilityRange-Melee 'AbilityRange.Melee')
  - [Ranged](#F-AbilityRange-Ranged 'AbilityRange.Ranged')
  - [Self](#F-AbilityRange-Self 'AbilityRange.Self')
- [AbilityType](#T-AbilityType 'AbilityType')
  - [Area](#F-AbilityType-Area 'AbilityType.Area')
  - [Direct](#F-AbilityType-Direct 'AbilityType.Direct')
  - [Heal](#F-AbilityType-Heal 'AbilityType.Heal')
  - [Shield](#F-AbilityType-Shield 'AbilityType.Shield')
- [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour')
  - [CalculateDesiredVelocity()](#M-AbstractMovementBehaviour-CalculateDesiredVelocity 'AbstractMovementBehaviour.CalculateDesiredVelocity')
  - [Steering()](#M-AbstractMovementBehaviour-Steering 'AbstractMovementBehaviour.Steering')
- [AbstractMovementDecorator](#T-AbstractMovementDecorator 'AbstractMovementDecorator')
  - [#ctor(movementBehaviour,agent,target)](#M-AbstractMovementDecorator-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'AbstractMovementDecorator.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.GameObject,System.Single)')
  - [agent](#F-AbstractMovementDecorator-agent 'AbstractMovementDecorator.agent')
  - [controller](#F-AbstractMovementDecorator-controller 'AbstractMovementDecorator.controller')
  - [maxAccel](#F-AbstractMovementDecorator-maxAccel 'AbstractMovementDecorator.maxAccel')
  - [maxSpeed](#F-AbstractMovementDecorator-maxSpeed 'AbstractMovementDecorator.maxSpeed')
  - [movementBehaviour](#F-AbstractMovementDecorator-movementBehaviour 'AbstractMovementDecorator.movementBehaviour')
  - [radius](#F-AbstractMovementDecorator-radius 'AbstractMovementDecorator.radius')
  - [target](#F-AbstractMovementDecorator-target 'AbstractMovementDecorator.target')
  - [Steering()](#M-AbstractMovementDecorator-Steering 'AbstractMovementDecorator.Steering')
- [Ally](#T-Ally 'Ally')
  - [CharacterType](#P-Ally-CharacterType 'Ally.CharacterType')
  - [Lesson](#P-Ally-Lesson 'Ally.Lesson')
  - [LevelUpgrades](#P-Ally-LevelUpgrades 'Ally.LevelUpgrades')
  - [ListableType](#P-Ally-ListableType 'Ally.ListableType')
- [AllyController](#T-AllyController 'AllyController')
  - [AllyObject](#P-AllyController-AllyObject 'AllyController.AllyObject')
  - [AttackType](#P-AllyController-AttackType 'AllyController.AttackType')
  - [CharacterType](#P-AllyController-CharacterType 'AllyController.CharacterType')
  - [Level](#P-AllyController-Level 'AllyController.Level')
  - [CreateDerivedAttributes()](#M-AllyController-CreateDerivedAttributes 'AllyController.CreateDerivedAttributes')
  - [Register()](#M-AllyController-Register 'AllyController.Register')
  - [Start()](#M-AllyController-Start 'AllyController.Start')
  - [Unregister()](#M-AllyController-Unregister 'AllyController.Unregister')
- [AllyManager](#T-AllyManager 'AllyManager')
- [AssignedListChanged](#T-WorldEntityManager-AssignedListChanged 'WorldEntityManager.AssignedListChanged')
- [AttackType](#T-AttackType 'AttackType')
  - [Caster](#F-AttackType-Caster 'AttackType.Caster')
  - [Melee](#F-AttackType-Melee 'AttackType.Melee')
  - [Ranged](#F-AttackType-Ranged 'AttackType.Ranged')
- [AvoidMovementBehaviour](#T-AvoidMovementBehaviour 'AvoidMovementBehaviour')
  - [#ctor(movementBehaviour,agent,target,radius)](#M-AvoidMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'AvoidMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.GameObject,System.Single)')
- [BackToWorldButton](#T-BackToWorldButton 'BackToWorldButton')
  - [LoadWorld()](#M-BackToWorldButton-LoadWorld 'BackToWorldButton.LoadWorld')
  - [Start()](#M-BackToWorldButton-Start 'BackToWorldButton.Start')
- [BaseAttributes](#T-BaseAttributes 'BaseAttributes')
  - [AbilityDamage](#P-BaseAttributes-AbilityDamage 'BaseAttributes.AbilityDamage')
  - [AttackDamage](#P-BaseAttributes-AttackDamage 'BaseAttributes.AttackDamage')
  - [AttackSpeed](#P-BaseAttributes-AttackSpeed 'BaseAttributes.AttackSpeed')
  - [CooldownReduction](#P-BaseAttributes-CooldownReduction 'BaseAttributes.CooldownReduction')
  - [CriticalHitChance](#P-BaseAttributes-CriticalHitChance 'BaseAttributes.CriticalHitChance')
  - [CriticalHitDamage](#P-BaseAttributes-CriticalHitDamage 'BaseAttributes.CriticalHitDamage')
  - [Defense](#P-BaseAttributes-Defense 'BaseAttributes.Defense')
  - [Energy](#P-BaseAttributes-Energy 'BaseAttributes.Energy')
  - [EnergyRegeneration](#P-BaseAttributes-EnergyRegeneration 'BaseAttributes.EnergyRegeneration')
  - [Health](#P-BaseAttributes-Health 'BaseAttributes.Health')
  - [HealthRegeneration](#P-BaseAttributes-HealthRegeneration 'BaseAttributes.HealthRegeneration')
  - [LifeDrain](#P-BaseAttributes-LifeDrain 'BaseAttributes.LifeDrain')
  - [MovementSpeed](#P-BaseAttributes-MovementSpeed 'BaseAttributes.MovementSpeed')
  - [op_Addition(attributesA,attributesB)](#M-BaseAttributes-op_Addition-BaseAttributes,BaseAttributes- 'BaseAttributes.op_Addition(BaseAttributes,BaseAttributes)')
- [BossManager](#T-BossManager 'BossManager')
- [ButtonAction](#T-ButtonAction 'ButtonAction')
  - [Assign](#F-ButtonAction-Assign 'ButtonAction.Assign')
  - [None](#F-ButtonAction-None 'ButtonAction.None')
  - [Use](#F-ButtonAction-Use 'ButtonAction.Use')
- [Character](#T-Character 'Character')
  - [Animator](#P-Character-Animator 'Character.Animator')
  - [AttackType](#P-Character-AttackType 'Character.AttackType')
  - [BaseAttributes](#P-Character-BaseAttributes 'Character.BaseAttributes')
  - [BonusAttributes](#P-Character-BonusAttributes 'Character.BonusAttributes')
  - [CharacterType](#P-Character-CharacterType 'Character.CharacterType')
  - [Level](#P-Character-Level 'Character.Level')
- [CharacterDirectionChanged](#T-GameCharacterController-CharacterDirectionChanged 'GameCharacterController.CharacterDirectionChanged')
- [CharacterManager](#T-CharacterManager 'CharacterManager')
- [CharacterState](#T-CharacterState 'CharacterState')
  - [Cast](#F-CharacterState-Cast 'CharacterState.Cast')
  - [Dead](#F-CharacterState-Dead 'CharacterState.Dead')
  - [Defend](#F-CharacterState-Defend 'CharacterState.Defend')
  - [Idle](#F-CharacterState-Idle 'CharacterState.Idle')
  - [Melee](#F-CharacterState-Melee 'CharacterState.Melee')
  - [Ranged](#F-CharacterState-Ranged 'CharacterState.Ranged')
  - [Walk](#F-CharacterState-Walk 'CharacterState.Walk')
- [CharacterStateChanged](#T-GameCharacterController-CharacterStateChanged 'GameCharacterController.CharacterStateChanged')
- [CharacterType](#T-CharacterType 'CharacterType')
  - [Ally](#F-CharacterType-Ally 'CharacterType.Ally')
  - [Boss](#F-CharacterType-Boss 'CharacterType.Boss')
  - [Enemy](#F-CharacterType-Enemy 'CharacterType.Enemy')
  - [Hero](#F-CharacterType-Hero 'CharacterType.Hero')
  - [None](#F-CharacterType-None 'CharacterType.None')
- [CombatController](#T-CombatController 'CombatController')
  - [CanAttack](#P-CombatController-CanAttack 'CombatController.CanAttack')
  - [CharacterController](#P-CombatController-CharacterController 'CombatController.CharacterController')
  - [CurrentEnergy](#P-CombatController-CurrentEnergy 'CombatController.CurrentEnergy')
  - [CurrentHealth](#P-CombatController-CurrentHealth 'CombatController.CurrentHealth')
  - [DesiredCombatRange](#P-CombatController-DesiredCombatRange 'CombatController.DesiredCombatRange')
  - [HasHostileTarget](#P-CombatController-HasHostileTarget 'CombatController.HasHostileTarget')
  - [HasTargetInRange](#P-CombatController-HasTargetInRange 'CombatController.HasTargetInRange')
  - [IsStunned](#P-CombatController-IsStunned 'CombatController.IsStunned')
  - [IsTimeToAttack](#P-CombatController-IsTimeToAttack 'CombatController.IsTimeToAttack')
  - [ApplyDamage(damage,isCritical)](#M-CombatController-ApplyDamage-System-Int32,System-Boolean- 'CombatController.ApplyDamage(System.Int32,System.Boolean)')
  - [ApplyExperience()](#M-CombatController-ApplyExperience 'CombatController.ApplyExperience')
  - [ApplyReward()](#M-CombatController-ApplyReward 'CombatController.ApplyReward')
  - [ApplyStun(duration)](#M-CombatController-ApplyStun-System-Single- 'CombatController.ApplyStun(System.Single)')
  - [CriticalModifier()](#M-CombatController-CriticalModifier 'CombatController.CriticalModifier')
  - [Despawn()](#M-CombatController-Despawn 'CombatController.Despawn')
  - [FaceTarget()](#M-CombatController-FaceTarget 'CombatController.FaceTarget')
  - [GetClosestHostile(hostiles)](#M-CombatController-GetClosestHostile-System-Collections-Generic-List{GameCharacterController}- 'CombatController.GetClosestHostile(System.Collections.Generic.List{GameCharacterController})')
  - [PerformCasterAttack()](#M-CombatController-PerformCasterAttack 'CombatController.PerformCasterAttack')
  - [PerformCombatRound()](#M-CombatController-PerformCombatRound 'CombatController.PerformCombatRound')
  - [PerformLifeDrain(damage)](#M-CombatController-PerformLifeDrain-System-Int32- 'CombatController.PerformLifeDrain(System.Int32)')
  - [PerformMeleeAttack()](#M-CombatController-PerformMeleeAttack 'CombatController.PerformMeleeAttack')
  - [PerformRangedAttack()](#M-CombatController-PerformRangedAttack 'CombatController.PerformRangedAttack')
  - [SpawnArrow()](#M-CombatController-SpawnArrow 'CombatController.SpawnArrow')
  - [SpawnCasterball()](#M-CombatController-SpawnCasterball 'CombatController.SpawnCasterball')
  - [SpawnProjectile(prefab,location,damage,target,criticalModifier)](#M-CombatController-SpawnProjectile-UnityEngine-GameObject,UnityEngine-Vector3,System-Int32,GameCharacterController,System-Single- 'CombatController.SpawnProjectile(UnityEngine.GameObject,UnityEngine.Vector3,System.Int32,GameCharacterController,System.Single)')
  - [Start()](#M-CombatController-Start 'CombatController.Start')
  - [Update()](#M-CombatController-Update 'CombatController.Update')
  - [UpdateRegeneration()](#M-CombatController-UpdateRegeneration 'CombatController.UpdateRegeneration')
  - [UpdateStun()](#M-CombatController-UpdateStun 'CombatController.UpdateStun')
  - [UpdateTarget()](#M-CombatController-UpdateTarget 'CombatController.UpdateTarget')
- [CombatTextController](#T-CombatTextController 'CombatTextController')
  - [Color](#P-CombatTextController-Color 'CombatTextController.Color')
  - [Text](#P-CombatTextController-Text 'CombatTextController.Text')
  - [Animate(startPosition,endPosition)](#M-CombatTextController-Animate-UnityEngine-Vector3,UnityEngine-Vector3- 'CombatTextController.Animate(UnityEngine.Vector3,UnityEngine.Vector3)')
  - [Start()](#M-CombatTextController-Start 'CombatTextController.Start')
- [ConditionalDebug](#T-ConditionalDebug 'ConditionalDebug')
  - [Assert(condition)](#M-ConditionalDebug-Assert-System-Boolean- 'ConditionalDebug.Assert(System.Boolean)')
  - [Assert(condition,context)](#M-ConditionalDebug-Assert-System-Boolean,UnityEngine-Object- 'ConditionalDebug.Assert(System.Boolean,UnityEngine.Object)')
  - [Assert(condition,message)](#M-ConditionalDebug-Assert-System-Boolean,System-Object- 'ConditionalDebug.Assert(System.Boolean,System.Object)')
  - [Assert(condition,message,context)](#M-ConditionalDebug-Assert-System-Boolean,System-Object,UnityEngine-Object- 'ConditionalDebug.Assert(System.Boolean,System.Object,UnityEngine.Object)')
  - [AssertFormat(condition,format,args)](#M-ConditionalDebug-AssertFormat-System-Boolean,System-String,System-Object[]- 'ConditionalDebug.AssertFormat(System.Boolean,System.String,System.Object[])')
  - [AssertFormat(condition,context,format,args)](#M-ConditionalDebug-AssertFormat-System-Boolean,UnityEngine-Object,System-String,System-Object[]- 'ConditionalDebug.AssertFormat(System.Boolean,UnityEngine.Object,System.String,System.Object[])')
  - [Break()](#M-ConditionalDebug-Break 'ConditionalDebug.Break')
  - [ClearDeveloperConsole()](#M-ConditionalDebug-ClearDeveloperConsole 'ConditionalDebug.ClearDeveloperConsole')
  - [DrawLine(start,end,color,duration,depthTest)](#M-ConditionalDebug-DrawLine-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean- 'ConditionalDebug.DrawLine(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.Single,System.Boolean)')
  - [DrawRay(start,dir,color,duration,depthTest)](#M-ConditionalDebug-DrawRay-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean- 'ConditionalDebug.DrawRay(UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.Single,System.Boolean)')
  - [Log(message)](#M-ConditionalDebug-Log-System-Object- 'ConditionalDebug.Log(System.Object)')
  - [Log(message,context)](#M-ConditionalDebug-Log-System-Object,UnityEngine-Object- 'ConditionalDebug.Log(System.Object,UnityEngine.Object)')
  - [LogAssertion(message)](#M-ConditionalDebug-LogAssertion-System-Object- 'ConditionalDebug.LogAssertion(System.Object)')
  - [LogAssertion(message,context)](#M-ConditionalDebug-LogAssertion-System-Object,UnityEngine-Object- 'ConditionalDebug.LogAssertion(System.Object,UnityEngine.Object)')
  - [LogAssertionFormat(format,args)](#M-ConditionalDebug-LogAssertionFormat-System-String,System-Object[]- 'ConditionalDebug.LogAssertionFormat(System.String,System.Object[])')
  - [LogAssertionFormat(context,format,args)](#M-ConditionalDebug-LogAssertionFormat-UnityEngine-Object,System-String,System-Object[]- 'ConditionalDebug.LogAssertionFormat(UnityEngine.Object,System.String,System.Object[])')
  - [LogError(message)](#M-ConditionalDebug-LogError-System-Object- 'ConditionalDebug.LogError(System.Object)')
  - [LogError(message,context)](#M-ConditionalDebug-LogError-System-Object,UnityEngine-Object- 'ConditionalDebug.LogError(System.Object,UnityEngine.Object)')
  - [LogErrorFormat(format,args)](#M-ConditionalDebug-LogErrorFormat-System-String,System-Object[]- 'ConditionalDebug.LogErrorFormat(System.String,System.Object[])')
  - [LogErrorFormat(context,format,args)](#M-ConditionalDebug-LogErrorFormat-UnityEngine-Object,System-String,System-Object[]- 'ConditionalDebug.LogErrorFormat(UnityEngine.Object,System.String,System.Object[])')
  - [LogException(exception)](#M-ConditionalDebug-LogException-System-Exception- 'ConditionalDebug.LogException(System.Exception)')
  - [LogException(exception,context)](#M-ConditionalDebug-LogException-System-Exception,UnityEngine-Object- 'ConditionalDebug.LogException(System.Exception,UnityEngine.Object)')
  - [LogFormat(format,args)](#M-ConditionalDebug-LogFormat-System-String,System-Object[]- 'ConditionalDebug.LogFormat(System.String,System.Object[])')
  - [LogFormat(context,format,args)](#M-ConditionalDebug-LogFormat-UnityEngine-Object,System-String,System-Object[]- 'ConditionalDebug.LogFormat(UnityEngine.Object,System.String,System.Object[])')
  - [LogWarning(message)](#M-ConditionalDebug-LogWarning-System-Object- 'ConditionalDebug.LogWarning(System.Object)')
  - [LogWarning(message,context)](#M-ConditionalDebug-LogWarning-System-Object,UnityEngine-Object- 'ConditionalDebug.LogWarning(System.Object,UnityEngine.Object)')
  - [LogWarningFormat(format,args)](#M-ConditionalDebug-LogWarningFormat-System-String,System-Object[]- 'ConditionalDebug.LogWarningFormat(System.String,System.Object[])')
  - [LogWarningFormat(context,format,args)](#M-ConditionalDebug-LogWarningFormat-UnityEngine-Object,System-String,System-Object[]- 'ConditionalDebug.LogWarningFormat(UnityEngine.Object,System.String,System.Object[])')
- [CreatePopupButton](#T-CreatePopupButton 'CreatePopupButton')
  - [SpawnPopup()](#M-CreatePopupButton-SpawnPopup 'CreatePopupButton.SpawnPopup')
  - [Start()](#M-CreatePopupButton-Start 'CreatePopupButton.Start')
- [CreateUpgradeAlliesPopupButton](#T-CreateUpgradeAlliesPopupButton 'CreateUpgradeAlliesPopupButton')
  - [SpawnPopup()](#M-CreateUpgradeAlliesPopupButton-SpawnPopup 'CreateUpgradeAlliesPopupButton.SpawnPopup')
  - [Start()](#M-CreateUpgradeAlliesPopupButton-Start 'CreateUpgradeAlliesPopupButton.Start')
- [CreateUpgradeHeroPopupButton](#T-CreateUpgradeHeroPopupButton 'CreateUpgradeHeroPopupButton')
  - [SpawnPopup()](#M-CreateUpgradeHeroPopupButton-SpawnPopup 'CreateUpgradeHeroPopupButton.SpawnPopup')
  - [Start()](#M-CreateUpgradeHeroPopupButton-Start 'CreateUpgradeHeroPopupButton.Start')
- [CurrencyText](#T-CurrencyText 'CurrencyText')
  - [OnGUI()](#M-CurrencyText-OnGUI 'CurrencyText.OnGUI')
  - [Start()](#M-CurrencyText-Start 'CurrencyText.Start')
- [CustomGizmo](#T-CustomGizmo 'CustomGizmo')
  - [OnDrawGizmos()](#M-CustomGizmo-OnDrawGizmos 'CustomGizmo.OnDrawGizmos')
- [DerivedAttributes](#T-DerivedAttributes 'DerivedAttributes')
  - [#ctor(character,level)](#M-DerivedAttributes-#ctor-Character,System-Int32- 'DerivedAttributes.#ctor(Character,System.Int32)')
  - [AbilityDamage](#P-DerivedAttributes-AbilityDamage 'DerivedAttributes.AbilityDamage')
  - [AttackDamage](#P-DerivedAttributes-AttackDamage 'DerivedAttributes.AttackDamage')
  - [AttackSpeed](#P-DerivedAttributes-AttackSpeed 'DerivedAttributes.AttackSpeed')
  - [CooldownReduction](#P-DerivedAttributes-CooldownReduction 'DerivedAttributes.CooldownReduction')
  - [CriticalHitChance](#P-DerivedAttributes-CriticalHitChance 'DerivedAttributes.CriticalHitChance')
  - [CriticalHitDamage](#P-DerivedAttributes-CriticalHitDamage 'DerivedAttributes.CriticalHitDamage')
  - [Defense](#P-DerivedAttributes-Defense 'DerivedAttributes.Defense')
  - [Energy](#P-DerivedAttributes-Energy 'DerivedAttributes.Energy')
  - [EnergyRegeneration](#P-DerivedAttributes-EnergyRegeneration 'DerivedAttributes.EnergyRegeneration')
  - [Health](#P-DerivedAttributes-Health 'DerivedAttributes.Health')
  - [HealthRegeneration](#P-DerivedAttributes-HealthRegeneration 'DerivedAttributes.HealthRegeneration')
  - [LifeDrain](#P-DerivedAttributes-LifeDrain 'DerivedAttributes.LifeDrain')
  - [MovementSpeed](#P-DerivedAttributes-MovementSpeed 'DerivedAttributes.MovementSpeed')
  - [CalculateDerivedAttributes()](#M-DerivedAttributes-CalculateDerivedAttributes 'DerivedAttributes.CalculateDerivedAttributes')
  - [DeriveAbilityDamage()](#M-DerivedAttributes-DeriveAbilityDamage 'DerivedAttributes.DeriveAbilityDamage')
  - [DeriveAttackDamage()](#M-DerivedAttributes-DeriveAttackDamage 'DerivedAttributes.DeriveAttackDamage')
  - [DeriveAttackSpeed()](#M-DerivedAttributes-DeriveAttackSpeed 'DerivedAttributes.DeriveAttackSpeed')
  - [DeriveAttributeFloat(baseAttribute,fullValue,bonusAttribute,upgradable)](#M-DerivedAttributes-DeriveAttributeFloat-System-Int32,System-Single,System-Int32,System-Boolean- 'DerivedAttributes.DeriveAttributeFloat(System.Int32,System.Single,System.Int32,System.Boolean)')
  - [DeriveAttributeInt(baseAttribute,fullValue,bonusAttribute,upgradable)](#M-DerivedAttributes-DeriveAttributeInt-System-Int32,System-Int32,System-Int32,System-Boolean- 'DerivedAttributes.DeriveAttributeInt(System.Int32,System.Int32,System.Int32,System.Boolean)')
  - [DeriveCooldownReduction()](#M-DerivedAttributes-DeriveCooldownReduction 'DerivedAttributes.DeriveCooldownReduction')
  - [DeriveCriticalHitChance()](#M-DerivedAttributes-DeriveCriticalHitChance 'DerivedAttributes.DeriveCriticalHitChance')
  - [DeriveCriticalHitDamage()](#M-DerivedAttributes-DeriveCriticalHitDamage 'DerivedAttributes.DeriveCriticalHitDamage')
  - [DeriveDefense()](#M-DerivedAttributes-DeriveDefense 'DerivedAttributes.DeriveDefense')
  - [DeriveEnergy()](#M-DerivedAttributes-DeriveEnergy 'DerivedAttributes.DeriveEnergy')
  - [DeriveEnergyRegeneration()](#M-DerivedAttributes-DeriveEnergyRegeneration 'DerivedAttributes.DeriveEnergyRegeneration')
  - [DeriveHealth()](#M-DerivedAttributes-DeriveHealth 'DerivedAttributes.DeriveHealth')
  - [DeriveHealthRegeneration()](#M-DerivedAttributes-DeriveHealthRegeneration 'DerivedAttributes.DeriveHealthRegeneration')
  - [DeriveLifeDrain()](#M-DerivedAttributes-DeriveLifeDrain 'DerivedAttributes.DeriveLifeDrain')
  - [DeriveMovementSpeed()](#M-DerivedAttributes-DeriveMovementSpeed 'DerivedAttributes.DeriveMovementSpeed')
- [DirectAbilityController](#T-DirectAbilityController 'DirectAbilityController')
  - [Caster](#P-DirectAbilityController-Caster 'DirectAbilityController.Caster')
  - [CriticalModifier](#P-DirectAbilityController-CriticalModifier 'DirectAbilityController.CriticalModifier')
  - [Damage](#P-DirectAbilityController-Damage 'DirectAbilityController.Damage')
  - [Target](#P-DirectAbilityController-Target 'DirectAbilityController.Target')
  - [Update()](#M-DirectAbilityController-Update 'DirectAbilityController.Update')
- [DirectMovementBehaviour](#T-DirectMovementBehaviour 'DirectMovementBehaviour')
  - [#ctor(movementBehaviour,agent,target,radius)](#M-DirectMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'DirectMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.GameObject,System.Single)')
  - [CalculateMaximumVelocity(fromPosition,toPosition)](#M-DirectMovementBehaviour-CalculateMaximumVelocity-UnityEngine-Vector2,UnityEngine-Vector2- 'DirectMovementBehaviour.CalculateMaximumVelocity(UnityEngine.Vector2,UnityEngine.Vector2)')
- [DroppedEquipmentController](#T-DroppedEquipmentController 'DroppedEquipmentController')
  - [Image](#P-DroppedEquipmentController-Image 'DroppedEquipmentController.Image')
  - [Animate(startPosition,endPosition)](#M-DroppedEquipmentController-Animate-UnityEngine-Vector3,UnityEngine-Vector3- 'DroppedEquipmentController.Animate(UnityEngine.Vector3,UnityEngine.Vector3)')
- [Enemy](#T-Enemy 'Enemy')
  - [CharacterType](#P-Enemy-CharacterType 'Enemy.CharacterType')
- [EnemyController](#T-EnemyController 'EnemyController')
  - [AttackType](#P-EnemyController-AttackType 'EnemyController.AttackType')
  - [CharacterType](#P-EnemyController-CharacterType 'EnemyController.CharacterType')
  - [EnemyObject](#P-EnemyController-EnemyObject 'EnemyController.EnemyObject')
  - [Level](#P-EnemyController-Level 'EnemyController.Level')
  - [CreateDerivedAttributes()](#M-EnemyController-CreateDerivedAttributes 'EnemyController.CreateDerivedAttributes')
  - [Register()](#M-EnemyController-Register 'EnemyController.Register')
  - [Start()](#M-EnemyController-Start 'EnemyController.Start')
  - [Unregister()](#M-EnemyController-Unregister 'EnemyController.Unregister')
- [EnemyManager](#T-EnemyManager 'EnemyManager')
- [Equipment](#T-Equipment 'Equipment')
  - [AttackType](#P-Equipment-AttackType 'Equipment.AttackType')
  - [AttributeModifiers](#P-Equipment-AttributeModifiers 'Equipment.AttributeModifiers')
  - [EquipmentSlot](#P-Equipment-EquipmentSlot 'Equipment.EquipmentSlot')
  - [EquipmentType](#P-Equipment-EquipmentType 'Equipment.EquipmentType')
  - [ListableType](#P-Equipment-ListableType 'Equipment.ListableType')
- [EquipmentSlot](#T-EquipmentSlot 'EquipmentSlot')
  - [Body](#F-EquipmentSlot-Body 'EquipmentSlot.Body')
  - [LeftHand](#F-EquipmentSlot-LeftHand 'EquipmentSlot.LeftHand')
  - [RightHand](#F-EquipmentSlot-RightHand 'EquipmentSlot.RightHand')
  - [TwoHand](#F-EquipmentSlot-TwoHand 'EquipmentSlot.TwoHand')
- [EquipmentType](#T-EquipmentType 'EquipmentType')
  - [Armor](#F-EquipmentType-Armor 'EquipmentType.Armor')
  - [Shield](#F-EquipmentType-Shield 'EquipmentType.Shield')
  - [Weapon](#F-EquipmentType-Weapon 'EquipmentType.Weapon')
- [ExperienceText](#T-ExperienceText 'ExperienceText')
  - [OnGUI()](#M-ExperienceText-OnGUI 'ExperienceText.OnGUI')
  - [Start()](#M-ExperienceText-Start 'ExperienceText.Start')
- [FleeMovementBehaviour](#T-FleeMovementBehaviour 'FleeMovementBehaviour')
  - [#ctor(movementBehaviour,agent,target,radius)](#M-FleeMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'FleeMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.GameObject,System.Single)')
  - [CalculateDesiredVelocity()](#M-FleeMovementBehaviour-CalculateDesiredVelocity 'FleeMovementBehaviour.CalculateDesiredVelocity')
- [FloatingBarController](#T-FloatingBarController 'FloatingBarController')
  - [Start()](#M-FloatingBarController-Start 'FloatingBarController.Start')
  - [Update()](#M-FloatingBarController-Update 'FloatingBarController.Update')
- [GameCharacterController](#T-GameCharacterController 'GameCharacterController')
  - [isCombatDummy](#F-GameCharacterController-isCombatDummy 'GameCharacterController.isCombatDummy')
  - [Animator](#P-GameCharacterController-Animator 'GameCharacterController.Animator')
  - [AttackType](#P-GameCharacterController-AttackType 'GameCharacterController.AttackType')
  - [Attributes](#P-GameCharacterController-Attributes 'GameCharacterController.Attributes')
  - [CharacterObject](#P-GameCharacterController-CharacterObject 'GameCharacterController.CharacterObject')
  - [CharacterState](#P-GameCharacterController-CharacterState 'GameCharacterController.CharacterState')
  - [CharacterType](#P-GameCharacterController-CharacterType 'GameCharacterController.CharacterType')
  - [CombatController](#P-GameCharacterController-CombatController 'GameCharacterController.CombatController')
  - [IsDead](#P-GameCharacterController-IsDead 'GameCharacterController.IsDead')
  - [IsFriendly](#P-GameCharacterController-IsFriendly 'GameCharacterController.IsFriendly')
  - [LastDirection](#P-GameCharacterController-LastDirection 'GameCharacterController.LastDirection')
  - [Level](#P-GameCharacterController-Level 'GameCharacterController.Level')
  - [Location](#P-GameCharacterController-Location 'GameCharacterController.Location')
  - [MovementController](#P-GameCharacterController-MovementController 'GameCharacterController.MovementController')
  - [Rigidbody](#P-GameCharacterController-Rigidbody 'GameCharacterController.Rigidbody')
  - [CreateAnimator()](#M-GameCharacterController-CreateAnimator 'GameCharacterController.CreateAnimator')
  - [CreateCapsuleCollider2D()](#M-GameCharacterController-CreateCapsuleCollider2D 'GameCharacterController.CreateCapsuleCollider2D')
  - [CreateCombatController()](#M-GameCharacterController-CreateCombatController 'GameCharacterController.CreateCombatController')
  - [CreateDerivedAttributes()](#M-GameCharacterController-CreateDerivedAttributes 'GameCharacterController.CreateDerivedAttributes')
  - [CreateFloatingHealthBar()](#M-GameCharacterController-CreateFloatingHealthBar 'GameCharacterController.CreateFloatingHealthBar')
  - [CreateGraphicsController()](#M-GameCharacterController-CreateGraphicsController 'GameCharacterController.CreateGraphicsController')
  - [CreateMovementController()](#M-GameCharacterController-CreateMovementController 'GameCharacterController.CreateMovementController')
  - [CreateRigidbody2D()](#M-GameCharacterController-CreateRigidbody2D 'GameCharacterController.CreateRigidbody2D')
  - [CreateSpriteRenderer()](#M-GameCharacterController-CreateSpriteRenderer 'GameCharacterController.CreateSpriteRenderer')
  - [OnDestroy()](#M-GameCharacterController-OnDestroy 'GameCharacterController.OnDestroy')
  - [Register()](#M-GameCharacterController-Register 'GameCharacterController.Register')
  - [Unregister()](#M-GameCharacterController-Unregister 'GameCharacterController.Unregister')
- [GameManager](#T-GameManager 'GameManager')
  - [AbilityManager](#P-GameManager-AbilityManager 'GameManager.AbilityManager')
  - [AllCharacters](#P-GameManager-AllCharacters 'GameManager.AllCharacters')
  - [AllEnemies](#P-GameManager-AllEnemies 'GameManager.AllEnemies')
  - [AllFriendlies](#P-GameManager-AllFriendlies 'GameManager.AllFriendlies')
  - [AllyManager](#P-GameManager-AllyManager 'GameManager.AllyManager')
  - [BossManager](#P-GameManager-BossManager 'GameManager.BossManager')
  - [CanUpgradeHero](#P-GameManager-CanUpgradeHero 'GameManager.CanUpgradeHero')
  - [EnemyManager](#P-GameManager-EnemyManager 'GameManager.EnemyManager')
  - [GameSettings](#P-GameManager-GameSettings 'GameManager.GameSettings')
  - [Hero](#P-GameManager-Hero 'GameManager.Hero')
  - [HeroManager](#P-GameManager-HeroManager 'GameManager.HeroManager')
  - [InventoryManager](#P-GameManager-InventoryManager 'GameManager.InventoryManager')
  - [OnStage](#P-GameManager-OnStage 'GameManager.OnStage')
  - [QueueManager](#P-GameManager-QueueManager 'GameManager.QueueManager')
  - [RosterManager](#P-GameManager-RosterManager 'GameManager.RosterManager')
  - [StageManager](#P-GameManager-StageManager 'GameManager.StageManager')
  - [UpgradeHeroCost](#P-GameManager-UpgradeHeroCost 'GameManager.UpgradeHeroCost')
  - [WorldManager](#P-GameManager-WorldManager 'GameManager.WorldManager')
  - [AllCharactersExcept(self)](#M-GameManager-AllCharactersExcept-GameCharacterController- 'GameManager.AllCharactersExcept(GameCharacterController)')
  - [Awake()](#M-GameManager-Awake 'GameManager.Awake')
  - [CanUpgradeAlly(allyName)](#M-GameManager-CanUpgradeAlly-System-String- 'GameManager.CanUpgradeAlly(System.String)')
  - [GenerateIdleRewards()](#M-GameManager-GenerateIdleRewards 'GameManager.GenerateIdleRewards')
  - [GetManagerByType(entityType)](#M-GameManager-GetManagerByType-ListableEntityType- 'GameManager.GetManagerByType(ListableEntityType)')
  - [InitializeGameWorldManagers()](#M-GameManager-InitializeGameWorldManagers 'GameManager.InitializeGameWorldManagers')
  - [InitializeStageEntityManagers()](#M-GameManager-InitializeStageEntityManagers 'GameManager.InitializeStageEntityManagers')
  - [InitializeWorld()](#M-GameManager-InitializeWorld 'GameManager.InitializeWorld')
  - [InitializeWorldEntityManagers()](#M-GameManager-InitializeWorldEntityManagers 'GameManager.InitializeWorldEntityManagers')
  - [LoadStage(stage)](#M-GameManager-LoadStage-SceneField- 'GameManager.LoadStage(SceneField)')
  - [LoadStageUi()](#M-GameManager-LoadStageUi 'GameManager.LoadStageUi')
  - [LoadWorld()](#M-GameManager-LoadWorld 'GameManager.LoadWorld')
  - [LoadWorldUi()](#M-GameManager-LoadWorldUi 'GameManager.LoadWorldUi')
  - [LoadZone(zone)](#M-GameManager-LoadZone-System-String- 'GameManager.LoadZone(System.String)')
  - [LoadZoneUi()](#M-GameManager-LoadZoneUi 'GameManager.LoadZoneUi')
  - [OnApplicationPause(pause)](#M-GameManager-OnApplicationPause-System-Boolean- 'GameManager.OnApplicationPause(System.Boolean)')
  - [OnApplicationQuit()](#M-GameManager-OnApplicationQuit 'GameManager.OnApplicationQuit')
  - [OnDestroy()](#M-GameManager-OnDestroy 'GameManager.OnDestroy')
  - [OnSceneChanged(previousScene,newScene)](#M-GameManager-OnSceneChanged-UnityEngine-SceneManagement-Scene,UnityEngine-SceneManagement-Scene- 'GameManager.OnSceneChanged(UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene)')
  - [SaveGame()](#M-GameManager-SaveGame 'GameManager.SaveGame')
  - [Start()](#M-GameManager-Start 'GameManager.Start')
  - [Update()](#M-GameManager-Update 'GameManager.Update')
  - [UpgradeAlly(allyName)](#M-GameManager-UpgradeAlly-System-String- 'GameManager.UpgradeAlly(System.String)')
  - [UpgradeAllyCost(allyName)](#M-GameManager-UpgradeAllyCost-System-String- 'GameManager.UpgradeAllyCost(System.String)')
  - [UpgradeHero()](#M-GameManager-UpgradeHero 'GameManager.UpgradeHero')
- [GameSettings](#T-GameSettings 'GameSettings')
- [GizmoShape](#T-CustomGizmo-GizmoShape 'CustomGizmo.GizmoShape')
- [GraphicsController](#T-GraphicsController 'GraphicsController')
  - [CharacterStateChanged()](#M-GraphicsController-CharacterStateChanged 'GraphicsController.CharacterStateChanged')
  - [GetCharacterComponent()](#M-GraphicsController-GetCharacterComponent 'GraphicsController.GetCharacterComponent')
  - [GetStateAnimationString()](#M-GraphicsController-GetStateAnimationString 'GraphicsController.GetStateAnimationString')
  - [Start()](#M-GraphicsController-Start 'GraphicsController.Start')
  - [Update()](#M-GraphicsController-Update 'GraphicsController.Update')
  - [UpdateSortingOrder()](#M-GraphicsController-UpdateSortingOrder 'GraphicsController.UpdateSortingOrder')
- [HazardController](#T-HazardController 'HazardController')
  - [IsPathable](#P-HazardController-IsPathable 'HazardController.IsPathable')
  - [ApplyEffect()](#M-HazardController-ApplyEffect-GameCharacterController- 'HazardController.ApplyEffect(GameCharacterController)')
  - [OnTriggerEnter2D()](#M-HazardController-OnTriggerEnter2D-UnityEngine-Collider2D- 'HazardController.OnTriggerEnter2D(UnityEngine.Collider2D)')
- [HazardType](#T-HazardType 'HazardType')
  - [Damage](#F-HazardType-Damage 'HazardType.Damage')
  - [Force](#F-HazardType-Force 'HazardType.Force')
  - [Stun](#F-HazardType-Stun 'HazardType.Stun')
- [HelpBoxAttribute](#T-HelpBoxAttribute 'HelpBoxAttribute')
- [HelpBoxMessageType](#T-HelpBoxMessageType 'HelpBoxMessageType')
- [Hero](#T-Hero 'Hero')
  - [CharacterType](#P-Hero-CharacterType 'Hero.CharacterType')
- [HeroCombatController](#T-HeroCombatController 'HeroCombatController')
  - [AbilityCooldowns](#P-HeroCombatController-AbilityCooldowns 'HeroCombatController.AbilityCooldowns')
  - [ApplyDamage(damage,isCritical)](#M-HeroCombatController-ApplyDamage-System-Int32,System-Boolean- 'HeroCombatController.ApplyDamage(System.Int32,System.Boolean)')
  - [ApplyEnergyLoss(energyCost)](#M-HeroCombatController-ApplyEnergyLoss-System-Int32- 'HeroCombatController.ApplyEnergyLoss(System.Int32)')
  - [PerformCombatRound()](#M-HeroCombatController-PerformCombatRound 'HeroCombatController.PerformCombatRound')
  - [PerformDefendAbility(ability)](#M-HeroCombatController-PerformDefendAbility-Ability- 'HeroCombatController.PerformDefendAbility(Ability)')
  - [PerformFireball(ability,target)](#M-HeroCombatController-PerformFireball-Ability,GameCharacterController- 'HeroCombatController.PerformFireball(Ability,GameCharacterController)')
  - [PerformMeleeAreaAbility(ability,target)](#M-HeroCombatController-PerformMeleeAreaAbility-Ability,GameCharacterController- 'HeroCombatController.PerformMeleeAreaAbility(Ability,GameCharacterController)')
  - [PerformRangedAreaAbility(ability,target)](#M-HeroCombatController-PerformRangedAreaAbility-Ability,GameCharacterController- 'HeroCombatController.PerformRangedAreaAbility(Ability,GameCharacterController)')
  - [SpawnStorm(location,target)](#M-HeroCombatController-SpawnStorm-UnityEngine-Vector3,GameCharacterController- 'HeroCombatController.SpawnStorm(UnityEngine.Vector3,GameCharacterController)')
  - [Start()](#M-HeroCombatController-Start 'HeroCombatController.Start')
  - [Update()](#M-HeroCombatController-Update 'HeroCombatController.Update')
  - [UpdateCooldowns()](#M-HeroCombatController-UpdateCooldowns 'HeroCombatController.UpdateCooldowns')
  - [UpdateDefend()](#M-HeroCombatController-UpdateDefend 'HeroCombatController.UpdateDefend')
  - [UpdateTarget()](#M-HeroCombatController-UpdateTarget 'HeroCombatController.UpdateTarget')
- [HeroController](#T-HeroController 'HeroController')
  - [AttackType](#P-HeroController-AttackType 'HeroController.AttackType')
  - [CharacterObject](#P-HeroController-CharacterObject 'HeroController.CharacterObject')
  - [CharacterType](#P-HeroController-CharacterType 'HeroController.CharacterType')
  - [HeroCombatController](#P-HeroController-HeroCombatController 'HeroController.HeroCombatController')
  - [HeroInputController](#P-HeroController-HeroInputController 'HeroController.HeroInputController')
  - [HeroMovementController](#P-HeroController-HeroMovementController 'HeroController.HeroMovementController')
  - [HeroObject](#P-HeroController-HeroObject 'HeroController.HeroObject')
  - [Level](#P-HeroController-Level 'HeroController.Level')
  - [CreateCombatController()](#M-HeroController-CreateCombatController 'HeroController.CreateCombatController')
  - [CreateDerivedAttributes()](#M-HeroController-CreateDerivedAttributes 'HeroController.CreateDerivedAttributes')
  - [CreateHeroInputController()](#M-HeroController-CreateHeroInputController 'HeroController.CreateHeroInputController')
  - [PerformAbility(ability,target)](#M-HeroController-PerformAbility-Ability,GameCharacterController- 'HeroController.PerformAbility(Ability,GameCharacterController)')
  - [PerformAreaAbility(ability,target)](#M-HeroController-PerformAreaAbility-Ability,GameCharacterController- 'HeroController.PerformAreaAbility(Ability,GameCharacterController)')
  - [PerformDirectAbility(ability,target)](#M-HeroController-PerformDirectAbility-Ability,GameCharacterController- 'HeroController.PerformDirectAbility(Ability,GameCharacterController)')
  - [PerformHealAbility(ability,target)](#M-HeroController-PerformHealAbility-Ability,GameCharacterController- 'HeroController.PerformHealAbility(Ability,GameCharacterController)')
  - [PerformShieldAbility(ability,target)](#M-HeroController-PerformShieldAbility-Ability,GameCharacterController- 'HeroController.PerformShieldAbility(Ability,GameCharacterController)')
  - [Register()](#M-HeroController-Register 'HeroController.Register')
  - [SpawnAllies()](#M-HeroController-SpawnAllies 'HeroController.SpawnAllies')
  - [Start()](#M-HeroController-Start 'HeroController.Start')
  - [Unregister()](#M-HeroController-Unregister 'HeroController.Unregister')
  - [UseAbility(ability)](#M-HeroController-UseAbility-Ability- 'HeroController.UseAbility(Ability)')
- [HeroEnergyBar](#T-HeroEnergyBar 'HeroEnergyBar')
  - [OnGUI()](#M-HeroEnergyBar-OnGUI 'HeroEnergyBar.OnGUI')
- [HeroHealthBar](#T-HeroHealthBar 'HeroHealthBar')
  - [OnGUI()](#M-HeroHealthBar-OnGUI 'HeroHealthBar.OnGUI')
- [HeroInputController](#T-HeroInputController 'HeroInputController')
  - [AwaitTarget(ability)](#M-HeroInputController-AwaitTarget-Ability- 'HeroInputController.AwaitTarget(Ability)')
  - [IsPointerOverUIObject()](#M-HeroInputController-IsPointerOverUIObject 'HeroInputController.IsPointerOverUIObject')
  - [ProcessTap(position)](#M-HeroInputController-ProcessTap-UnityEngine-Vector2- 'HeroInputController.ProcessTap(UnityEngine.Vector2)')
  - [Start()](#M-HeroInputController-Start 'HeroInputController.Start')
  - [Update()](#M-HeroInputController-Update 'HeroInputController.Update')
- [HeroManager](#T-HeroManager 'HeroManager')
  - [#ctor()](#M-HeroManager-#ctor 'HeroManager.#ctor')
  - [Currency](#P-HeroManager-Currency 'HeroManager.Currency')
  - [Experience](#P-HeroManager-Experience 'HeroManager.Experience')
  - [Hero](#P-HeroManager-Hero 'HeroManager.Hero')
  - [HeroObject](#P-HeroManager-HeroObject 'HeroManager.HeroObject')
  - [Level](#P-HeroManager-Level 'HeroManager.Level')
  - [AddHeroToList(addToList)](#M-HeroManager-AddHeroToList-System-Collections-Generic-List{GameCharacterController}@- 'HeroManager.AddHeroToList(System.Collections.Generic.List{GameCharacterController}@)')
  - [Load(save)](#M-HeroManager-Load-SaveGame- 'HeroManager.Load(SaveGame)')
  - [Save(save)](#M-HeroManager-Save-SaveGame@- 'HeroManager.Save(SaveGame@)')
- [HeroMovementController](#T--HeroMovementController '.HeroMovementController')
  - [Location](#P-HeroMovementController-Location 'HeroMovementController.Location')
  - [GenerateSeekBehaviour()](#M-HeroMovementController-GenerateSeekBehaviour 'HeroMovementController.GenerateSeekBehaviour')
  - [Start()](#M-HeroMovementController-Start 'HeroMovementController.Start')
- [HeroStagePortrait](#T-HeroStagePortrait 'HeroStagePortrait')
  - [Start()](#M-HeroStagePortrait-Start 'HeroStagePortrait.Start')
- [IdleMovementBehaviour](#T-IdleMovementBehaviour 'IdleMovementBehaviour')
  - [CalculateDesiredVelocity()](#M-IdleMovementBehaviour-CalculateDesiredVelocity 'IdleMovementBehaviour.CalculateDesiredVelocity')
  - [Steering()](#M-IdleMovementBehaviour-Steering 'IdleMovementBehaviour.Steering')
- [InventoryManager](#T-InventoryManager 'InventoryManager')
  - [#ctor(save)](#M-InventoryManager-#ctor-SaveGame- 'InventoryManager.#ctor(SaveGame)')
  - [AttackType](#P-InventoryManager-AttackType 'InventoryManager.AttackType')
  - [AttributeModifiers](#P-InventoryManager-AttributeModifiers 'InventoryManager.AttributeModifiers')
  - [MaxAssigned](#P-InventoryManager-MaxAssigned 'InventoryManager.MaxAssigned')
  - [MaxUnlocked](#P-InventoryManager-MaxUnlocked 'InventoryManager.MaxUnlocked')
  - [ResourcePath](#P-InventoryManager-ResourcePath 'InventoryManager.ResourcePath')
  - [AddAssigned(name,raiseChangeEvent)](#M-InventoryManager-AddAssigned-System-String,System-Boolean- 'InventoryManager.AddAssigned(System.String,System.Boolean)')
  - [Load(save)](#M-InventoryManager-Load-SaveGame- 'InventoryManager.Load(SaveGame)')
  - [Save(save)](#M-InventoryManager-Save-SaveGame@- 'InventoryManager.Save(SaveGame@)')
- [LevelUpgrades](#T-LevelUpgrades 'LevelUpgrades')
- [ListableEntity](#T-ListableEntity 'ListableEntity')
  - [Icon](#P-ListableEntity-Icon 'ListableEntity.Icon')
  - [ListableType](#P-ListableEntity-ListableType 'ListableEntity.ListableType')
- [ListableEntityType](#T-ListableEntityType 'ListableEntityType')
  - [Ability](#F-ListableEntityType-Ability 'ListableEntityType.Ability')
  - [Inventory](#F-ListableEntityType-Inventory 'ListableEntityType.Inventory')
  - [NonListable](#F-ListableEntityType-NonListable 'ListableEntityType.NonListable')
  - [Roster](#F-ListableEntityType-Roster 'ListableEntityType.Roster')
- [ListExtensions](#T-ListExtensions 'ListExtensions')
  - [ToDelimitedString(list,delimiter)](#M-ListExtensions-ToDelimitedString-System-Collections-Generic-List{System-String},System-String- 'ListExtensions.ToDelimitedString(System.Collections.Generic.List{System.String},System.String)')
- [LootCollection](#T-LootCollection 'LootCollection')
  - [DropEquipment](#P-LootCollection-DropEquipment 'LootCollection.DropEquipment')
  - [GetNextEquipment()](#M-LootCollection-GetNextEquipment 'LootCollection.GetNextEquipment')
- [MoveDirection](#T-MoveDirection 'MoveDirection')
  - [Left](#F-MoveDirection-Left 'MoveDirection.Left')
  - [Right](#F-MoveDirection-Right 'MoveDirection.Right')
- [MovementController](#T-MovementController 'MovementController')
  - [CurrentVelocity](#P-MovementController-CurrentVelocity 'MovementController.CurrentVelocity')
  - [MaxSpeed](#P-MovementController-MaxSpeed 'MovementController.MaxSpeed')
  - [SeekTargetDistance](#P-MovementController-SeekTargetDistance 'MovementController.SeekTargetDistance')
  - [SeekTargetDistanceSquared](#P-MovementController-SeekTargetDistanceSquared 'MovementController.SeekTargetDistanceSquared')
  - [ApplyForce(potency,position)](#M-MovementController-ApplyForce-System-Single,UnityEngine-Vector3- 'MovementController.ApplyForce(System.Single,UnityEngine.Vector3)')
  - [FixedUpdate()](#M-MovementController-FixedUpdate 'MovementController.FixedUpdate')
  - [GenerateFleeBehaviours()](#M-MovementController-GenerateFleeBehaviours 'MovementController.GenerateFleeBehaviours')
  - [GenerateMovementBehaviours()](#M-MovementController-GenerateMovementBehaviours 'MovementController.GenerateMovementBehaviours')
  - [GenerateSeekBehaviour()](#M-MovementController-GenerateSeekBehaviour 'MovementController.GenerateSeekBehaviour')
  - [Move()](#M-MovementController-Move 'MovementController.Move')
  - [Start()](#M-MovementController-Start 'MovementController.Start')
- [PopupBackButton](#T-PopupBackButton 'PopupBackButton')
  - [ClosePopup()](#M-PopupBackButton-ClosePopup 'PopupBackButton.ClosePopup')
  - [Start()](#M-PopupBackButton-Start 'PopupBackButton.Start')
- [Properties](#T-CustomGizmo-Properties 'CustomGizmo.Properties')
- [Queue](#T-Queue 'Queue')
  - [Enemies](#P-Queue-Enemies 'Queue.Enemies')
- [QueueController](#T-QueueController 'QueueController')
  - [IsRepeating](#P-QueueController-IsRepeating 'QueueController.IsRepeating')
  - [IsSpawning](#P-QueueController-IsSpawning 'QueueController.IsSpawning')
  - [SpawnNext()](#M-QueueController-SpawnNext 'QueueController.SpawnNext')
  - [Start()](#M-QueueController-Start 'QueueController.Start')
  - [Update()](#M-QueueController-Update 'QueueController.Update')
- [QueueManager](#T-QueueManager 'QueueManager')
  - [#ctor()](#M-QueueManager-#ctor 'QueueManager.#ctor')
  - [HasQueues](#P-QueueManager-HasQueues 'QueueManager.HasQueues')
  - [QueuesAreComplete](#P-QueueManager-QueuesAreComplete 'QueueManager.QueuesAreComplete')
  - [QueuesAreSpawning](#P-QueueManager-QueuesAreSpawning 'QueueManager.QueuesAreSpawning')
- [RandomLootCollection](#T-RandomLootCollection 'RandomLootCollection')
  - [DropEquipment](#P-RandomLootCollection-DropEquipment 'RandomLootCollection.DropEquipment')
  - [GetNextEquipment()](#M-RandomLootCollection-GetNextEquipment 'RandomLootCollection.GetNextEquipment')
- [RegisterList\`1](#T-RegisterList`1 'RegisterList`1')
  - [HasRegisteredEntities](#P-RegisterList`1-HasRegisteredEntities 'RegisterList`1.HasRegisteredEntities')
  - [AddAllToList(addToList)](#M-RegisterList`1-AddAllToList-System-Collections-Generic-List{`0}@- 'RegisterList`1.AddAllToList(System.Collections.Generic.List{`0}@)')
  - [GetAll()](#M-RegisterList`1-GetAll 'RegisterList`1.GetAll')
  - [Register(item)](#M-RegisterList`1-Register-`0- 'RegisterList`1.Register(`0)')
  - [RemoveAll(destroy)](#M-RegisterList`1-RemoveAll-System-Boolean- 'RegisterList`1.RemoveAll(System.Boolean)')
  - [Unregister(item)](#M-RegisterList`1-Unregister-`0- 'RegisterList`1.Unregister(`0)')
- [ResetButton](#T-ResetButton 'ResetButton')
  - [ResetGame()](#M-ResetButton-ResetGame 'ResetButton.ResetGame')
  - [Start()](#M-ResetButton-Start 'ResetButton.Start')
- [RosterManager](#T-RosterManager 'RosterManager')
  - [#ctor(save)](#M-RosterManager-#ctor-SaveGame- 'RosterManager.#ctor(SaveGame)')
  - [AllyLevels](#P-RosterManager-AllyLevels 'RosterManager.AllyLevels')
  - [MaxAssigned](#P-RosterManager-MaxAssigned 'RosterManager.MaxAssigned')
  - [MaxUnlocked](#P-RosterManager-MaxUnlocked 'RosterManager.MaxUnlocked')
  - [ResourcePath](#P-RosterManager-ResourcePath 'RosterManager.ResourcePath')
  - [TotalAssignedLevels](#P-RosterManager-TotalAssignedLevels 'RosterManager.TotalAssignedLevels')
  - [AddUnlocked(name,level,raiseChangeEvent)](#M-RosterManager-AddUnlocked-System-String,System-Int32,System-Boolean- 'RosterManager.AddUnlocked(System.String,System.Int32,System.Boolean)')
  - [Load(save)](#M-RosterManager-Load-SaveGame- 'RosterManager.Load(SaveGame)')
  - [RemoveUnlocked(name,raiseChangeEvent)](#M-RosterManager-RemoveUnlocked-System-String,System-Boolean- 'RosterManager.RemoveUnlocked(System.String,System.Boolean)')
  - [Save(save)](#M-RosterManager-Save-SaveGame@- 'RosterManager.Save(SaveGame@)')
- [SaveGame](#T-SaveGame 'SaveGame')
  - [#ctor()](#M-SaveGame-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'SaveGame.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
  - [GetObjectData()](#M-SaveGame-GetObjectData-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'SaveGame.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [SaveGameManager](#T-SaveGameManager 'SaveGameManager')
  - [SaveGameExists](#P-SaveGameManager-SaveGameExists 'SaveGameManager.SaveGameExists')
  - [SavePath](#P-SaveGameManager-SavePath 'SaveGameManager.SavePath')
  - [DeleteSaveGame()](#M-SaveGameManager-DeleteSaveGame 'SaveGameManager.DeleteSaveGame')
  - [LoadGame()](#M-SaveGameManager-LoadGame 'SaveGameManager.LoadGame')
  - [SaveGame(saveGame)](#M-SaveGameManager-SaveGame-SaveGame- 'SaveGameManager.SaveGame(SaveGame)')
- [SceneField](#T-SceneField 'SceneField')
- [SeekMovementBehaviour](#T-SeekMovementBehaviour 'SeekMovementBehaviour')
  - [#ctor(movementBehaviour,agent,target,radius)](#M-SeekMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'SeekMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.GameObject,System.Single)')
  - [CalculateDesiredVelocity()](#M-SeekMovementBehaviour-CalculateDesiredVelocity 'SeekMovementBehaviour.CalculateDesiredVelocity')
- [Singleton\`1](#T-Singleton`1 'Singleton`1')
  - [Instance](#P-Singleton`1-Instance 'Singleton`1.Instance')
- [StageButton](#T-StageButton 'StageButton')
  - [CenterIfLastStage()](#M-StageButton-CenterIfLastStage 'StageButton.CenterIfLastStage')
  - [LoadStage()](#M-StageButton-LoadStage 'StageButton.LoadStage')
  - [Start()](#M-StageButton-Start 'StageButton.Start')
- [StageCompletePopup](#T--StageCompletePopup '.StageCompletePopup')
  - [EndStage()](#M-StageCompletePopup-EndStage 'StageCompletePopup.EndStage')
  - [Start()](#M-StageCompletePopup-Start 'StageCompletePopup.Start')
- [StageManager](#T-StageManager 'StageManager')
  - [EndStage()](#M-StageManager-EndStage-System-Boolean- 'StageManager.EndStage(System.Boolean)')
  - [GetReward()](#M-StageManager-GetReward-UnityEngine-Vector2- 'StageManager.GetReward(UnityEngine.Vector2)')
  - [SpawnBoss()](#M-StageManager-SpawnBoss 'StageManager.SpawnBoss')
  - [SpawnBossAfterDelay()](#M-StageManager-SpawnBossAfterDelay 'StageManager.SpawnBossAfterDelay')
  - [Start()](#M-StageManager-Start 'StageManager.Start')
- [StaticLootCollection](#T-StaticLootCollection 'StaticLootCollection')
  - [DropEquipment](#P-StaticLootCollection-DropEquipment 'StaticLootCollection.DropEquipment')
  - [GetNextEquipment()](#M-StaticLootCollection-GetNextEquipment 'StaticLootCollection.GetNextEquipment')
- [UnlockedListChanged](#T-WorldEntityManager-UnlockedListChanged 'WorldEntityManager.UnlockedListChanged')
- [UpgradeAllyButton](#T-UpgradeAllyButton 'UpgradeAllyButton')
  - [Awake()](#M-UpgradeAllyButton-Awake 'UpgradeAllyButton.Awake')
  - [Initialize(allyName,list)](#M-UpgradeAllyButton-Initialize-System-String,UpgradeAllyPopup- 'UpgradeAllyButton.Initialize(System.String,UpgradeAllyPopup)')
  - [RefreshButton()](#M-UpgradeAllyButton-RefreshButton 'UpgradeAllyButton.RefreshButton')
  - [UpgradeAlly()](#M-UpgradeAllyButton-UpgradeAlly 'UpgradeAllyButton.UpgradeAlly')
- [UpgradeAllyPopup](#T-UpgradeAllyPopup 'UpgradeAllyPopup')
  - [RefreshButtons()](#M-UpgradeAllyPopup-RefreshButtons 'UpgradeAllyPopup.RefreshButtons')
  - [Start()](#M-UpgradeAllyPopup-Start 'UpgradeAllyPopup.Start')
- [UpgradeHeroPopup](#T-UpgradeHeroPopup 'UpgradeHeroPopup')
  - [RefreshHeroData()](#M-UpgradeHeroPopup-RefreshHeroData 'UpgradeHeroPopup.RefreshHeroData')
  - [Start()](#M-UpgradeHeroPopup-Start 'UpgradeHeroPopup.Start')
  - [UpgradeHero()](#M-UpgradeHeroPopup-UpgradeHero 'UpgradeHeroPopup.UpgradeHero')
- [Vector3Extensions](#T-Vector3Extensions 'Vector3Extensions')
  - [SqrDistance(source,destination)](#M-Vector3Extensions-SqrDistance-UnityEngine-Vector3,UnityEngine-Vector3- 'Vector3Extensions.SqrDistance(UnityEngine.Vector3,UnityEngine.Vector3)')
- [WalkMovementBehaviour](#T-WalkMovementBehaviour 'WalkMovementBehaviour')
  - [#ctor(movementBehaviour,agent,location)](#M-WalkMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single- 'WalkMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.Vector2,System.Single)')
  - [location](#F-WalkMovementBehaviour-location 'WalkMovementBehaviour.location')
  - [CalculateDesiredVelocity()](#M-WalkMovementBehaviour-CalculateDesiredVelocity 'WalkMovementBehaviour.CalculateDesiredVelocity')
- [WanderMovementBehaviour](#T-WanderMovementBehaviour 'WanderMovementBehaviour')
  - [#ctor(movementBehaviour,agent,location,radius)](#M-WanderMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single- 'WanderMovementBehaviour.#ctor(AbstractMovementBehaviour,UnityEngine.GameObject,UnityEngine.Vector2,System.Single)')
  - [CalculateDesiredVelocity()](#M-WanderMovementBehaviour-CalculateDesiredVelocity 'WanderMovementBehaviour.CalculateDesiredVelocity')
- [WorldEntityButton](#T-WorldEntityButton 'WorldEntityButton')
  - [Awake()](#M-WorldEntityButton-Awake 'WorldEntityButton.Awake')
  - [HandleAssignClick()](#M-WorldEntityButton-HandleAssignClick 'WorldEntityButton.HandleAssignClick')
  - [HandleClick()](#M-WorldEntityButton-HandleClick 'WorldEntityButton.HandleClick')
  - [HandleUseClick()](#M-WorldEntityButton-HandleUseClick 'WorldEntityButton.HandleUseClick')
  - [Initialize(entityName,buttonAction,manager)](#M-WorldEntityButton-Initialize-System-String,ButtonAction,WorldEntityManager- 'WorldEntityButton.Initialize(System.String,ButtonAction,WorldEntityManager)')
  - [Update()](#M-WorldEntityButton-Update 'WorldEntityButton.Update')
- [WorldEntityList](#T-WorldEntityList 'WorldEntityList')
  - [AddButtons()](#M-WorldEntityList-AddButtons 'WorldEntityList.AddButtons')
  - [OnDestroy()](#M-WorldEntityList-OnDestroy 'WorldEntityList.OnDestroy')
  - [RefreshDisplay()](#M-WorldEntityList-RefreshDisplay 'WorldEntityList.RefreshDisplay')
  - [RemoveButtons()](#M-WorldEntityList-RemoveButtons 'WorldEntityList.RemoveButtons')
  - [Start()](#M-WorldEntityList-Start 'WorldEntityList.Start')
- [WorldEntityManager](#T-WorldEntityManager 'WorldEntityManager')
  - [#ctor(save)](#M-WorldEntityManager-#ctor-SaveGame- 'WorldEntityManager.#ctor(SaveGame)')
  - [Assigned](#P-WorldEntityManager-Assigned 'WorldEntityManager.Assigned')
  - [MaxAssigned](#P-WorldEntityManager-MaxAssigned 'WorldEntityManager.MaxAssigned')
  - [MaxUnlocked](#P-WorldEntityManager-MaxUnlocked 'WorldEntityManager.MaxUnlocked')
  - [ResourcePath](#P-WorldEntityManager-ResourcePath 'WorldEntityManager.ResourcePath')
  - [Unlocked](#P-WorldEntityManager-Unlocked 'WorldEntityManager.Unlocked')
  - [AddAssigned(name,raiseChangeEvent)](#M-WorldEntityManager-AddAssigned-System-String,System-Boolean- 'WorldEntityManager.AddAssigned(System.String,System.Boolean)')
  - [AddUnlocked(name,raiseChangeEvent)](#M-WorldEntityManager-AddUnlocked-System-String,System-Boolean- 'WorldEntityManager.AddUnlocked(System.String,System.Boolean)')
  - [GetEntityObject(name)](#M-WorldEntityManager-GetEntityObject-System-String- 'WorldEntityManager.GetEntityObject(System.String)')
  - [Load(save)](#M-WorldEntityManager-Load-SaveGame- 'WorldEntityManager.Load(SaveGame)')
  - [RaiseChangeEvent(type)](#M-WorldEntityManager-RaiseChangeEvent-WorldEntityListType- 'WorldEntityManager.RaiseChangeEvent(WorldEntityListType)')
  - [RemoveAssigned(name,raiseChangeEvent)](#M-WorldEntityManager-RemoveAssigned-System-String,System-Boolean- 'WorldEntityManager.RemoveAssigned(System.String,System.Boolean)')
  - [RemoveUnlocked(name,raiseChangeEvent)](#M-WorldEntityManager-RemoveUnlocked-System-String,System-Boolean- 'WorldEntityManager.RemoveUnlocked(System.String,System.Boolean)')
  - [Save(save)](#M-WorldEntityManager-Save-SaveGame@- 'WorldEntityManager.Save(SaveGame@)')
- [WorldManager](#T-WorldManager 'WorldManager')
  - [#ctor(save)](#M-WorldManager-#ctor-SaveGame- 'WorldManager.#ctor(SaveGame)')
  - [LastIdleFactor](#P-WorldManager-LastIdleFactor 'WorldManager.LastIdleFactor')
  - [LastStage](#P-WorldManager-LastStage 'WorldManager.LastStage')
  - [LastZone](#P-WorldManager-LastZone 'WorldManager.LastZone')
  - [UnlockedStages](#P-WorldManager-UnlockedStages 'WorldManager.UnlockedStages')
  - [UnlockedZones](#P-WorldManager-UnlockedZones 'WorldManager.UnlockedZones')
  - [Save(save)](#M-WorldManager-Save-SaveGame@- 'WorldManager.Save(SaveGame@)')
  - [SetIdleFactor(idleRewardsFactor)](#M-WorldManager-SetIdleFactor-System-Single- 'WorldManager.SetIdleFactor(System.Single)')
  - [SetLastStage(stage)](#M-WorldManager-SetLastStage-System-String- 'WorldManager.SetLastStage(System.String)')
  - [SetLastZone(zone)](#M-WorldManager-SetLastZone-System-String- 'WorldManager.SetLastZone(System.String)')
  - [UnlockStage(stage)](#M-WorldManager-UnlockStage-System-String- 'WorldManager.UnlockStage(System.String)')
  - [UnlockZone(zone)](#M-WorldManager-UnlockZone-System-String- 'WorldManager.UnlockZone(System.String)')
- [ZoneButton](#T-ZoneButton 'ZoneButton')
  - [CenterIfLastZone()](#M-ZoneButton-CenterIfLastZone 'ZoneButton.CenterIfLastZone')
  - [LoadZone()](#M-ZoneButton-LoadZone 'ZoneButton.LoadZone')
  - [Start()](#M-ZoneButton-Start 'ZoneButton.Start')

<a name='assembly'></a>
# Assembly-CSharp [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Ability'></a>
## Ability [#](#T-Ability 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents an ability.

<a name='P-Ability-AbilityRange'></a>
### AbilityRange `property` [#](#P-Ability-AbilityRange 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Range type of the ability.

<a name='P-Ability-AbilityType'></a>
### AbilityType `property` [#](#P-Ability-AbilityType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of the ability.

<a name='P-Ability-Cooldown'></a>
### Cooldown `property` [#](#P-Ability-Cooldown 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Cooldown of the ability in seconds.

<a name='P-Ability-Effect'></a>
### Effect `property` [#](#P-Ability-Effect 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Visual effect for the ability.

<a name='P-Ability-EnergyCost'></a>
### EnergyCost `property` [#](#P-Ability-EnergyCost 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Energy cost.

<a name='P-Ability-ListableType'></a>
### ListableType `property` [#](#P-Ability-ListableType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of lists this ability belongs to.

<a name='P-Ability-Potency'></a>
### Potency `property` [#](#P-Ability-Potency 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Potency of the ability.

<a name='T-AbilityManager'></a>
## AbilityManager [#](#T-AbilityManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages abilities; maintains which abilities are unlocked, assigned, and provides access to the ability objects by name.

<a name='M-AbilityManager-#ctor-SaveGame-'></a>
### #ctor(save) `constructor` [#](#M-AbilityManager-#ctor-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the ability manager from a saved game.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The saved game data. |

<a name='P-AbilityManager-MaxAssigned'></a>
### MaxAssigned `property` [#](#P-AbilityManager-MaxAssigned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of assigned abilities.

<a name='P-AbilityManager-MaxUnlocked'></a>
### MaxUnlocked `property` [#](#P-AbilityManager-MaxUnlocked 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of unlocked abilities.

<a name='P-AbilityManager-ResourcePath'></a>
### ResourcePath `property` [#](#P-AbilityManager-ResourcePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the resource path of the abilities.

<a name='M-AbilityManager-Load-SaveGame-'></a>
### Load(save) `method` [#](#M-AbilityManager-Load-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the data from a saved game.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The saved game data. |

<a name='M-AbilityManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-AbilityManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Fills a save game with ability data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='T-AbilityRange'></a>
## AbilityRange [#](#T-AbilityRange 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

The range of an ability.

<a name='F-AbilityRange-Melee'></a>
### Melee `constants` [#](#F-AbilityRange-Melee 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Affects a target within melee range.

<a name='F-AbilityRange-Ranged'></a>
### Ranged `constants` [#](#F-AbilityRange-Ranged 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Affects a target at a distance.

<a name='F-AbilityRange-Self'></a>
### Self `constants` [#](#F-AbilityRange-Self 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Affects the self.

<a name='T-AbilityType'></a>
## AbilityType [#](#T-AbilityType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Type of ability.

<a name='F-AbilityType-Area'></a>
### Area `constants` [#](#F-AbilityType-Area 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damages an area around a target.

<a name='F-AbilityType-Direct'></a>
### Direct `constants` [#](#F-AbilityType-Direct 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damages a single target.

<a name='F-AbilityType-Heal'></a>
### Heal `constants` [#](#F-AbilityType-Heal 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Heals a target's damage.

<a name='F-AbilityType-Shield'></a>
### Shield `constants` [#](#F-AbilityType-Shield 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Shields a target from damage.

<a name='T-AbstractMovementBehaviour'></a>
## AbstractMovementBehaviour [#](#T-AbstractMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

A movement behaviour describes the steering necessary to accomplish a desire. This AbstractMovementBehaviour is the root of the decorator pattern used for this movement system.

<a name='M-AbstractMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-AbstractMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='M-AbstractMovementBehaviour-Steering'></a>
### Steering() `method` [#](#M-AbstractMovementBehaviour-Steering 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The steering vector desired by this movement behaviour.

##### Returns

The optimal steering vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-AbstractMovementDecorator'></a>
## AbstractMovementDecorator [#](#T-AbstractMovementDecorator 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Movement behaviours that can be wrapped around other movement behaviours to add additional movement desires.

<a name='M-AbstractMovementDecorator-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single-'></a>
### #ctor(movementBehaviour,agent,target) `constructor` [#](#M-AbstractMovementDecorator-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Base constructor for movement decorators.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| target | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The target of this movement behaviour. |

<a name='F-AbstractMovementDecorator-agent'></a>
### agent `constants` [#](#F-AbstractMovementDecorator-agent 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

GameObject that desires this movement behaviour.

<a name='F-AbstractMovementDecorator-controller'></a>
### controller `constants` [#](#F-AbstractMovementDecorator-controller 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Agent's movement controller.

<a name='F-AbstractMovementDecorator-maxAccel'></a>
### maxAccel `constants` [#](#F-AbstractMovementDecorator-maxAccel 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Maximum change in speed per second.

<a name='F-AbstractMovementDecorator-maxSpeed'></a>
### maxSpeed `constants` [#](#F-AbstractMovementDecorator-maxSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Maximum number of Unity units moved per second.

<a name='F-AbstractMovementDecorator-movementBehaviour'></a>
### movementBehaviour `constants` [#](#F-AbstractMovementDecorator-movementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Movement behaviour that will be decorated by this movement behaviour.

<a name='F-AbstractMovementDecorator-radius'></a>
### radius `constants` [#](#F-AbstractMovementDecorator-radius 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The radius at which the behaviour is considered completed.

<a name='F-AbstractMovementDecorator-target'></a>
### target `constants` [#](#F-AbstractMovementDecorator-target 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Target of this movement behaviour.

<a name='M-AbstractMovementDecorator-Steering'></a>
### Steering() `method` [#](#M-AbstractMovementDecorator-Steering 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The steering vector desired by the movement behaviours.

##### Returns

The optimal steering vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-Ally'></a>
## Ally [#](#T-Ally 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents an ally.

<a name='P-Ally-CharacterType'></a>
### CharacterType `property` [#](#P-Ally-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The character type of the ally.

<a name='P-Ally-Lesson'></a>
### Lesson `property` [#](#P-Ally-Lesson 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The lesson taught by the ally; i.e. the ability gained when unlocking ally.

<a name='P-Ally-LevelUpgrades'></a>
### LevelUpgrades `property` [#](#P-Ally-LevelUpgrades 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The attributes that are upgraded when leveling up the ally.

<a name='P-Ally-ListableType'></a>
### ListableType `property` [#](#P-Ally-ListableType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of lists this ally belongs to.

<a name='T-AllyController'></a>
## AllyController [#](#T-AllyController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the Ally GameObject.

<a name='P-AllyController-AllyObject'></a>
### AllyObject `property` [#](#P-AllyController-AllyObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the ScriptableObject that represents the Ally.

<a name='P-AllyController-AttackType'></a>
### AttackType `property` [#](#P-AllyController-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the AttackType of the Ally.

<a name='P-AllyController-CharacterType'></a>
### CharacterType `property` [#](#P-AllyController-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the CharacterType of the Ally.

<a name='P-AllyController-Level'></a>
### Level `property` [#](#P-AllyController-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Level of the ally.

<a name='M-AllyController-CreateDerivedAttributes'></a>
### CreateDerivedAttributes() `method` [#](#M-AllyController-CreateDerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the derived attributes for the ally.

##### Parameters

This method has no parameters.

<a name='M-AllyController-Register'></a>
### Register() `method` [#](#M-AllyController-Register 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers this Ally with the AllyManager.

##### Parameters

This method has no parameters.

<a name='M-AllyController-Start'></a>
### Start() `method` [#](#M-AllyController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the ally controller.

##### Parameters

This method has no parameters.

<a name='M-AllyController-Unregister'></a>
### Unregister() `method` [#](#M-AllyController-Unregister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unregisters this Ally from the AllyManager.

##### Parameters

This method has no parameters.

<a name='T-AllyManager'></a>
## AllyManager [#](#T-AllyManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the allies on a stage.

<a name='T-WorldEntityManager-AssignedListChanged'></a>
## AssignedListChanged [#](#T-WorldEntityManager-AssignedListChanged 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

WorldEntityManager

##### Summary

Assigned list change delegate signature.

<a name='T-AttackType'></a>
## AttackType [#](#T-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Basic attack type.

<a name='F-AttackType-Caster'></a>
### Caster `constants` [#](#F-AttackType-Caster 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Shoots a caster ball at a target.

<a name='F-AttackType-Melee'></a>
### Melee `constants` [#](#F-AttackType-Melee 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damages a close target.

<a name='F-AttackType-Ranged'></a>
### Ranged `constants` [#](#F-AttackType-Ranged 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Shoots an arrow at a target.

<a name='T-AvoidMovementBehaviour'></a>
## AvoidMovementBehaviour [#](#T-AvoidMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to avoid obstacles and other characters.

<a name='M-AvoidMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single-'></a>
### #ctor(movementBehaviour,agent,target,radius) `constructor` [#](#M-AvoidMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for AvoidMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| target | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The target of this movement behaviour. |
| radius | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The radius at which this behaviour is completed. |

<a name='T-BackToWorldButton'></a>
## BackToWorldButton [#](#T-BackToWorldButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Processes clocks on the back to world button.

<a name='M-BackToWorldButton-LoadWorld'></a>
### LoadWorld() `method` [#](#M-BackToWorldButton-LoadWorld 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the world scene when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-BackToWorldButton-Start'></a>
### Start() `method` [#](#M-BackToWorldButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the back to world button.

##### Parameters

This method has no parameters.

<a name='T-BaseAttributes'></a>
## BaseAttributes [#](#T-BaseAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Contains unscaled attributes for a character.

<a name='P-BaseAttributes-AbilityDamage'></a>
### AbilityDamage `property` [#](#P-BaseAttributes-AbilityDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage done with caster basic attack.

<a name='P-BaseAttributes-AttackDamage'></a>
### AttackDamage `property` [#](#P-BaseAttributes-AttackDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage done with basic attack.

<a name='P-BaseAttributes-AttackSpeed'></a>
### AttackSpeed `property` [#](#P-BaseAttributes-AttackSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Attacks per second.

<a name='P-BaseAttributes-CooldownReduction'></a>
### CooldownReduction `property` [#](#P-BaseAttributes-CooldownReduction 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Reduction is ability cooldowns.

<a name='P-BaseAttributes-CriticalHitChance'></a>
### CriticalHitChance `property` [#](#P-BaseAttributes-CriticalHitChance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Chance for a critical strike.

<a name='P-BaseAttributes-CriticalHitDamage'></a>
### CriticalHitDamage `property` [#](#P-BaseAttributes-CriticalHitDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Extra damage on critical hits.

<a name='P-BaseAttributes-Defense'></a>
### Defense `property` [#](#P-BaseAttributes-Defense 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage resisted from basic attacks.

<a name='P-BaseAttributes-Energy'></a>
### Energy `property` [#](#P-BaseAttributes-Energy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Energy points used for abilities.

<a name='P-BaseAttributes-EnergyRegeneration'></a>
### EnergyRegeneration `property` [#](#P-BaseAttributes-EnergyRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Energy points regnerated per second.

<a name='P-BaseAttributes-Health'></a>
### Health `property` [#](#P-BaseAttributes-Health 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Health points until death.

<a name='P-BaseAttributes-HealthRegeneration'></a>
### HealthRegeneration `property` [#](#P-BaseAttributes-HealthRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Health points regenerated per second.

<a name='P-BaseAttributes-LifeDrain'></a>
### LifeDrain `property` [#](#P-BaseAttributes-LifeDrain 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Health points regained based on damage.

<a name='P-BaseAttributes-MovementSpeed'></a>
### MovementSpeed `property` [#](#P-BaseAttributes-MovementSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Units moved per second.

<a name='M-BaseAttributes-op_Addition-BaseAttributes,BaseAttributes-'></a>
### op_Addition(attributesA,attributesB) `method` [#](#M-BaseAttributes-op_Addition-BaseAttributes,BaseAttributes- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds two BaseAttributes together and returns a new one.

##### Returns

BaseAttributes containing the sum of attributesA and attributesB.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| attributesA | [BaseAttributes](#T-BaseAttributes 'BaseAttributes') | BaseAttributes to add to. |
| attributesB | [BaseAttributes](#T-BaseAttributes 'BaseAttributes') | BaseAttributes to add from. |

<a name='T-BossManager'></a>
## BossManager [#](#T-BossManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the bosses on a stage.

<a name='T-ButtonAction'></a>
## ButtonAction [#](#T-ButtonAction 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Action taken when entity button is clicked.

<a name='F-ButtonAction-Assign'></a>
### Assign `constants` [#](#F-ButtonAction-Assign 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assigns or unassigns the entity.

<a name='F-ButtonAction-None'></a>
### None `constants` [#](#F-ButtonAction-None 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

No action taken.

<a name='F-ButtonAction-Use'></a>
### Use `constants` [#](#F-ButtonAction-Use 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Uses the entity.

<a name='T-Character'></a>
## Character [#](#T-Character 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a character.

<a name='P-Character-Animator'></a>
### Animator `property` [#](#P-Character-Animator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The animator controller for the character.

<a name='P-Character-AttackType'></a>
### AttackType `property` [#](#P-Character-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Attack type of the character.

<a name='P-Character-BaseAttributes'></a>
### BaseAttributes `property` [#](#P-Character-BaseAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Base attributes of the character.

<a name='P-Character-BonusAttributes'></a>
### BonusAttributes `property` [#](#P-Character-BonusAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Bonus attributes of the character.

<a name='P-Character-CharacterType'></a>
### CharacterType `property` [#](#P-Character-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of the character.

<a name='P-Character-Level'></a>
### Level `property` [#](#P-Character-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The level of the character.

<a name='T-GameCharacterController-CharacterDirectionChanged'></a>
## CharacterDirectionChanged [#](#T-GameCharacterController-CharacterDirectionChanged 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

GameCharacterController

##### Summary

Character direction change delegate signature.

<a name='T-CharacterManager'></a>
## CharacterManager [#](#T-CharacterManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the characters on a stage.

<a name='T-CharacterState'></a>
## CharacterState [#](#T-CharacterState 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the current state of a character.

<a name='F-CharacterState-Cast'></a>
### Cast `constants` [#](#F-CharacterState-Cast 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is performing caster basic attacks.

<a name='F-CharacterState-Dead'></a>
### Dead `constants` [#](#F-CharacterState-Dead 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is dead.

<a name='F-CharacterState-Defend'></a>
### Defend `constants` [#](#F-CharacterState-Defend 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is defending.

<a name='F-CharacterState-Idle'></a>
### Idle `constants` [#](#F-CharacterState-Idle 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is idle.

<a name='F-CharacterState-Melee'></a>
### Melee `constants` [#](#F-CharacterState-Melee 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is performing melee basic attacks.

<a name='F-CharacterState-Ranged'></a>
### Ranged `constants` [#](#F-CharacterState-Ranged 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is performing ranged basic attacks.

<a name='F-CharacterState-Walk'></a>
### Walk `constants` [#](#F-CharacterState-Walk 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character is walking.

<a name='T-GameCharacterController-CharacterStateChanged'></a>
## CharacterStateChanged [#](#T-GameCharacterController-CharacterStateChanged 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

GameCharacterController

##### Summary

Character state change delegate signature.

<a name='T-CharacterType'></a>
## CharacterType [#](#T-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the type of a character.

<a name='F-CharacterType-Ally'></a>
### Ally `constants` [#](#F-CharacterType-Ally 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

An ally of the hero.

<a name='F-CharacterType-Boss'></a>
### Boss `constants` [#](#F-CharacterType-Boss 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A boss enemy of the hero.

<a name='F-CharacterType-Enemy'></a>
### Enemy `constants` [#](#F-CharacterType-Enemy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

An enemy of the hero.

<a name='F-CharacterType-Hero'></a>
### Hero `constants` [#](#F-CharacterType-Hero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The hero.

<a name='F-CharacterType-None'></a>
### None `constants` [#](#F-CharacterType-None 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Not a valid character type.

<a name='T-CombatController'></a>
## CombatController [#](#T-CombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the combat for a character.

<a name='P-CombatController-CanAttack'></a>
### CanAttack `property` [#](#P-CombatController-CanAttack 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not the character can attack.

<a name='P-CombatController-CharacterController'></a>
### CharacterController `property` [#](#P-CombatController-CharacterController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The character this combat controller belongs to.

<a name='P-CombatController-CurrentEnergy'></a>
### CurrentEnergy `property` [#](#P-CombatController-CurrentEnergy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the character's current energy.

<a name='P-CombatController-CurrentHealth'></a>
### CurrentHealth `property` [#](#P-CombatController-CurrentHealth 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the character's current health.

<a name='P-CombatController-DesiredCombatRange'></a>
### DesiredCombatRange `property` [#](#P-CombatController-DesiredCombatRange 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the desired combat range based on attack type.

<a name='P-CombatController-HasHostileTarget'></a>
### HasHostileTarget `property` [#](#P-CombatController-HasHostileTarget 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not the target is hostile.

<a name='P-CombatController-HasTargetInRange'></a>
### HasTargetInRange `property` [#](#P-CombatController-HasTargetInRange 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the target is within the desired combat range.

<a name='P-CombatController-IsStunned'></a>
### IsStunned `property` [#](#P-CombatController-IsStunned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not the character is stunned.

<a name='P-CombatController-IsTimeToAttack'></a>
### IsTimeToAttack `property` [#](#P-CombatController-IsTimeToAttack 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the character's attack speed allows them to attack.

<a name='M-CombatController-ApplyDamage-System-Int32,System-Boolean-'></a>
### ApplyDamage(damage,isCritical) `method` [#](#M-CombatController-ApplyDamage-System-Int32,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies damage to the character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| damage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Amount of damage to apply. |
| isCritical | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not damage has critical damage included. |

<a name='M-CombatController-ApplyExperience'></a>
### ApplyExperience() `method` [#](#M-CombatController-ApplyExperience 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Apply experience to the hero for this character's death.

##### Parameters

This method has no parameters.

<a name='M-CombatController-ApplyReward'></a>
### ApplyReward() `method` [#](#M-CombatController-ApplyReward 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Apply rewards to the hero for this character's death.

##### Parameters

This method has no parameters.

<a name='M-CombatController-ApplyStun-System-Single-'></a>
### ApplyStun(duration) `method` [#](#M-CombatController-ApplyStun-System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies a stun to the character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| duration | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Duration of stun in seconds. |

<a name='M-CombatController-CriticalModifier'></a>
### CriticalModifier() `method` [#](#M-CombatController-CriticalModifier 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines the critical modifier of an attack. The default value is 1.0 or 100% normal damage, which is equivalent to no critical hit.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-CombatController-Despawn'></a>
### Despawn() `method` [#](#M-CombatController-Despawn 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Despawns the character. Used to invoke after a delay.

##### Parameters

This method has no parameters.

<a name='M-CombatController-FaceTarget'></a>
### FaceTarget() `method` [#](#M-CombatController-FaceTarget 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Changes character animation to face the direction of the target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-GetClosestHostile-System-Collections-Generic-List{GameCharacterController}-'></a>
### GetClosestHostile(hostiles) `method` [#](#M-CombatController-GetClosestHostile-System-Collections-Generic-List{GameCharacterController}- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the closest hostile from a list of characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostiles | [System.Collections.Generic.List{GameCharacterController}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{GameCharacterController}') | List of hostile characters. |

<a name='M-CombatController-PerformCasterAttack'></a>
### PerformCasterAttack() `method` [#](#M-CombatController-PerformCasterAttack 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a caster attack on the current target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-PerformCombatRound'></a>
### PerformCombatRound() `method` [#](#M-CombatController-PerformCombatRound 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a combat round.

##### Parameters

This method has no parameters.

<a name='M-CombatController-PerformLifeDrain-System-Int32-'></a>
### PerformLifeDrain(damage) `method` [#](#M-CombatController-PerformLifeDrain-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs life steal based on the character attribute and the damage done.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| damage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Damage to life steal from. |

<a name='M-CombatController-PerformMeleeAttack'></a>
### PerformMeleeAttack() `method` [#](#M-CombatController-PerformMeleeAttack 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a melee attack on the current target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-PerformRangedAttack'></a>
### PerformRangedAttack() `method` [#](#M-CombatController-PerformRangedAttack 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a ranged attack on the current target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-SpawnArrow'></a>
### SpawnArrow() `method` [#](#M-CombatController-SpawnArrow 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns an arrow projectile that targets the current target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-SpawnCasterball'></a>
### SpawnCasterball() `method` [#](#M-CombatController-SpawnCasterball 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns a caster ball projectile that targets the currrent target.

##### Parameters

This method has no parameters.

<a name='M-CombatController-SpawnProjectile-UnityEngine-GameObject,UnityEngine-Vector3,System-Int32,GameCharacterController,System-Single-'></a>
### SpawnProjectile(prefab,location,damage,target,criticalModifier) `method` [#](#M-CombatController-SpawnProjectile-UnityEngine-GameObject,UnityEngine-Vector3,System-Int32,GameCharacterController,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns a projectile that travels to and strikes the target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prefab | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The projectile to spawn. |
| location | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The location to spawn the projectile. |
| damage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The damage the projectile will do upon contact. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the projectile. |
| criticalModifier | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The critical modifier of the projectile's damage. |

<a name='M-CombatController-Start'></a>
### Start() `method` [#](#M-CombatController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the combat controller.

##### Parameters

This method has no parameters.

<a name='M-CombatController-Update'></a>
### Update() `method` [#](#M-CombatController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the combat controller every frame.

##### Parameters

This method has no parameters.

<a name='M-CombatController-UpdateRegeneration'></a>
### UpdateRegeneration() `method` [#](#M-CombatController-UpdateRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the health and energy based on regeneration rates.

##### Parameters

This method has no parameters.

<a name='M-CombatController-UpdateStun'></a>
### UpdateStun() `method` [#](#M-CombatController-UpdateStun 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes stun from character after duration.

##### Parameters

This method has no parameters.

<a name='M-CombatController-UpdateTarget'></a>
### UpdateTarget() `method` [#](#M-CombatController-UpdateTarget 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Finds an appropriate target for the character if one exists on the stage.

##### Parameters

This method has no parameters.

<a name='T-CombatTextController'></a>
## CombatTextController [#](#T-CombatTextController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Displays combat text in a manner that slowly floats up and fades out.

<a name='P-CombatTextController-Color'></a>
### Color `property` [#](#P-CombatTextController-Color 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The color of the floating combat text.

<a name='P-CombatTextController-Text'></a>
### Text `property` [#](#P-CombatTextController-Text 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The text displayed in the floating combat text.

<a name='M-CombatTextController-Animate-UnityEngine-Vector3,UnityEngine-Vector3-'></a>
### Animate(startPosition,endPosition) `method` [#](#M-CombatTextController-Animate-UnityEngine-Vector3,UnityEngine-Vector3- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Animates the combat text from start position to end position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startPosition | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') |  |
| endPosition | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') |  |

<a name='M-CombatTextController-Start'></a>
### Start() `method` [#](#M-CombatTextController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the floating combat text.

##### Parameters

This method has no parameters.

<a name='T-ConditionalDebug'></a>
## ConditionalDebug [#](#T-ConditionalDebug 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Class containing methods to ease debugging while developing a game.

##### Example

You must include this class in order to override the standard Unity Debug class.

```
using Debug = ConditionalDebug;
```

Then you can use it exactly as if it was the standard Unity Debug class. https://docs.unity3d.com/ScriptReference/Debug.html

##### Remarks

This is a custom wrapper that allows for the conditional execution of Debug commands.

<a name='M-ConditionalDebug-Assert-System-Boolean-'></a>
### Assert(condition) `method` [#](#M-ConditionalDebug-Assert-System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs an error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-Assert-System-Boolean,UnityEngine-Object-'></a>
### Assert(condition,context) `method` [#](#M-ConditionalDebug-Assert-System-Boolean,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs an error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Condition you expect to be true. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-Assert-System-Boolean,System-Object-'></a>
### Assert(condition,message) `method` [#](#M-ConditionalDebug-Assert-System-Boolean,System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs an error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Condition you expect to be true. |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-Assert-System-Boolean,System-Object,UnityEngine-Object-'></a>
### Assert(condition,message,context) `method` [#](#M-ConditionalDebug-Assert-System-Boolean,System-Object,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs an error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Condition you expect to be true. |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-AssertFormat-System-Boolean,System-String,System-Object[]-'></a>
### AssertFormat(condition,format,args) `method` [#](#M-ConditionalDebug-AssertFormat-System-Boolean,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs a formatted error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Condition you expect to be true. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

<a name='M-ConditionalDebug-AssertFormat-System-Boolean,UnityEngine-Object,System-String,System-Object[]-'></a>
### AssertFormat(condition,context,format,args) `method` [#](#M-ConditionalDebug-AssertFormat-System-Boolean,UnityEngine-Object,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assert a condition and logs a formatted error message to the Unity console on failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Condition you expect to be true. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

<a name='M-ConditionalDebug-Break'></a>
### Break() `method` [#](#M-ConditionalDebug-Break 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Pauses the editor.

##### Parameters

This method has no parameters.

##### Remarks

This is useful when you want to check certain values on the inspector and you are not able to pause it manually.

<a name='M-ConditionalDebug-ClearDeveloperConsole'></a>
### ClearDeveloperConsole() `method` [#](#M-ConditionalDebug-ClearDeveloperConsole 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Clears errors from the developer console.

##### Parameters

This method has no parameters.

<a name='M-ConditionalDebug-DrawLine-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean-'></a>
### DrawLine(start,end,color,duration,depthTest) `method` [#](#M-ConditionalDebug-DrawLine-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Draws a line between specified start and end points.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | Point in world space where the line should start. |
| end | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | Point in world space where the line should end. |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | Color of the line. |
| duration | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | How long the line should be visible for. |
| depthTest | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the line be obscured by objects closer to the camera? |

##### Remarks

The line will be drawn in the scene view of the editor. If gizmo drawing is enabled in the game view, the line will also be drawn there. The duration is the time (in seconds) for which the line will be visible after it is first displayed. A duration of zero shows the line for just one frame. Note: This is for debugging playmode only. Editor gizmos should be drawn with Gizmos.Drawline or Handles.DrawLine instead.

<a name='M-ConditionalDebug-DrawRay-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean-'></a>
### DrawRay(start,dir,color,duration,depthTest) `method` [#](#M-ConditionalDebug-DrawRay-UnityEngine-Vector3,UnityEngine-Vector3,UnityEngine-Color,System-Single,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Draws a line from start to start + dir in world coordinates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | Point in world space where the ray should start. |
| dir | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | Direction and length of the ray. |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | Color of the drawn line. |
| duration | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | How long the line will be visible for (in seconds). |
| depthTest | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Should the line be obscured by other objects closer to the camera? |

##### Remarks

The duration parameter determines how long the line will be visible after the frame it is drawn. If duration is 0 (the default) then the line is rendered 1 frame. If depthTest is set to true then the line will be obscured by other objects in the scene that are nearer to the camera. The line will be drawn in the scene view of the editor. If gizmo drawing is enabled in the game view, the line will also be drawn there.

<a name='M-ConditionalDebug-Log-System-Object-'></a>
### Log(message) `method` [#](#M-ConditionalDebug-Log-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This can be useful for locating the object on which an error occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-Log-System-Object,UnityEngine-Object-'></a>
### Log(message,context) `method` [#](#M-ConditionalDebug-Log-System-Object,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This can be useful for locating the object on which an error occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogAssertion-System-Object-'></a>
### LogAssertion(message) `method` [#](#M-ConditionalDebug-LogAssertion-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an assertion message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-LogAssertion-System-Object,UnityEngine-Object-'></a>
### LogAssertion(message,context) `method` [#](#M-ConditionalDebug-LogAssertion-System-Object,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an assertion message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

Message of a type of LogType.Assert is logged.

<a name='M-ConditionalDebug-LogAssertionFormat-System-String,System-Object[]-'></a>
### LogAssertionFormat(format,args) `method` [#](#M-ConditionalDebug-LogAssertionFormat-System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted assertion message to the Unity console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

<a name='M-ConditionalDebug-LogAssertionFormat-UnityEngine-Object,System-String,System-Object[]-'></a>
### LogAssertionFormat(context,format,args) `method` [#](#M-ConditionalDebug-LogAssertionFormat-UnityEngine-Object,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted assertion message to the Unity console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

<a name='M-ConditionalDebug-LogError-System-Object-'></a>
### LogError(message) `method` [#](#M-ConditionalDebug-LogError-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an error message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object an error occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available. Note that this pauses the editor when 'ErrorPause' is enabled.

<a name='M-ConditionalDebug-LogError-System-Object,UnityEngine-Object-'></a>
### LogError(message,context) `method` [#](#M-ConditionalDebug-LogError-System-Object,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an error message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object an error occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available. Note that this pauses the editor when 'ErrorPause' is enabled.

<a name='M-ConditionalDebug-LogErrorFormat-System-String,System-Object[]-'></a>
### LogErrorFormat(format,args) `method` [#](#M-ConditionalDebug-LogErrorFormat-System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted error message to the Unity console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogErrorFormat-UnityEngine-Object,System-String,System-Object[]-'></a>
### LogErrorFormat(context,format,args) `method` [#](#M-ConditionalDebug-LogErrorFormat-UnityEngine-Object,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted error message to the Unity console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogException-System-Exception-'></a>
### LogException(exception) `method` [#](#M-ConditionalDebug-LogException-System-Exception- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an error message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Runtime Exception. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object an error occurs. Note that this pauses the editor when 'ErrorPause' is enabled.

<a name='M-ConditionalDebug-LogException-System-Exception,UnityEngine-Object-'></a>
### LogException(exception,context) `method` [#](#M-ConditionalDebug-LogException-System-Exception,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs an error message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Runtime Exception. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object an error occurs. Note that this pauses the editor when 'ErrorPause' is enabled.

<a name='M-ConditionalDebug-LogFormat-System-String,System-Object[]-'></a>
### LogFormat(format,args) `method` [#](#M-ConditionalDebug-LogFormat-System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogFormat-UnityEngine-Object,System-String,System-Object[]-'></a>
### LogFormat(context,format,args) `method` [#](#M-ConditionalDebug-LogFormat-UnityEngine-Object,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogWarning-System-Object-'></a>
### LogWarning(message) `method` [#](#M-ConditionalDebug-LogWarning-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs a warning message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object a warning occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogWarning-System-Object,UnityEngine-Object-'></a>
### LogWarning(message,context) `method` [#](#M-ConditionalDebug-LogWarning-System-Object,UnityEngine-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A variant of Debug.Log that logs a warning message to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | String or object to be converted to string representation for display. |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |

##### Remarks

When you select the message in the console a connection to the context object will be drawn. This is very useful if you want know on which object a warning occurs. When the message is a string, rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogWarningFormat-System-String,System-Object[]-'></a>
### LogWarningFormat(format,args) `method` [#](#M-ConditionalDebug-LogWarningFormat-System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted warning message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='M-ConditionalDebug-LogWarningFormat-UnityEngine-Object,System-String,System-Object[]-'></a>
### LogWarningFormat(context,format,args) `method` [#](#M-ConditionalDebug-LogWarningFormat-UnityEngine-Object,System-String,System-Object[]- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Logs a formatted warning message to the Unity Console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [UnityEngine.Object](#T-UnityEngine-Object 'UnityEngine.Object') | Object to which the message applies. |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A composite format string. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Format arguments. |

##### Remarks

For formatting details, see the MSDN documentation on Composite Formatting. Rich text markup can be used to add emphasis. See the manual page about rich text for details of the different markup tags available.

<a name='T-CreatePopupButton'></a>
## CreatePopupButton [#](#T-CreatePopupButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Creates a popup window when button is clicked. Used for listable entity popups; roster, inventory, etc.

<a name='M-CreatePopupButton-SpawnPopup'></a>
### SpawnPopup() `method` [#](#M-CreatePopupButton-SpawnPopup 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the popup window when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-CreatePopupButton-Start'></a>
### Start() `method` [#](#M-CreatePopupButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T-CreateUpgradeAlliesPopupButton'></a>
## CreateUpgradeAlliesPopupButton [#](#T-CreateUpgradeAlliesPopupButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Creates the upgrade ally popup when the button is clicked.

<a name='M-CreateUpgradeAlliesPopupButton-SpawnPopup'></a>
### SpawnPopup() `method` [#](#M-CreateUpgradeAlliesPopupButton-SpawnPopup 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the upgrade ally popup when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-CreateUpgradeAlliesPopupButton-Start'></a>
### Start() `method` [#](#M-CreateUpgradeAlliesPopupButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T-CreateUpgradeHeroPopupButton'></a>
## CreateUpgradeHeroPopupButton [#](#T-CreateUpgradeHeroPopupButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Creates the upgrade hero popup when the button is clicked.

<a name='M-CreateUpgradeHeroPopupButton-SpawnPopup'></a>
### SpawnPopup() `method` [#](#M-CreateUpgradeHeroPopupButton-SpawnPopup 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the upgrade hero popup when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-CreateUpgradeHeroPopupButton-Start'></a>
### Start() `method` [#](#M-CreateUpgradeHeroPopupButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T-CurrencyText'></a>
## CurrencyText [#](#T-CurrencyText 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Updates the text object to reflect current currency.

<a name='M-CurrencyText-OnGUI'></a>
### OnGUI() `method` [#](#M-CurrencyText-OnGUI 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes every GUI refresh.

##### Parameters

This method has no parameters.

<a name='M-CurrencyText-Start'></a>
### Start() `method` [#](#M-CurrencyText-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the text.

##### Parameters

This method has no parameters.

<a name='T-CustomGizmo'></a>
## CustomGizmo [#](#T-CustomGizmo 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Allows the easy display of editor gizmos.

<a name='M-CustomGizmo-OnDrawGizmos'></a>
### OnDrawGizmos() `method` [#](#M-CustomGizmo-OnDrawGizmos 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes on gizmo refresh.

##### Parameters

This method has no parameters.

<a name='T-DerivedAttributes'></a>
## DerivedAttributes [#](#T-DerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

The derived attributes of a character from base attributes, levels, equipment, etc.

<a name='M-DerivedAttributes-#ctor-Character,System-Int32-'></a>
### #ctor(character,level) `constructor` [#](#M-DerivedAttributes-#ctor-Character,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor to create derived attributes from a character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| character | [Character](#T-Character 'Character') | Character object for base attributes. |
| level | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Level of the character. |

<a name='P-DerivedAttributes-AbilityDamage'></a>
### AbilityDamage `property` [#](#P-DerivedAttributes-AbilityDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage of abilities.

<a name='P-DerivedAttributes-AttackDamage'></a>
### AttackDamage `property` [#](#P-DerivedAttributes-AttackDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage of basic attacks.

<a name='P-DerivedAttributes-AttackSpeed'></a>
### AttackSpeed `property` [#](#P-DerivedAttributes-AttackSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Attacks per second.

<a name='P-DerivedAttributes-CooldownReduction'></a>
### CooldownReduction `property` [#](#P-DerivedAttributes-CooldownReduction 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Percentage of cooldowns reduced.

<a name='P-DerivedAttributes-CriticalHitChance'></a>
### CriticalHitChance `property` [#](#P-DerivedAttributes-CriticalHitChance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Chance for a critical hit.

<a name='P-DerivedAttributes-CriticalHitDamage'></a>
### CriticalHitDamage `property` [#](#P-DerivedAttributes-CriticalHitDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Damage bonus upon critical hit.

<a name='P-DerivedAttributes-Defense'></a>
### Defense `property` [#](#P-DerivedAttributes-Defense 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Resistance to damage.

<a name='P-DerivedAttributes-Energy'></a>
### Energy `property` [#](#P-DerivedAttributes-Energy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Energy points spend on abilities.

<a name='P-DerivedAttributes-EnergyRegeneration'></a>
### EnergyRegeneration `property` [#](#P-DerivedAttributes-EnergyRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Energy points regained per second.

<a name='P-DerivedAttributes-Health'></a>
### Health `property` [#](#P-DerivedAttributes-Health 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Health points before death.

<a name='P-DerivedAttributes-HealthRegeneration'></a>
### HealthRegeneration `property` [#](#P-DerivedAttributes-HealthRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Health points regained per second.

<a name='P-DerivedAttributes-LifeDrain'></a>
### LifeDrain `property` [#](#P-DerivedAttributes-LifeDrain 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Life regained per damage done.

<a name='P-DerivedAttributes-MovementSpeed'></a>
### MovementSpeed `property` [#](#P-DerivedAttributes-MovementSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Units moved per second.

<a name='M-DerivedAttributes-CalculateDerivedAttributes'></a>
### CalculateDerivedAttributes() `method` [#](#M-DerivedAttributes-CalculateDerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Calculate all derived attributes.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveAbilityDamage'></a>
### DeriveAbilityDamage() `method` [#](#M-DerivedAttributes-DeriveAbilityDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the ability damage attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveAttackDamage'></a>
### DeriveAttackDamage() `method` [#](#M-DerivedAttributes-DeriveAttackDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the attack damage attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveAttackSpeed'></a>
### DeriveAttackSpeed() `method` [#](#M-DerivedAttributes-DeriveAttackSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the attack speed attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveAttributeFloat-System-Int32,System-Single,System-Int32,System-Boolean-'></a>
### DeriveAttributeFloat(baseAttribute,fullValue,bonusAttribute,upgradable) `method` [#](#M-DerivedAttributes-DeriveAttributeFloat-System-Int32,System-Single,System-Int32,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives a floating point attribute.

##### Returns

The derived attribute.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseAttribute | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Base attribute value. |
| fullValue | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Full value of the attribute. |
| bonusAttribute | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Bonus attribute values. |
| upgradable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the attribute is upgraded by level. |

<a name='M-DerivedAttributes-DeriveAttributeInt-System-Int32,System-Int32,System-Int32,System-Boolean-'></a>
### DeriveAttributeInt(baseAttribute,fullValue,bonusAttribute,upgradable) `method` [#](#M-DerivedAttributes-DeriveAttributeInt-System-Int32,System-Int32,System-Int32,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives an integer attribute.

##### Returns

The derived attribute.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseAttribute | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Base attribute value. |
| fullValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Full value of the attribute. |
| bonusAttribute | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Bonus attribute values. |
| upgradable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the attribute is upgraded by level. |

<a name='M-DerivedAttributes-DeriveCooldownReduction'></a>
### DeriveCooldownReduction() `method` [#](#M-DerivedAttributes-DeriveCooldownReduction 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the cooldown reduction attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveCriticalHitChance'></a>
### DeriveCriticalHitChance() `method` [#](#M-DerivedAttributes-DeriveCriticalHitChance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the critical hit change attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveCriticalHitDamage'></a>
### DeriveCriticalHitDamage() `method` [#](#M-DerivedAttributes-DeriveCriticalHitDamage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the critical hit damage attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveDefense'></a>
### DeriveDefense() `method` [#](#M-DerivedAttributes-DeriveDefense 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the defense attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveEnergy'></a>
### DeriveEnergy() `method` [#](#M-DerivedAttributes-DeriveEnergy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the energy attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveEnergyRegeneration'></a>
### DeriveEnergyRegeneration() `method` [#](#M-DerivedAttributes-DeriveEnergyRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the energy regeneration attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveHealth'></a>
### DeriveHealth() `method` [#](#M-DerivedAttributes-DeriveHealth 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the health attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveHealthRegeneration'></a>
### DeriveHealthRegeneration() `method` [#](#M-DerivedAttributes-DeriveHealthRegeneration 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the health regeneration attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveLifeDrain'></a>
### DeriveLifeDrain() `method` [#](#M-DerivedAttributes-DeriveLifeDrain 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the lide drain attribute.

##### Parameters

This method has no parameters.

<a name='M-DerivedAttributes-DeriveMovementSpeed'></a>
### DeriveMovementSpeed() `method` [#](#M-DerivedAttributes-DeriveMovementSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Derives the movement speed attribute.

##### Parameters

This method has no parameters.

<a name='T-DirectAbilityController'></a>
## DirectAbilityController [#](#T-DirectAbilityController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls an ability that travels directly towards its target.

<a name='P-DirectAbilityController-Caster'></a>
### Caster `property` [#](#P-DirectAbilityController-Caster 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The caster of the ability.

<a name='P-DirectAbilityController-CriticalModifier'></a>
### CriticalModifier `property` [#](#P-DirectAbilityController-CriticalModifier 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The critical modifier of the ability.

<a name='P-DirectAbilityController-Damage'></a>
### Damage `property` [#](#P-DirectAbilityController-Damage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The damage the ability will apply upon contact.

<a name='P-DirectAbilityController-Target'></a>
### Target `property` [#](#P-DirectAbilityController-Target 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The target of the ability.

<a name='M-DirectAbilityController-Update'></a>
### Update() `method` [#](#M-DirectAbilityController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the ability every frame.

##### Parameters

This method has no parameters.

<a name='T-DirectMovementBehaviour'></a>
## DirectMovementBehaviour [#](#T-DirectMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to move in the most direct manner possible.

<a name='M-DirectMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single-'></a>
### #ctor(movementBehaviour,agent,target,radius) `constructor` [#](#M-DirectMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for DirectMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| target | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The target of this movement behaviour. |
| radius | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The radius at which this behaviour is completed. |

<a name='M-DirectMovementBehaviour-CalculateMaximumVelocity-UnityEngine-Vector2,UnityEngine-Vector2-'></a>
### CalculateMaximumVelocity(fromPosition,toPosition) `method` [#](#M-DirectMovementBehaviour-CalculateMaximumVelocity-UnityEngine-Vector2,UnityEngine-Vector2- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Calculates the maximum velocity of this direct movement behaviour.

##### Returns

Maximum velocity to go from start position to end position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fromPosition | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The start position. |
| toPosition | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The end position. |

<a name='T-DroppedEquipmentController'></a>
## DroppedEquipmentController [#](#T-DroppedEquipmentController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the motion of dropped equipment on the stage.

<a name='P-DroppedEquipmentController-Image'></a>
### Image `property` [#](#P-DroppedEquipmentController-Image 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Image component of dropped equipment indicator.

<a name='M-DroppedEquipmentController-Animate-UnityEngine-Vector3,UnityEngine-Vector3-'></a>
### Animate(startPosition,endPosition) `method` [#](#M-DroppedEquipmentController-Animate-UnityEngine-Vector3,UnityEngine-Vector3- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Animates the dropped equipment from start position to end position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startPosition | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') |  |
| endPosition | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') |  |

<a name='T-Enemy'></a>
## Enemy [#](#T-Enemy 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents an enemy.

<a name='P-Enemy-CharacterType'></a>
### CharacterType `property` [#](#P-Enemy-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character type of the enemy.

<a name='T-EnemyController'></a>
## EnemyController [#](#T-EnemyController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the Enemy GameObject.

<a name='P-EnemyController-AttackType'></a>
### AttackType `property` [#](#P-EnemyController-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the attack type of the enemy.

<a name='P-EnemyController-CharacterType'></a>
### CharacterType `property` [#](#P-EnemyController-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the CharacterType of the enemy.

<a name='P-EnemyController-EnemyObject'></a>
### EnemyObject `property` [#](#P-EnemyController-EnemyObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the scriptable object of the enemy.

<a name='P-EnemyController-Level'></a>
### Level `property` [#](#P-EnemyController-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Level of the enemy.

<a name='M-EnemyController-CreateDerivedAttributes'></a>
### CreateDerivedAttributes() `method` [#](#M-EnemyController-CreateDerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates derived attributes for the enemy.

##### Parameters

This method has no parameters.

<a name='M-EnemyController-Register'></a>
### Register() `method` [#](#M-EnemyController-Register 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers the enemy with the enemy manager.

##### Parameters

This method has no parameters.

<a name='M-EnemyController-Start'></a>
### Start() `method` [#](#M-EnemyController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the enemy controller.

##### Parameters

This method has no parameters.

<a name='M-EnemyController-Unregister'></a>
### Unregister() `method` [#](#M-EnemyController-Unregister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unregisters the enemy with the enemy manager.

##### Parameters

This method has no parameters.

<a name='T-EnemyManager'></a>
## EnemyManager [#](#T-EnemyManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the enemies on a stage.

<a name='T-Equipment'></a>
## Equipment [#](#T-Equipment 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a piece of equipment.

<a name='P-Equipment-AttackType'></a>
### AttackType `property` [#](#P-Equipment-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Attack type of this equipment if it is a weapon.

<a name='P-Equipment-AttributeModifiers'></a>
### AttributeModifiers `property` [#](#P-Equipment-AttributeModifiers 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Modifications to attributes when equipment is assigned.

<a name='P-Equipment-EquipmentSlot'></a>
### EquipmentSlot `property` [#](#P-Equipment-EquipmentSlot 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Slot equipment is assigned to.

<a name='P-Equipment-EquipmentType'></a>
### EquipmentType `property` [#](#P-Equipment-EquipmentType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of equipment.

<a name='P-Equipment-ListableType'></a>
### ListableType `property` [#](#P-Equipment-ListableType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of lists this equipment belongs to.

<a name='T-EquipmentSlot'></a>
## EquipmentSlot [#](#T-EquipmentSlot 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the slots in which equipment can be placed.

<a name='F-EquipmentSlot-Body'></a>
### Body `constants` [#](#F-EquipmentSlot-Body 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Equipped on the body.

<a name='F-EquipmentSlot-LeftHand'></a>
### LeftHand `constants` [#](#F-EquipmentSlot-LeftHand 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Equipped in left hand.

<a name='F-EquipmentSlot-RightHand'></a>
### RightHand `constants` [#](#F-EquipmentSlot-RightHand 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Equipped in right hand.

<a name='F-EquipmentSlot-TwoHand'></a>
### TwoHand `constants` [#](#F-EquipmentSlot-TwoHand 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Equipped using both hands.

<a name='T-EquipmentType'></a>
## EquipmentType [#](#T-EquipmentType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the type of a piece of equipment.

<a name='F-EquipmentType-Armor'></a>
### Armor `constants` [#](#F-EquipmentType-Armor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Used to resist damage.

<a name='F-EquipmentType-Shield'></a>
### Shield `constants` [#](#F-EquipmentType-Shield 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Used to defend.

<a name='F-EquipmentType-Weapon'></a>
### Weapon `constants` [#](#F-EquipmentType-Weapon 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Used the attack.

<a name='T-ExperienceText'></a>
## ExperienceText [#](#T-ExperienceText 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Keeps a text object updated with the current experience.

<a name='M-ExperienceText-OnGUI'></a>
### OnGUI() `method` [#](#M-ExperienceText-OnGUI 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes every GUI refresh.

##### Parameters

This method has no parameters.

<a name='M-ExperienceText-Start'></a>
### Start() `method` [#](#M-ExperienceText-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the text.

##### Parameters

This method has no parameters.

<a name='T-FleeMovementBehaviour'></a>
## FleeMovementBehaviour [#](#T-FleeMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to move directly away from the location of the target.

<a name='M-FleeMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single-'></a>
### #ctor(movementBehaviour,agent,target,radius) `constructor` [#](#M-FleeMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for FleeMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| target | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The target of this movement behaviour. |
| radius | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The radius at which this behaviour is completed. |

<a name='M-FleeMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-FleeMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-FloatingBarController'></a>
## FloatingBarController [#](#T-FloatingBarController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the position, color, and display of a scroll bar above a character's head that represents a character's health, energy, or other endurance attribute.

<a name='M-FloatingBarController-Start'></a>
### Start() `method` [#](#M-FloatingBarController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the floating bar.

##### Parameters

This method has no parameters.

<a name='M-FloatingBarController-Update'></a>
### Update() `method` [#](#M-FloatingBarController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the floating bar every frame.

##### Parameters

This method has no parameters.

<a name='T-GameCharacterController'></a>
## GameCharacterController [#](#T-GameCharacterController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Provides easy access to references to the various components of a character.

<a name='F-GameCharacterController-isCombatDummy'></a>
### isCombatDummy `constants` [#](#F-GameCharacterController-isCombatDummy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the character is a combat dummy.

<a name='P-GameCharacterController-Animator'></a>
### Animator `property` [#](#P-GameCharacterController-Animator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the Animator for the character.

<a name='P-GameCharacterController-AttackType'></a>
### AttackType `property` [#](#P-GameCharacterController-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the AttackType of the character.

<a name='P-GameCharacterController-Attributes'></a>
### Attributes `property` [#](#P-GameCharacterController-Attributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the derived attributes of the character.

<a name='P-GameCharacterController-CharacterObject'></a>
### CharacterObject `property` [#](#P-GameCharacterController-CharacterObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the Character ScriptableObject.

<a name='P-GameCharacterController-CharacterState'></a>
### CharacterState `property` [#](#P-GameCharacterController-CharacterState 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get or set the current state of the character.

##### Remarks

Raises the state change event if the state changed.

<a name='P-GameCharacterController-CharacterType'></a>
### CharacterType `property` [#](#P-GameCharacterController-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the CharacterType of the character.

<a name='P-GameCharacterController-CombatController'></a>
### CombatController `property` [#](#P-GameCharacterController-CombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a reference to the character's combat controller.

<a name='P-GameCharacterController-IsDead'></a>
### IsDead `property` [#](#P-GameCharacterController-IsDead 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the character is dead.

<a name='P-GameCharacterController-IsFriendly'></a>
### IsFriendly `property` [#](#P-GameCharacterController-IsFriendly 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not the character is considered friendly to the hero.

<a name='P-GameCharacterController-LastDirection'></a>
### LastDirection `property` [#](#P-GameCharacterController-LastDirection 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the last direction the character was facing.

<a name='P-GameCharacterController-Level'></a>
### Level `property` [#](#P-GameCharacterController-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the level of the character.

<a name='P-GameCharacterController-Location'></a>
### Location `property` [#](#P-GameCharacterController-Location 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the location of the character.

<a name='P-GameCharacterController-MovementController'></a>
### MovementController `property` [#](#P-GameCharacterController-MovementController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a reference to the character's movement controller.

<a name='P-GameCharacterController-Rigidbody'></a>
### Rigidbody `property` [#](#P-GameCharacterController-Rigidbody 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a reference to the character's rigidbody.

<a name='M-GameCharacterController-CreateAnimator'></a>
### CreateAnimator() `method` [#](#M-GameCharacterController-CreateAnimator 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the animator controller for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateCapsuleCollider2D'></a>
### CreateCapsuleCollider2D() `method` [#](#M-GameCharacterController-CreateCapsuleCollider2D 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the capsule collider for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateCombatController'></a>
### CreateCombatController() `method` [#](#M-GameCharacterController-CreateCombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the combat controller for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateDerivedAttributes'></a>
### CreateDerivedAttributes() `method` [#](#M-GameCharacterController-CreateDerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates derived attributes based on the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateFloatingHealthBar'></a>
### CreateFloatingHealthBar() `method` [#](#M-GameCharacterController-CreateFloatingHealthBar 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the floating health bar for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateGraphicsController'></a>
### CreateGraphicsController() `method` [#](#M-GameCharacterController-CreateGraphicsController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the graphics controller for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateMovementController'></a>
### CreateMovementController() `method` [#](#M-GameCharacterController-CreateMovementController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the movement controller for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateRigidbody2D'></a>
### CreateRigidbody2D() `method` [#](#M-GameCharacterController-CreateRigidbody2D 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the 2D rigid body for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-CreateSpriteRenderer'></a>
### CreateSpriteRenderer() `method` [#](#M-GameCharacterController-CreateSpriteRenderer 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the sprite renderer for the character.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-OnDestroy'></a>
### OnDestroy() `method` [#](#M-GameCharacterController-OnDestroy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Called when the game object is destroyed.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-Register'></a>
### Register() `method` [#](#M-GameCharacterController-Register 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers the character with its respective manager.

##### Parameters

This method has no parameters.

<a name='M-GameCharacterController-Unregister'></a>
### Unregister() `method` [#](#M-GameCharacterController-Unregister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unregisters the character from its respective manager.

##### Parameters

This method has no parameters.

<a name='T-GameManager'></a>
## GameManager [#](#T-GameManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the game.

<a name='P-GameManager-AbilityManager'></a>
### AbilityManager `property` [#](#P-GameManager-AbilityManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the ability manager.

<a name='P-GameManager-AllCharacters'></a>
### AllCharacters `property` [#](#P-GameManager-AllCharacters 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of all characters on the stage.

<a name='P-GameManager-AllEnemies'></a>
### AllEnemies `property` [#](#P-GameManager-AllEnemies 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of all enemies on the stage.

<a name='P-GameManager-AllFriendlies'></a>
### AllFriendlies `property` [#](#P-GameManager-AllFriendlies 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of all friendlies on the stage.

<a name='P-GameManager-AllyManager'></a>
### AllyManager `property` [#](#P-GameManager-AllyManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the stage ally manager.

<a name='P-GameManager-BossManager'></a>
### BossManager `property` [#](#P-GameManager-BossManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the stage boss manager.

<a name='P-GameManager-CanUpgradeHero'></a>
### CanUpgradeHero `property` [#](#P-GameManager-CanUpgradeHero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the hero can be upgraded.

<a name='P-GameManager-EnemyManager'></a>
### EnemyManager `property` [#](#P-GameManager-EnemyManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the stage enemy manager.

<a name='P-GameManager-GameSettings'></a>
### GameSettings `property` [#](#P-GameManager-GameSettings 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the game settings.

<a name='P-GameManager-Hero'></a>
### Hero `property` [#](#P-GameManager-Hero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the hero controller.

<a name='P-GameManager-HeroManager'></a>
### HeroManager `property` [#](#P-GameManager-HeroManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the hero manager.

<a name='P-GameManager-InventoryManager'></a>
### InventoryManager `property` [#](#P-GameManager-InventoryManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the inventory manager.

<a name='P-GameManager-OnStage'></a>
### OnStage `property` [#](#P-GameManager-OnStage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the game is on a stage.

<a name='P-GameManager-QueueManager'></a>
### QueueManager `property` [#](#P-GameManager-QueueManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the stage queue manager.

<a name='P-GameManager-RosterManager'></a>
### RosterManager `property` [#](#P-GameManager-RosterManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the roster manager.

<a name='P-GameManager-StageManager'></a>
### StageManager `property` [#](#P-GameManager-StageManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the current stage manager.

<a name='P-GameManager-UpgradeHeroCost'></a>
### UpgradeHeroCost `property` [#](#P-GameManager-UpgradeHeroCost 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The cost of the next hero upgrade.

<a name='P-GameManager-WorldManager'></a>
### WorldManager `property` [#](#P-GameManager-WorldManager 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the world manager.

<a name='M-GameManager-AllCharactersExcept-GameCharacterController-'></a>
### AllCharactersExcept(self) `method` [#](#M-GameManager-AllCharactersExcept-GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of all characters on the stage except the specified character.

##### Returns

A list of characters on the stage.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The character on the stage that isn't included in the list. |

<a name='M-GameManager-Awake'></a>
### Awake() `method` [#](#M-GameManager-Awake 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs initialization prior to next frame.

##### Parameters

This method has no parameters.

<a name='M-GameManager-CanUpgradeAlly-System-String-'></a>
### CanUpgradeAlly(allyName) `method` [#](#M-GameManager-CanUpgradeAlly-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the specified ally can be upgraded.

##### Returns

Whether or not the ally can be upgraded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the ally to upgrade. |

<a name='M-GameManager-GenerateIdleRewards'></a>
### GenerateIdleRewards() `method` [#](#M-GameManager-GenerateIdleRewards 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generate idle rewards per frame.

##### Parameters

This method has no parameters.

<a name='M-GameManager-GetManagerByType-ListableEntityType-'></a>
### GetManagerByType(entityType) `method` [#](#M-GameManager-GetManagerByType-ListableEntityType- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets a world entity manager corresponding to the specified type.

##### Returns

The world entity manager for the specified type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityType | [ListableEntityType](#T-ListableEntityType 'ListableEntityType') | The type of entity to get the manager of. |

<a name='M-GameManager-InitializeGameWorldManagers'></a>
### InitializeGameWorldManagers() `method` [#](#M-GameManager-InitializeGameWorldManagers 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initialize game world managers.

##### Parameters

This method has no parameters.

<a name='M-GameManager-InitializeStageEntityManagers'></a>
### InitializeStageEntityManagers() `method` [#](#M-GameManager-InitializeStageEntityManagers 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes the stage entity managers.

##### Parameters

This method has no parameters.

<a name='M-GameManager-InitializeWorld'></a>
### InitializeWorld() `method` [#](#M-GameManager-InitializeWorld 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes the world.

##### Parameters

This method has no parameters.

<a name='M-GameManager-InitializeWorldEntityManagers'></a>
### InitializeWorldEntityManagers() `method` [#](#M-GameManager-InitializeWorldEntityManagers 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initialize world entity managers.

##### Parameters

This method has no parameters.

<a name='M-GameManager-LoadStage-SceneField-'></a>
### LoadStage(stage) `method` [#](#M-GameManager-LoadStage-SceneField- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a stage.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stage | [SceneField](#T-SceneField 'SceneField') | The sage to load. |

<a name='M-GameManager-LoadStageUi'></a>
### LoadStageUi() `method` [#](#M-GameManager-LoadStageUi 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the user interface for a stage scene.

##### Parameters

This method has no parameters.

<a name='M-GameManager-LoadWorld'></a>
### LoadWorld() `method` [#](#M-GameManager-LoadWorld 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the world scene.

##### Parameters

This method has no parameters.

<a name='M-GameManager-LoadWorldUi'></a>
### LoadWorldUi() `method` [#](#M-GameManager-LoadWorldUi 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the user interface for the world scene.

##### Parameters

This method has no parameters.

<a name='M-GameManager-LoadZone-System-String-'></a>
### LoadZone(zone) `method` [#](#M-GameManager-LoadZone-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a zone.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| zone | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the zone to load. |

<a name='M-GameManager-LoadZoneUi'></a>
### LoadZoneUi() `method` [#](#M-GameManager-LoadZoneUi 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the user interface for a zone scene.

##### Parameters

This method has no parameters.

<a name='M-GameManager-OnApplicationPause-System-Boolean-'></a>
### OnApplicationPause(pause) `method` [#](#M-GameManager-OnApplicationPause-System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Called when application is paused.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pause | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-GameManager-OnApplicationQuit'></a>
### OnApplicationQuit() `method` [#](#M-GameManager-OnApplicationQuit 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Called when application is quit.

##### Parameters

This method has no parameters.

<a name='M-GameManager-OnDestroy'></a>
### OnDestroy() `method` [#](#M-GameManager-OnDestroy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Called when the game manager is destroyed.

##### Parameters

This method has no parameters.

<a name='M-GameManager-OnSceneChanged-UnityEngine-SceneManagement-Scene,UnityEngine-SceneManagement-Scene-'></a>
### OnSceneChanged(previousScene,newScene) `method` [#](#M-GameManager-OnSceneChanged-UnityEngine-SceneManagement-Scene,UnityEngine-SceneManagement-Scene- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Called when the scene changes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| previousScene | [UnityEngine.SceneManagement.Scene](#T-UnityEngine-SceneManagement-Scene 'UnityEngine.SceneManagement.Scene') | The previous scene. |
| newScene | [UnityEngine.SceneManagement.Scene](#T-UnityEngine-SceneManagement-Scene 'UnityEngine.SceneManagement.Scene') | The new scene. |

<a name='M-GameManager-SaveGame'></a>
### SaveGame() `method` [#](#M-GameManager-SaveGame 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Saves the game.

##### Parameters

This method has no parameters.

<a name='M-GameManager-Start'></a>
### Start() `method` [#](#M-GameManager-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the game manager.

##### Parameters

This method has no parameters.

<a name='M-GameManager-Update'></a>
### Update() `method` [#](#M-GameManager-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the game manager every frame.

##### Parameters

This method has no parameters.

<a name='M-GameManager-UpgradeAlly-System-String-'></a>
### UpgradeAlly(allyName) `method` [#](#M-GameManager-UpgradeAlly-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Upgrades the specified ally.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the ally to upgrade. |

<a name='M-GameManager-UpgradeAllyCost-System-String-'></a>
### UpgradeAllyCost(allyName) `method` [#](#M-GameManager-UpgradeAllyCost-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the cost of the next upgrade for the specified ally.

##### Returns

The experience cost of the next upgrade for the ally.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | THe name of the ally to upgrade. |

<a name='M-GameManager-UpgradeHero'></a>
### UpgradeHero() `method` [#](#M-GameManager-UpgradeHero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Upgrades the hero.

##### Parameters

This method has no parameters.

<a name='T-GameSettings'></a>
## GameSettings [#](#T-GameSettings 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Provides an inspector interface for constant game values.

<a name='T-CustomGizmo-GizmoShape'></a>
## GizmoShape [#](#T-CustomGizmo-GizmoShape 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

CustomGizmo

##### Summary

Shape of the gizmo.

<a name='T-GraphicsController'></a>
## GraphicsController [#](#T-GraphicsController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Responsible for updating character graphics.

<a name='M-GraphicsController-CharacterStateChanged'></a>
### CharacterStateChanged() `method` [#](#M-GraphicsController-CharacterStateChanged 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Event handler for a character's state changing. Updates the character's animation based on the new state.

##### Parameters

This method has no parameters.

<a name='M-GraphicsController-GetCharacterComponent'></a>
### GetCharacterComponent() `method` [#](#M-GraphicsController-GetCharacterComponent 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the character and subscribes to stage change events.

##### Parameters

This method has no parameters.

<a name='M-GraphicsController-GetStateAnimationString'></a>
### GetStateAnimationString() `method` [#](#M-GraphicsController-GetStateAnimationString 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Combines a character's state and direction to become an animation state.

##### Returns

A string in the form of (state)(direction) (e.g. "WalkLeft").

##### Parameters

This method has no parameters.

<a name='M-GraphicsController-Start'></a>
### Start() `method` [#](#M-GraphicsController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the character graphics.

##### Parameters

This method has no parameters.

<a name='M-GraphicsController-Update'></a>
### Update() `method` [#](#M-GraphicsController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the character every frame.

##### Parameters

This method has no parameters.

<a name='M-GraphicsController-UpdateSortingOrder'></a>
### UpdateSortingOrder() `method` [#](#M-GraphicsController-UpdateSortingOrder 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the rendering order of the game object based on vertical position. Objects higher on the screen are rendered behind objects that are lower.

##### Parameters

This method has no parameters.

<a name='T-HazardController'></a>
## HazardController [#](#T-HazardController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls interactions with hazards.

<a name='P-HazardController-IsPathable'></a>
### IsPathable `property` [#](#P-HazardController-IsPathable 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not characters will path around the hazard.

<a name='M-HazardController-ApplyEffect-GameCharacterController-'></a>
### ApplyEffect() `method` [#](#M-HazardController-ApplyEffect-GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies the hazard's effect to a character.

##### Parameters

This method has no parameters.

<a name='M-HazardController-OnTriggerEnter2D-UnityEngine-Collider2D-'></a>
### OnTriggerEnter2D() `method` [#](#M-HazardController-OnTriggerEnter2D-UnityEngine-Collider2D- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Triggers the hazard's effect.

##### Parameters

This method has no parameters.

<a name='T-HazardType'></a>
## HazardType [#](#T-HazardType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the type of hazard.

<a name='F-HazardType-Damage'></a>
### Damage `constants` [#](#F-HazardType-Damage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies damage to the character.

<a name='F-HazardType-Force'></a>
### Force `constants` [#](#F-HazardType-Force 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies a force to the character.

<a name='F-HazardType-Stun'></a>
### Stun `constants` [#](#F-HazardType-Stun 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Stuns the character.

<a name='T-HelpBoxAttribute'></a>
## HelpBoxAttribute [#](#T-HelpBoxAttribute 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

The attribute applied to fields to display a help box.

<a name='T-HelpBoxMessageType'></a>
## HelpBoxMessageType [#](#T-HelpBoxMessageType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Type of help box message; affect displayed icon.

<a name='T-Hero'></a>
## Hero [#](#T-Hero 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a hero.

<a name='P-Hero-CharacterType'></a>
### CharacterType `property` [#](#P-Hero-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Character type of the hero.

<a name='T-HeroCombatController'></a>
## HeroCombatController [#](#T-HeroCombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the combat for the hero.

<a name='P-HeroCombatController-AbilityCooldowns'></a>
### AbilityCooldowns `property` [#](#P-HeroCombatController-AbilityCooldowns 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

A collection of all abilities that are on cooldown, and the duration of their cooldown. The key is the name of the cooldown; value is the duration.

<a name='M-HeroCombatController-ApplyDamage-System-Int32,System-Boolean-'></a>
### ApplyDamage(damage,isCritical) `method` [#](#M-HeroCombatController-ApplyDamage-System-Int32,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies damage to the hero.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| damage | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of damage to apply. |
| isCritical | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the damage includes critical damage. |

<a name='M-HeroCombatController-ApplyEnergyLoss-System-Int32-'></a>
### ApplyEnergyLoss(energyCost) `method` [#](#M-HeroCombatController-ApplyEnergyLoss-System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies a loss of energy to the hero.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| energyCost | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of energy to lose. |

<a name='M-HeroCombatController-PerformCombatRound'></a>
### PerformCombatRound() `method` [#](#M-HeroCombatController-PerformCombatRound 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a combat round.

##### Parameters

This method has no parameters.

<a name='M-HeroCombatController-PerformDefendAbility-Ability-'></a>
### PerformDefendAbility(ability) `method` [#](#M-HeroCombatController-PerformDefendAbility-Ability- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a defend ability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |

<a name='M-HeroCombatController-PerformFireball-Ability,GameCharacterController-'></a>
### PerformFireball(ability,target) `method` [#](#M-HeroCombatController-PerformFireball-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns a fireball projectile.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroCombatController-PerformMeleeAreaAbility-Ability,GameCharacterController-'></a>
### PerformMeleeAreaAbility(ability,target) `method` [#](#M-HeroCombatController-PerformMeleeAreaAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a melee area ability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroCombatController-PerformRangedAreaAbility-Ability,GameCharacterController-'></a>
### PerformRangedAreaAbility(ability,target) `method` [#](#M-HeroCombatController-PerformRangedAreaAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a ranged area ability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroCombatController-SpawnStorm-UnityEngine-Vector3,GameCharacterController-'></a>
### SpawnStorm(location,target) `method` [#](#M-HeroCombatController-SpawnStorm-UnityEngine-Vector3,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns a storm projectile.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| location | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The location to spawn the storm projectile. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the storm projectile. |

<a name='M-HeroCombatController-Start'></a>
### Start() `method` [#](#M-HeroCombatController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the hero combat controller.

##### Parameters

This method has no parameters.

<a name='M-HeroCombatController-Update'></a>
### Update() `method` [#](#M-HeroCombatController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the hero every frame.

##### Parameters

This method has no parameters.

<a name='M-HeroCombatController-UpdateCooldowns'></a>
### UpdateCooldowns() `method` [#](#M-HeroCombatController-UpdateCooldowns 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates all ability cooldowns based on time passed.

##### Parameters

This method has no parameters.

<a name='M-HeroCombatController-UpdateDefend'></a>
### UpdateDefend() `method` [#](#M-HeroCombatController-UpdateDefend 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the state of the hero's defend ability.

##### Parameters

This method has no parameters.

<a name='M-HeroCombatController-UpdateTarget'></a>
### UpdateTarget() `method` [#](#M-HeroCombatController-UpdateTarget 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Finds an appropriate target for the character if one exists on the stage.

##### Parameters

This method has no parameters.

<a name='T-HeroController'></a>
## HeroController [#](#T-HeroController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the Hero GameObject.

<a name='P-HeroController-AttackType'></a>
### AttackType `property` [#](#P-HeroController-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the attack type of the hero.

<a name='P-HeroController-CharacterObject'></a>
### CharacterObject `property` [#](#P-HeroController-CharacterObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the ScriptableObject for the character.

<a name='P-HeroController-CharacterType'></a>
### CharacterType `property` [#](#P-HeroController-CharacterType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the character type of the hero.

<a name='P-HeroController-HeroCombatController'></a>
### HeroCombatController `property` [#](#P-HeroController-HeroCombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the HeroCombatController for the hero.

<a name='P-HeroController-HeroInputController'></a>
### HeroInputController `property` [#](#P-HeroController-HeroInputController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Reference to the HeroInputController.

<a name='P-HeroController-HeroMovementController'></a>
### HeroMovementController `property` [#](#P-HeroController-HeroMovementController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Reference to the HeroMovementController.

<a name='P-HeroController-HeroObject'></a>
### HeroObject `property` [#](#P-HeroController-HeroObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The ScritableObject of the hero.

<a name='P-HeroController-Level'></a>
### Level `property` [#](#P-HeroController-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Level of the hero.

<a name='M-HeroController-CreateCombatController'></a>
### CreateCombatController() `method` [#](#M-HeroController-CreateCombatController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the hero's combat controller.

##### Parameters

This method has no parameters.

<a name='M-HeroController-CreateDerivedAttributes'></a>
### CreateDerivedAttributes() `method` [#](#M-HeroController-CreateDerivedAttributes 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the derived attributes for the hero.

##### Parameters

This method has no parameters.

<a name='M-HeroController-CreateHeroInputController'></a>
### CreateHeroInputController() `method` [#](#M-HeroController-CreateHeroInputController 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates the hero input controller.

##### Parameters

This method has no parameters.

<a name='M-HeroController-PerformAbility-Ability,GameCharacterController-'></a>
### PerformAbility(ability,target) `method` [#](#M-HeroController-PerformAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs an ability on a target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroController-PerformAreaAbility-Ability,GameCharacterController-'></a>
### PerformAreaAbility(ability,target) `method` [#](#M-HeroController-PerformAreaAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs an area ability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | Target at the center of the area ability. |

<a name='M-HeroController-PerformDirectAbility-Ability,GameCharacterController-'></a>
### PerformDirectAbility(ability,target) `method` [#](#M-HeroController-PerformDirectAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a direct ability on a target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroController-PerformHealAbility-Ability,GameCharacterController-'></a>
### PerformHealAbility(ability,target) `method` [#](#M-HeroController-PerformHealAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a heal ability on a target. Placeholder.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroController-PerformShieldAbility-Ability,GameCharacterController-'></a>
### PerformShieldAbility(ability,target) `method` [#](#M-HeroController-PerformShieldAbility-Ability,GameCharacterController- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Performs a shield ability on a target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |
| target | [GameCharacterController](#T-GameCharacterController 'GameCharacterController') | The target of the ability. |

<a name='M-HeroController-Register'></a>
### Register() `method` [#](#M-HeroController-Register 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers the hero with the hero manager.

##### Parameters

This method has no parameters.

<a name='M-HeroController-SpawnAllies'></a>
### SpawnAllies() `method` [#](#M-HeroController-SpawnAllies 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the assigned allies.

##### Parameters

This method has no parameters.

<a name='M-HeroController-Start'></a>
### Start() `method` [#](#M-HeroController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the hero controller.

##### Parameters

This method has no parameters.

<a name='M-HeroController-Unregister'></a>
### Unregister() `method` [#](#M-HeroController-Unregister 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unregisters the hero from the hero manager.

##### Parameters

This method has no parameters.

<a name='M-HeroController-UseAbility-Ability-'></a>
### UseAbility(ability) `method` [#](#M-HeroController-UseAbility-Ability- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Attempts to use an ability. Does nothing if the ability is on cooldown. Awaits a target if the ability requires one.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to perform. |

<a name='T-HeroEnergyBar'></a>
## HeroEnergyBar [#](#T-HeroEnergyBar 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the hero energy bar.

<a name='M-HeroEnergyBar-OnGUI'></a>
### OnGUI() `method` [#](#M-HeroEnergyBar-OnGUI 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes energy bar every GUI refresh.

##### Parameters

This method has no parameters.

<a name='T-HeroHealthBar'></a>
## HeroHealthBar [#](#T-HeroHealthBar 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the hero health bar.

<a name='M-HeroHealthBar-OnGUI'></a>
### OnGUI() `method` [#](#M-HeroHealthBar-OnGUI 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes the health bar every GUI refresh.

##### Parameters

This method has no parameters.

<a name='T-HeroInputController'></a>
## HeroInputController [#](#T-HeroInputController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the hero input.

<a name='M-HeroInputController-AwaitTarget-Ability-'></a>
### AwaitTarget(ability) `method` [#](#M-HeroInputController-AwaitTarget-Ability- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Awaits a target for targetable abilities when hero doesn't have a target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ability | [Ability](#T-Ability 'Ability') | The ability to use once a target is found. |

<a name='M-HeroInputController-IsPointerOverUIObject'></a>
### IsPointerOverUIObject() `method` [#](#M-HeroInputController-IsPointerOverUIObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Detects if a touch or click is over a UI object.

##### Returns

True if a UI was tapped; false otherwise.

##### Parameters

This method has no parameters.

<a name='M-HeroInputController-ProcessTap-UnityEngine-Vector2-'></a>
### ProcessTap(position) `method` [#](#M-HeroInputController-ProcessTap-UnityEngine-Vector2- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Process a tap at a screen position.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| position | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The screen position of the tap. |

<a name='M-HeroInputController-Start'></a>
### Start() `method` [#](#M-HeroInputController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the hero input.

##### Parameters

This method has no parameters.

<a name='M-HeroInputController-Update'></a>
### Update() `method` [#](#M-HeroInputController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the hero input every frame.

##### Parameters

This method has no parameters.

<a name='T-HeroManager'></a>
## HeroManager [#](#T-HeroManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the hero on the stage, and provides easy access to common hero functionality.

<a name='M-HeroManager-#ctor'></a>
### #ctor() `constructor` [#](#M-HeroManager-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the hero manager.

##### Parameters

This constructor has no parameters.

<a name='P-HeroManager-Currency'></a>
### Currency `property` [#](#P-HeroManager-Currency 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the hero's currency.

<a name='P-HeroManager-Experience'></a>
### Experience `property` [#](#P-HeroManager-Experience 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the hero's experience.

<a name='P-HeroManager-Hero'></a>
### Hero `property` [#](#P-HeroManager-Hero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the hero controller.

<a name='P-HeroManager-HeroObject'></a>
### HeroObject `property` [#](#P-HeroManager-HeroObject 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the hero's scriptable object.

<a name='P-HeroManager-Level'></a>
### Level `property` [#](#P-HeroManager-Level 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the hero's level.

<a name='M-HeroManager-AddHeroToList-System-Collections-Generic-List{GameCharacterController}@-'></a>
### AddHeroToList(addToList) `method` [#](#M-HeroManager-AddHeroToList-System-Collections-Generic-List{GameCharacterController}@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds hero to the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addToList | [System.Collections.Generic.List{GameCharacterController}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{GameCharacterController}@') | The list to add the hero to. |

<a name='M-HeroManager-Load-SaveGame-'></a>
### Load(save) `method` [#](#M-HeroManager-Load-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the hero manager from a saved game.

##### Returns

A hero manager filled with saved data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | Saved game data. |

<a name='M-HeroManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-HeroManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Saves the experience and level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='T--HeroMovementController'></a>
## HeroMovementController [#](#T--HeroMovementController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



<a name='P-HeroMovementController-Location'></a>
### Location `property` [#](#P-HeroMovementController-Location 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the location target of the hero.

<a name='M-HeroMovementController-GenerateSeekBehaviour'></a>
### GenerateSeekBehaviour() `method` [#](#M-HeroMovementController-GenerateSeekBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generates movement behaviour to seek a location, or to seek a target if not seeking a location, or does nothing if the hero has neither a location target not a character target.

##### Parameters

This method has no parameters.

<a name='M-HeroMovementController-Start'></a>
### Start() `method` [#](#M-HeroMovementController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the hero movement controller.

##### Parameters

This method has no parameters.

<a name='T-HeroStagePortrait'></a>
## HeroStagePortrait [#](#T-HeroStagePortrait 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the hero portrait.

<a name='M-HeroStagePortrait-Start'></a>
### Start() `method` [#](#M-HeroStagePortrait-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the portrait.

##### Parameters

This method has no parameters.

<a name='T-IdleMovementBehaviour'></a>
## IdleMovementBehaviour [#](#T-IdleMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

The root behaviour of all movement behaviours.

<a name='M-IdleMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-IdleMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='M-IdleMovementBehaviour-Steering'></a>
### Steering() `method` [#](#M-IdleMovementBehaviour-Steering 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The steering vector desired by this movement behaviour.

##### Returns

The optimal steering vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-InventoryManager'></a>
## InventoryManager [#](#T-InventoryManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages equipment in the inventory; keeping track of unlock equipment, assigned equipment, etc.

<a name='M-InventoryManager-#ctor-SaveGame-'></a>
### #ctor(save) `constructor` [#](#M-InventoryManager-#ctor-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the inventory manager from a saved game.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='P-InventoryManager-AttackType'></a>
### AttackType `property` [#](#P-InventoryManager-AttackType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the attack type based on assigned equipment.

<a name='P-InventoryManager-AttributeModifiers'></a>
### AttributeModifiers `property` [#](#P-InventoryManager-AttributeModifiers 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the attribute modifiers of all assigned equipment.

<a name='P-InventoryManager-MaxAssigned'></a>
### MaxAssigned `property` [#](#P-InventoryManager-MaxAssigned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of assigned equipment.

<a name='P-InventoryManager-MaxUnlocked'></a>
### MaxUnlocked `property` [#](#P-InventoryManager-MaxUnlocked 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of unlocked equipment.

<a name='P-InventoryManager-ResourcePath'></a>
### ResourcePath `property` [#](#P-InventoryManager-ResourcePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the resource path of equipment.

<a name='M-InventoryManager-AddAssigned-System-String,System-Boolean-'></a>
### AddAssigned(name,raiseChangeEvent) `method` [#](#M-InventoryManager-AddAssigned-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a piece of equipment to the assigned list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the equipment to assign. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the raise an event about the change. |

<a name='M-InventoryManager-Load-SaveGame-'></a>
### Load(save) `method` [#](#M-InventoryManager-Load-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads inventory information from save game data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='M-InventoryManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-InventoryManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Fills a save game with inventory data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='T-LevelUpgrades'></a>
## LevelUpgrades [#](#T-LevelUpgrades 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents which attributes will be leveled up when an ally is upgraded.

<a name='T-ListableEntity'></a>
## ListableEntity [#](#T-ListableEntity 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents an entity that will be displayed in lists.

<a name='P-ListableEntity-Icon'></a>
### Icon `property` [#](#P-ListableEntity-Icon 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Icon for the entity when displayed in lists.

<a name='P-ListableEntity-ListableType'></a>
### ListableType `property` [#](#P-ListableEntity-ListableType 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Type of lists this entity belongs to.

<a name='T-ListableEntityType'></a>
## ListableEntityType [#](#T-ListableEntityType 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Type of world entity lists.

<a name='F-ListableEntityType-Ability'></a>
### Ability `constants` [#](#F-ListableEntityType-Ability 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

List of abilities.

<a name='F-ListableEntityType-Inventory'></a>
### Inventory `constants` [#](#F-ListableEntityType-Inventory 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

List of equipment.

<a name='F-ListableEntityType-NonListable'></a>
### NonListable `constants` [#](#F-ListableEntityType-NonListable 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

World entity does not get listed.

<a name='F-ListableEntityType-Roster'></a>
### Roster `constants` [#](#F-ListableEntityType-Roster 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

List of allies.

<a name='T-ListExtensions'></a>
## ListExtensions [#](#T-ListExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Methods that extent the built-in List collection.

<a name='M-ListExtensions-ToDelimitedString-System-Collections-Generic-List{System-String},System-String-'></a>
### ToDelimitedString(list,delimiter) `method` [#](#M-ListExtensions-ToDelimitedString-System-Collections-Generic-List{System-String},System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generates a string of the list delimited by a string.

##### Returns

A string of the list delimited by a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The list to display. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string delimiter. |

<a name='T-LootCollection'></a>
## LootCollection [#](#T-LootCollection 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a collection of loot.

<a name='P-LootCollection-DropEquipment'></a>
### DropEquipment `property` [#](#P-LootCollection-DropEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not a piece of equipment dropped.

##### Returns

True if equipment dropped; false otherwise.

<a name='M-LootCollection-GetNextEquipment'></a>
### GetNextEquipment() `method` [#](#M-LootCollection-GetNextEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the next piece of equipment from the loot collection.

##### Returns

An equipment object.

##### Parameters

This method has no parameters.

<a name='T-MoveDirection'></a>
## MoveDirection [#](#T-MoveDirection 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents the last direction moved.

<a name='F-MoveDirection-Left'></a>
### Left `constants` [#](#F-MoveDirection-Left 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Moved to the left.

<a name='F-MoveDirection-Right'></a>
### Right `constants` [#](#F-MoveDirection-Right 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Moved to the right.

<a name='T-MovementController'></a>
## MovementController [#](#T-MovementController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the movement of the character.

<a name='P-MovementController-CurrentVelocity'></a>
### CurrentVelocity `property` [#](#P-MovementController-CurrentVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The current velocity of the character.

<a name='P-MovementController-MaxSpeed'></a>
### MaxSpeed `property` [#](#P-MovementController-MaxSpeed 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets or sets the maximum speed of the character.

<a name='P-MovementController-SeekTargetDistance'></a>
### SeekTargetDistance `property` [#](#P-MovementController-SeekTargetDistance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

How close the character wants to get to their target.

<a name='P-MovementController-SeekTargetDistanceSquared'></a>
### SeekTargetDistanceSquared `property` [#](#P-MovementController-SeekTargetDistanceSquared 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The seek target distance squared for more efficient vector calculations.

<a name='M-MovementController-ApplyForce-System-Single,UnityEngine-Vector3-'></a>
### ApplyForce(potency,position) `method` [#](#M-MovementController-ApplyForce-System-Single,UnityEngine-Vector3- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Applies an external force to the character.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| potency | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The potency of the force to apply. |
| position | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The position to apply force from. |

<a name='M-MovementController-FixedUpdate'></a>
### FixedUpdate() `method` [#](#M-MovementController-FixedUpdate 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the character's movement every physics tick.

##### Parameters

This method has no parameters.

<a name='M-MovementController-GenerateFleeBehaviours'></a>
### GenerateFleeBehaviours() `method` [#](#M-MovementController-GenerateFleeBehaviours 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generates movement behaviours to avoid all other characters. Avoid in this sense means they will not move on top of them.

##### Parameters

This method has no parameters.

<a name='M-MovementController-GenerateMovementBehaviours'></a>
### GenerateMovementBehaviours() `method` [#](#M-MovementController-GenerateMovementBehaviours 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Decorates the base idle movement behaviour with other movement behaviours appropriate to the character and situation.

##### Parameters

This method has no parameters.

<a name='M-MovementController-GenerateSeekBehaviour'></a>
### GenerateSeekBehaviour() `method` [#](#M-MovementController-GenerateSeekBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Generates movement behaviour to seek the current target.

##### Parameters

This method has no parameters.

<a name='M-MovementController-Move'></a>
### Move() `method` [#](#M-MovementController-Move 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Moves a character according to their current movement behaviours.

##### Parameters

This method has no parameters.

<a name='M-MovementController-Start'></a>
### Start() `method` [#](#M-MovementController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the character's movement.

##### Parameters

This method has no parameters.

<a name='T-PopupBackButton'></a>
## PopupBackButton [#](#T-PopupBackButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls a button to go back from a popup window.

<a name='M-PopupBackButton-ClosePopup'></a>
### ClosePopup() `method` [#](#M-PopupBackButton-ClosePopup 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Closes the popup when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-PopupBackButton-Start'></a>
### Start() `method` [#](#M-PopupBackButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T-CustomGizmo-Properties'></a>
## Properties [#](#T-CustomGizmo-Properties 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

CustomGizmo

##### Summary

Properties of the gizmo.

<a name='T-Queue'></a>
## Queue [#](#T-Queue 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a queue of enemies.

<a name='P-Queue-Enemies'></a>
### Enemies `property` [#](#P-Queue-Enemies 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

List of enemies in the queue.

<a name='T-QueueController'></a>
## QueueController [#](#T-QueueController 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the behaviour of an enemy queue during gameplay.

<a name='P-QueueController-IsRepeating'></a>
### IsRepeating `property` [#](#P-QueueController-IsRepeating 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether this queue is repeating the spawn list.

<a name='P-QueueController-IsSpawning'></a>
### IsSpawning `property` [#](#P-QueueController-IsSpawning 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether this queue is actively spawning characters.

<a name='M-QueueController-SpawnNext'></a>
### SpawnNext() `method` [#](#M-QueueController-SpawnNext 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the character at spawnIndex from the queue.

##### Parameters

This method has no parameters.

<a name='M-QueueController-Start'></a>
### Start() `method` [#](#M-QueueController-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the queue controller.

##### Parameters

This method has no parameters.

<a name='M-QueueController-Update'></a>
### Update() `method` [#](#M-QueueController-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the queue controller every frame.

##### Parameters

This method has no parameters.

<a name='T-QueueManager'></a>
## QueueManager [#](#T-QueueManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages all the queues on a stage.

<a name='M-QueueManager-#ctor'></a>
### #ctor() `constructor` [#](#M-QueueManager-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Consructs the queue manager.

##### Parameters

This constructor has no parameters.

<a name='P-QueueManager-HasQueues'></a>
### HasQueues `property` [#](#P-QueueManager-HasQueues 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not there are queues on the stage.

<a name='P-QueueManager-QueuesAreComplete'></a>
### QueuesAreComplete `property` [#](#P-QueueManager-QueuesAreComplete 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the queues and the enemies they have spawned are completed.

<a name='P-QueueManager-QueuesAreSpawning'></a>
### QueuesAreSpawning `property` [#](#P-QueueManager-QueuesAreSpawning 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns whether or not any of the queues are still spawning enemies.

<a name='T-RandomLootCollection'></a>
## RandomLootCollection [#](#T-RandomLootCollection 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a random collection of loot.

<a name='P-RandomLootCollection-DropEquipment'></a>
### DropEquipment `property` [#](#P-RandomLootCollection-DropEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not equipment dropped.

<a name='M-RandomLootCollection-GetNextEquipment'></a>
### GetNextEquipment() `method` [#](#M-RandomLootCollection-GetNextEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get the next piece of equipment that drops.

##### Returns

Equipment object that dropped.

##### Parameters

This method has no parameters.

<a name='T-RegisterList`1'></a>
## RegisterList\`1 [#](#T-RegisterList`1 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a list that objects can register to and unregister from.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='P-RegisterList`1-HasRegisteredEntities'></a>
### HasRegisteredEntities `property` [#](#P-RegisterList`1-HasRegisteredEntities 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not the manager has any registered entities.

<a name='M-RegisterList`1-AddAllToList-System-Collections-Generic-List{`0}@-'></a>
### AddAllToList(addToList) `method` [#](#M-RegisterList`1-AddAllToList-System-Collections-Generic-List{`0}@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds all registered items to the provided list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addToList | [System.Collections.Generic.List{\`0}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{`0}@') | List to add registered items to. |

<a name='M-RegisterList`1-GetAll'></a>
### GetAll() `method` [#](#M-RegisterList`1-GetAll 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Get all the registers items.

##### Returns

List of registered items.

##### Parameters

This method has no parameters.

<a name='M-RegisterList`1-Register-`0-'></a>
### Register(item) `method` [#](#M-RegisterList`1-Register-`0- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Registers an item with the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The item to register. |

<a name='M-RegisterList`1-RemoveAll-System-Boolean-'></a>
### RemoveAll(destroy) `method` [#](#M-RegisterList`1-RemoveAll-System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes all of the regitered items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| destroy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to destroy the items. |

<a name='M-RegisterList`1-Unregister-`0-'></a>
### Unregister(item) `method` [#](#M-RegisterList`1-Unregister-`0- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unregisters an item from the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0](#T-`0 '`0') | The item to unregister. |

<a name='T-ResetButton'></a>
## ResetButton [#](#T-ResetButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the button that resets the game.

<a name='M-ResetButton-ResetGame'></a>
### ResetGame() `method` [#](#M-ResetButton-ResetGame 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Resets the game when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-ResetButton-Start'></a>
### Start() `method` [#](#M-ResetButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T-RosterManager'></a>
## RosterManager [#](#T-RosterManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the roster of allies; keeping track of unlocked allies, assigned allies, etc.

<a name='M-RosterManager-#ctor-SaveGame-'></a>
### #ctor(save) `constructor` [#](#M-RosterManager-#ctor-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the roster manager from saved game data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='P-RosterManager-AllyLevels'></a>
### AllyLevels `property` [#](#P-RosterManager-AllyLevels 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a collection of ally levels; key is ally name, value is level.

<a name='P-RosterManager-MaxAssigned'></a>
### MaxAssigned `property` [#](#P-RosterManager-MaxAssigned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of assigned allies.

<a name='P-RosterManager-MaxUnlocked'></a>
### MaxUnlocked `property` [#](#P-RosterManager-MaxUnlocked 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of unlocked allies.

<a name='P-RosterManager-ResourcePath'></a>
### ResourcePath `property` [#](#P-RosterManager-ResourcePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the resource path for ally objects.

<a name='P-RosterManager-TotalAssignedLevels'></a>
### TotalAssignedLevels `property` [#](#P-RosterManager-TotalAssignedLevels 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the total levels of all assigned allies.

<a name='M-RosterManager-AddUnlocked-System-String,System-Int32,System-Boolean-'></a>
### AddUnlocked(name,level,raiseChangeEvent) `method` [#](#M-RosterManager-AddUnlocked-System-String,System-Int32,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds an unlocked ally to the roster.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the ally to unlock. |
| level | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The level of the unlocked ally. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to raise an event for the roster change. |

<a name='M-RosterManager-Load-SaveGame-'></a>
### Load(save) `method` [#](#M-RosterManager-Load-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads data from a save game into the roster manager.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='M-RosterManager-RemoveUnlocked-System-String,System-Boolean-'></a>
### RemoveUnlocked(name,raiseChangeEvent) `method` [#](#M-RosterManager-RemoveUnlocked-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes an ally from the roster.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the ally to remove. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to raise an event for the roster change. |

<a name='M-RosterManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-RosterManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Fills a save game with data from the roster manager.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='T-SaveGame'></a>
## SaveGame [#](#T-SaveGame 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Stores everything that needs to be persisted across plays.

<a name='M-SaveGame-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor` [#](#M-SaveGame-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for deserializing save game data.

##### Parameters

This constructor has no parameters.

<a name='M-SaveGame-GetObjectData-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### GetObjectData() `method` [#](#M-SaveGame-GetObjectData-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Prepares fields for serialization.

##### Parameters

This method has no parameters.

<a name='T-SaveGameManager'></a>
## SaveGameManager [#](#T-SaveGameManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the save games.

<a name='P-SaveGameManager-SaveGameExists'></a>
### SaveGameExists `property` [#](#P-SaveGameManager-SaveGameExists 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whetehr or not a save game exists.

<a name='P-SaveGameManager-SavePath'></a>
### SavePath `property` [#](#P-SaveGameManager-SavePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Path of the save game data.

<a name='M-SaveGameManager-DeleteSaveGame'></a>
### DeleteSaveGame() `method` [#](#M-SaveGameManager-DeleteSaveGame 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Deletes any existing save game data.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-SaveGameManager-LoadGame'></a>
### LoadGame() `method` [#](#M-SaveGameManager-LoadGame 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads save game data from disk.

##### Returns

The save game data.

##### Parameters

This method has no parameters.

<a name='M-SaveGameManager-SaveGame-SaveGame-'></a>
### SaveGame(saveGame) `method` [#](#M-SaveGameManager-SaveGame-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Saves the provided save game data.

##### Returns

Whether or not the save was successful.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| saveGame | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='T-SceneField'></a>
## SceneField [#](#T-SceneField 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Allows dragging a scene into an inspector field.

<a name='T-SeekMovementBehaviour'></a>
## SeekMovementBehaviour [#](#T-SeekMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to move to the location of the target.

<a name='M-SeekMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single-'></a>
### #ctor(movementBehaviour,agent,target,radius) `constructor` [#](#M-SeekMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-GameObject,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for SeekMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| target | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The target of this movement behaviour. |
| radius | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The radius at which this behaviour is completed. |

<a name='M-SeekMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-SeekMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-Singleton`1'></a>
## Singleton\`1 [#](#T-Singleton`1 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

A Unity Singleton pattern GameObject

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='P-Singleton`1-Instance'></a>
### Instance `property` [#](#P-Singleton`1-Instance 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the current instance of this Singleton.

<a name='T-StageButton'></a>
## StageButton [#](#T-StageButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls a button that takes the player to a stage.

<a name='M-StageButton-CenterIfLastStage'></a>
### CenterIfLastStage() `method` [#](#M-StageButton-CenterIfLastStage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Centers the scroll view on this stage if it was the last stage visited.

##### Parameters

This method has no parameters.

<a name='M-StageButton-LoadStage'></a>
### LoadStage() `method` [#](#M-StageButton-LoadStage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the stage when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-StageButton-Start'></a>
### Start() `method` [#](#M-StageButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='T--StageCompletePopup'></a>
## StageCompletePopup [#](#T--StageCompletePopup 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



<a name='M-StageCompletePopup-EndStage'></a>
### EndStage() `method` [#](#M-StageCompletePopup-EndStage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Ends the stage when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-StageCompletePopup-Start'></a>
### Start() `method` [#](#M-StageCompletePopup-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the popup.

##### Parameters

This method has no parameters.

<a name='T-StageManager'></a>
## StageManager [#](#T-StageManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the functionality of a stage.

<a name='M-StageManager-EndStage-System-Boolean-'></a>
### EndStage() `method` [#](#M-StageManager-EndStage-System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Ends the stage.

##### Parameters

This method has no parameters.

<a name='M-StageManager-GetReward-UnityEngine-Vector2-'></a>
### GetReward() `method` [#](#M-StageManager-GetReward-UnityEngine-Vector2- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Tries to get the next reward from the stage's loot collection.

##### Parameters

This method has no parameters.

<a name='M-StageManager-SpawnBoss'></a>
### SpawnBoss() `method` [#](#M-StageManager-SpawnBoss 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the boss for the stage immediately.

##### Parameters

This method has no parameters.

<a name='M-StageManager-SpawnBossAfterDelay'></a>
### SpawnBossAfterDelay() `method` [#](#M-StageManager-SpawnBossAfterDelay 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Spawns the boss for the stage after the delay specified on the stage manager.

##### Parameters

This method has no parameters.

<a name='M-StageManager-Start'></a>
### Start() `method` [#](#M-StageManager-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the stage manager.

##### Parameters

This method has no parameters.

<a name='T-StaticLootCollection'></a>
## StaticLootCollection [#](#T-StaticLootCollection 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Represents a static collection of equipment loot.

<a name='P-StaticLootCollection-DropEquipment'></a>
### DropEquipment `property` [#](#P-StaticLootCollection-DropEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Whether or not a piece of equipment dropped.

<a name='M-StaticLootCollection-GetNextEquipment'></a>
### GetNextEquipment() `method` [#](#M-StaticLootCollection-GetNextEquipment 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the next piece of equipment to drop.

##### Returns

An equipment object.

##### Parameters

This method has no parameters.

<a name='T-WorldEntityManager-UnlockedListChanged'></a>
## UnlockedListChanged [#](#T-WorldEntityManager-UnlockedListChanged 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

WorldEntityManager

##### Summary

Unlocked list change delegate signature.

<a name='T-UpgradeAllyButton'></a>
## UpgradeAllyButton [#](#T-UpgradeAllyButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the button that upgrades an ally.

<a name='M-UpgradeAllyButton-Awake'></a>
### Awake() `method` [#](#M-UpgradeAllyButton-Awake 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='M-UpgradeAllyButton-Initialize-System-String,UpgradeAllyPopup-'></a>
### Initialize(allyName,list) `method` [#](#M-UpgradeAllyButton-Initialize-System-String,UpgradeAllyPopup- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes the values of the button with an ally.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the ally. |
| list | [UpgradeAllyPopup](#T-UpgradeAllyPopup 'UpgradeAllyPopup') | The popup list of allies. |

<a name='M-UpgradeAllyButton-RefreshButton'></a>
### RefreshButton() `method` [#](#M-UpgradeAllyButton-RefreshButton 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes the button based on ally data.

##### Parameters

This method has no parameters.

<a name='M-UpgradeAllyButton-UpgradeAlly'></a>
### UpgradeAlly() `method` [#](#M-UpgradeAllyButton-UpgradeAlly 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Upgrades the ally when the button is clicked.

##### Parameters

This method has no parameters.

<a name='T-UpgradeAllyPopup'></a>
## UpgradeAllyPopup [#](#T-UpgradeAllyPopup 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the popup list of ally upgrade buttons.

<a name='M-UpgradeAllyPopup-RefreshButtons'></a>
### RefreshButtons() `method` [#](#M-UpgradeAllyPopup-RefreshButtons 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes all of the upgrade ally buttons.

##### Parameters

This method has no parameters.

<a name='M-UpgradeAllyPopup-Start'></a>
### Start() `method` [#](#M-UpgradeAllyPopup-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the popup.

##### Parameters

This method has no parameters.

<a name='T-UpgradeHeroPopup'></a>
## UpgradeHeroPopup [#](#T-UpgradeHeroPopup 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls the upgrade hero popup.

<a name='M-UpgradeHeroPopup-RefreshHeroData'></a>
### RefreshHeroData() `method` [#](#M-UpgradeHeroPopup-RefreshHeroData 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes the hero data displayed on the popup.

##### Parameters

This method has no parameters.

<a name='M-UpgradeHeroPopup-Start'></a>
### Start() `method` [#](#M-UpgradeHeroPopup-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the popup.

##### Parameters

This method has no parameters.

<a name='M-UpgradeHeroPopup-UpgradeHero'></a>
### UpgradeHero() `method` [#](#M-UpgradeHeroPopup-UpgradeHero 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Upgrades the hero when the button is clicked.

##### Parameters

This method has no parameters.

<a name='T-Vector3Extensions'></a>
## Vector3Extensions [#](#T-Vector3Extensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Extends the Unity Vector3 type.

<a name='M-Vector3Extensions-SqrDistance-UnityEngine-Vector3,UnityEngine-Vector3-'></a>
### SqrDistance(source,destination) `method` [#](#M-Vector3Extensions-SqrDistance-UnityEngine-Vector3,UnityEngine-Vector3- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the squared distance between two vectors.

##### Returns

A float representing the squared distance between the vectors.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The source vector. |
| destination | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The destination vector. |

<a name='T-WalkMovementBehaviour'></a>
## WalkMovementBehaviour [#](#T-WalkMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to move to a location.

<a name='M-WalkMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single-'></a>
### #ctor(movementBehaviour,agent,location) `constructor` [#](#M-WalkMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for WalkMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| location | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The target of this movement behaviour. |

<a name='F-WalkMovementBehaviour-location'></a>
### location `constants` [#](#F-WalkMovementBehaviour-location 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Location this behaviour will desire to walk toward.

<a name='M-WalkMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-WalkMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-WanderMovementBehaviour'></a>
## WanderMovementBehaviour [#](#T-WanderMovementBehaviour 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

When an agent has this movement behaviour it will actively desire to wander around the stage.

<a name='M-WanderMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single-'></a>
### #ctor(movementBehaviour,agent,location,radius) `constructor` [#](#M-WanderMovementBehaviour-#ctor-AbstractMovementBehaviour,UnityEngine-GameObject,UnityEngine-Vector2,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructor for WanderMovementBehaviour instances.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| movementBehaviour | [AbstractMovementBehaviour](#T-AbstractMovementBehaviour 'AbstractMovementBehaviour') | The movement behaviour to decorate. |
| agent | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The GameObject that desires this movement behaviour. |
| location | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The original location from which the agent will wander. |
| radius | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The radius at which this behaviour will wander. |

<a name='M-WanderMovementBehaviour-CalculateDesiredVelocity'></a>
### CalculateDesiredVelocity() `method` [#](#M-WanderMovementBehaviour-CalculateDesiredVelocity 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

The velocity desired by this movement behaviour.

##### Returns

The optimal velocity vector to accomplish this movement behaviour.

##### Parameters

This method has no parameters.

<a name='T-WorldEntityButton'></a>
## WorldEntityButton [#](#T-WorldEntityButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls a world entity button.

<a name='M-WorldEntityButton-Awake'></a>
### Awake() `method` [#](#M-WorldEntityButton-Awake 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityButton-HandleAssignClick'></a>
### HandleAssignClick() `method` [#](#M-WorldEntityButton-HandleAssignClick 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Assigns the world entity when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityButton-HandleClick'></a>
### HandleClick() `method` [#](#M-WorldEntityButton-HandleClick 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Handles the button click based on the specified action.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityButton-HandleUseClick'></a>
### HandleUseClick() `method` [#](#M-WorldEntityButton-HandleUseClick 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Uses the world entity when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityButton-Initialize-System-String,ButtonAction,WorldEntityManager-'></a>
### Initialize(entityName,buttonAction,manager) `method` [#](#M-WorldEntityButton-Initialize-System-String,ButtonAction,WorldEntityManager- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes the button with data from the world entity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the entity. |
| buttonAction | [ButtonAction](#T-ButtonAction 'ButtonAction') | The action taken when the button is clicked. |
| manager | [WorldEntityManager](#T-WorldEntityManager 'WorldEntityManager') | The world entity manager for this type of entity. |

<a name='M-WorldEntityButton-Update'></a>
### Update() `method` [#](#M-WorldEntityButton-Update 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Updates the button based on world state.

##### Parameters

This method has no parameters.

<a name='T-WorldEntityList'></a>
## WorldEntityList [#](#T-WorldEntityList 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls a list of world entities.

<a name='M-WorldEntityList-AddButtons'></a>
### AddButtons() `method` [#](#M-WorldEntityList-AddButtons 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds button based on the content of the list.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityList-OnDestroy'></a>
### OnDestroy() `method` [#](#M-WorldEntityList-OnDestroy 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unsubscribes from refresh events when destroyed.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityList-RefreshDisplay'></a>
### RefreshDisplay() `method` [#](#M-WorldEntityList-RefreshDisplay 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Refreshes the list.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityList-RemoveButtons'></a>
### RemoveButtons() `method` [#](#M-WorldEntityList-RemoveButtons 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes all existing buttons.

##### Parameters

This method has no parameters.

<a name='M-WorldEntityList-Start'></a>
### Start() `method` [#](#M-WorldEntityList-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the list.

##### Parameters

This method has no parameters.

<a name='T-WorldEntityManager'></a>
## WorldEntityManager [#](#T-WorldEntityManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Abstract class for managing world entities. World entities are entities that are not dependent upon the stage such as roster allies, inventory equipment, etc.

<a name='M-WorldEntityManager-#ctor-SaveGame-'></a>
### #ctor(save) `constructor` [#](#M-WorldEntityManager-#ctor-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') |  |

<a name='P-WorldEntityManager-Assigned'></a>
### Assigned `property` [#](#P-WorldEntityManager-Assigned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of assigned entities.

<a name='P-WorldEntityManager-MaxAssigned'></a>
### MaxAssigned `property` [#](#P-WorldEntityManager-MaxAssigned 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount of assigned world entities.

<a name='P-WorldEntityManager-MaxUnlocked'></a>
### MaxUnlocked `property` [#](#P-WorldEntityManager-MaxUnlocked 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the maximum amount unlocked world entities.

<a name='P-WorldEntityManager-ResourcePath'></a>
### ResourcePath `property` [#](#P-WorldEntityManager-ResourcePath 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the resource path of the world entities.

<a name='P-WorldEntityManager-Unlocked'></a>
### Unlocked `property` [#](#P-WorldEntityManager-Unlocked 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns a list of unlocked entities.

<a name='M-WorldEntityManager-AddAssigned-System-String,System-Boolean-'></a>
### AddAssigned(name,raiseChangeEvent) `method` [#](#M-WorldEntityManager-AddAssigned-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a world entity to the list of assigned entities.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the world entity. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to raise the assigned change event. |

<a name='M-WorldEntityManager-AddUnlocked-System-String,System-Boolean-'></a>
### AddUnlocked(name,raiseChangeEvent) `method` [#](#M-WorldEntityManager-AddUnlocked-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a world entity to the list of unlocked entities.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the world entity. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not the raise the unlocked change event. |

<a name='M-WorldEntityManager-GetEntityObject-System-String-'></a>
### GetEntityObject(name) `method` [#](#M-WorldEntityManager-GetEntityObject-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the scriptable object for the world entity.

##### Returns

The scriptable object for the entity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the world entity. |

<a name='M-WorldEntityManager-Load-SaveGame-'></a>
### Load(save) `method` [#](#M-WorldEntityManager-Load-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Initializes the world entity manager from a saved game.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='M-WorldEntityManager-RaiseChangeEvent-WorldEntityListType-'></a>
### RaiseChangeEvent(type) `method` [#](#M-WorldEntityManager-RaiseChangeEvent-WorldEntityListType- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Raises the list change event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [WorldEntityListType](#T-WorldEntityListType 'WorldEntityListType') | The type of list to raise the event for; unlocked or assigned. |

<a name='M-WorldEntityManager-RemoveAssigned-System-String,System-Boolean-'></a>
### RemoveAssigned(name,raiseChangeEvent) `method` [#](#M-WorldEntityManager-RemoveAssigned-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes a world entity from the list of assigned entities.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the world entity. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to raise the assigned change event. |

<a name='M-WorldEntityManager-RemoveUnlocked-System-String,System-Boolean-'></a>
### RemoveUnlocked(name,raiseChangeEvent) `method` [#](#M-WorldEntityManager-RemoveUnlocked-System-String,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Removes a world entity from the list of unlocked entites.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the world entity. |
| raiseChangeEvent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to raise the unlocked change event. |

<a name='M-WorldEntityManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-WorldEntityManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Fills a save game with data from the world entity manager.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='T-WorldManager'></a>
## WorldManager [#](#T-WorldManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Manages the state of the world, such as unlocked zones and stages.

<a name='M-WorldManager-#ctor-SaveGame-'></a>
### #ctor(save) `constructor` [#](#M-WorldManager-#ctor-SaveGame- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Constructs the world manager from save game data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame](#T-SaveGame 'SaveGame') | The save game data. |

<a name='P-WorldManager-LastIdleFactor'></a>
### LastIdleFactor `property` [#](#P-WorldManager-LastIdleFactor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the idle factor of the highest stage.

<a name='P-WorldManager-LastStage'></a>
### LastStage `property` [#](#P-WorldManager-LastStage 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the last stage the hero was on.

<a name='P-WorldManager-LastZone'></a>
### LastZone `property` [#](#P-WorldManager-LastZone 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the last zone the hero was on.

<a name='P-WorldManager-UnlockedStages'></a>
### UnlockedStages `property` [#](#P-WorldManager-UnlockedStages 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the list of unlocked stages.

<a name='P-WorldManager-UnlockedZones'></a>
### UnlockedZones `property` [#](#P-WorldManager-UnlockedZones 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Returns the list of unlocked zones.

<a name='M-WorldManager-Save-SaveGame@-'></a>
### Save(save) `method` [#](#M-WorldManager-Save-SaveGame@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Fills a save game with world manager data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| save | [SaveGame@](#T-SaveGame@ 'SaveGame@') | The save game data. |

<a name='M-WorldManager-SetIdleFactor-System-Single-'></a>
### SetIdleFactor(idleRewardsFactor) `method` [#](#M-WorldManager-SetIdleFactor-System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets the idle factor to a new value if it is larger.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| idleRewardsFactor | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | New potential idle factor. |

<a name='M-WorldManager-SetLastStage-System-String-'></a>
### SetLastStage(stage) `method` [#](#M-WorldManager-SetLastStage-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets the last stage the hero was on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the stage. |

<a name='M-WorldManager-SetLastZone-System-String-'></a>
### SetLastZone(zone) `method` [#](#M-WorldManager-SetLastZone-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets the last zone the hero was on.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| zone | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the zone. |

<a name='M-WorldManager-UnlockStage-System-String-'></a>
### UnlockStage(stage) `method` [#](#M-WorldManager-UnlockStage-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unlocks a stage.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the stage to unlock. |

<a name='M-WorldManager-UnlockZone-System-String-'></a>
### UnlockZone(zone) `method` [#](#M-WorldManager-UnlockZone-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Unlocks a zone.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| zone | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the zone to unlock. |

<a name='T-ZoneButton'></a>
## ZoneButton [#](#T-ZoneButton 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace



##### Summary

Controls a button that loads a zone.

<a name='M-ZoneButton-CenterIfLastZone'></a>
### CenterIfLastZone() `method` [#](#M-ZoneButton-CenterIfLastZone 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Centers the scroll view on this butotn if it was the last zone visited.

##### Parameters

This method has no parameters.

<a name='M-ZoneButton-LoadZone'></a>
### LoadZone() `method` [#](#M-ZoneButton-LoadZone 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the zone scene when the button is clicked.

##### Parameters

This method has no parameters.

<a name='M-ZoneButton-Start'></a>
### Start() `method` [#](#M-ZoneButton-Start 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets up the button.

##### Parameters

This method has no parameters.
