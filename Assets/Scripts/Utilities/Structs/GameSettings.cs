using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides an inspector interface for constant game values.
/// </summary>
[Serializable]
public class GameSettings
{
    [Header("Starting values for the hero.")]
    public StartContainer CharacterStart;
    [Serializable] public class StartContainer
    {
        public int Experience = 0;
        public int Level = 1;
        public List<string> Zones;
        public List<string> Stages;
        public List<string> Inventory;
        public List<string> Roster;
        public List<string> Abilities;
    }

    [Header("Various gameplay constants.")]
    public ConstantsContainer Constants;
    [Serializable] public class ConstantsContainer
    {
        
        public float EquipmentDropChance = 0.5f;
        public float ExperiencePerLevel = 1000.0f;
        public float DefenseLength = 10;
        public float DefensePercent = 0.5f;
        public float UpgradeHeroCost = 10000;
        public float UpgradeAllyCost = 8000;

        public CharacterContainer Character;
        [Serializable] public class CharacterContainer
        {
            public float RigidbodyGravityScale = 0.0f;
            public float RigidbodyDrag = 100;
            public float RigidbodyAngularDrag = 100;
            public float RigidbodyMass = 100;

            public Vector2 ColliderOffset = new Vector2(0.0f, -0.275f);
            public Vector2 ColliderSize = new Vector2(0.4f, 0.2f);
            public CapsuleDirection2D ColliderDirection = CapsuleDirection2D.Horizontal;

            public float VelocityFactor = 200;
            public float Acceleration = 0.1f;
        }
        public RangeContainer Range;
        [Serializable] public class RangeContainer
        {
            public float MeleeAttack = 0.5f;
            public float CasterAttack = 2.0f;
            public float RangedAttack = 3.0f;
            public float DirectAbilityHit = 0.05f;
            public float Touch = 0.2f;
            public float SeekLocation = 0.01f;
            [HideInInspector] public float SeekLocationSqr { get { return SeekLocation * SeekLocation; } }
            public float AvoidDistance = 0.5f;
        }
        public CombatTextContainer CombatText;
        [Serializable] public class CombatTextContainer
        {
            public string BlockedText = "BLOCKED";
            public string NormalText = "";
            public string CriticalText = "CRITICAL";
            public float DisplayTime = 2.0f;
            public float FloatDistance = 2.0f;
            public float HorizontalShift = 0.5f;
        }

        public ColorContainer Colors;
        [Serializable] public class ColorContainer
        {
            public Color CombatTextBlocked = Color.green;
            public Color CombatTextNormal = Color.yellow;
            public Color CombatTextCritical = Color.red;
            public Color FloatingBarForeground = Color.green;
            public Color FloatingBarBackground = Color.red;
        }

        public CombatTimeContainer CombatTime;
        [Serializable] public class CombatTimeContainer
        {
            public float SpawnCasterBallDelay = 0.25f;
            public float SpawnArrowDelay = 0.5f;
            public float DespawnBodyDelay = 1.0f;
        }
    }

    [Header("Maximum gameplay values.")]
    public MaximumContainer Max;
    [Serializable] public class MaximumContainer
    {
        public float RewardTime = 8.0f;
        public EntityContainer Abilities = new EntityContainer(9999, 4);
        public EntityContainer Equipment = new EntityContainer(9999, 9999);
        public EntityContainer Allies = new EntityContainer(9999, 3);
        [Serializable] public class EntityContainer
        {
            public int Unlocked;
            public int Assigned;
            public EntityContainer(int unlocked, int assigned) { Unlocked = unlocked; Assigned = assigned; }
        }

        public AttributeFactorContainer AttributeFactor;
        [Serializable] public class AttributeFactorContainer
        {
            public int AttackDamage = 100;
            public int AbilityDamage = 100;
            public int Defense = 50;
            public int Health = 500;
            public int HealthRegeneration = 20;
            public int Energy = 400;
            public int EnergyRegeneration = 15;
            public float AttackSpeed = 2.0f;
            public float CriticalHitChance = 0.5f;
            public float CriticalHitDamage = 1.0f;
            public float CooldownReduction = 0.5f;
            public float LifeDrain = 0.5f;
            public float MovementSpeed = 0.05f;
        }
    }

    [Header("Resource paths.")]
    public PathContainer Path;
    [Serializable] public class PathContainer
    {
        public string Abilities = "Abilities/";
        public string Equipment = "Equipment/";
        public string Allies = "Allies/";
    }

    [Header("Resource prefabs.")]
    public PrefabContainer Prefab;
    [Serializable] public class PrefabContainer
    {
        public GameObject Hero;
        public GameObject Ally;
        public GameObject Enemy;

        public EffectContainer Effect;
        [Serializable] public class EffectContainer
        {
            public GameObject Arrow;
            public GameObject Casterball;
            public GameObject Storm;
            public GameObject Fireball;
        }

        public UIContainer UI;
        [Serializable] public class UIContainer
        {
            public GameObject CombatText;
            public GameObject DroppedEquipment;
            public GameObject FloatingBar;
            public GameObject UiCanvas;
            public GameObject WorldEntityButton;
            public GameObject BackToWorldButton;
            public GameObject ResetButton;
            public GameObject AbilitySelection;
            public GameObject InventorySelection;
            public GameObject RosterSelection;
            public GameObject AssignmentPanel;
            public GameObject UpgradePanel;
            public GameObject UpgradeHeroPopup;
            public GameObject UpgradeAlliesPopup;
            public GameObject UpgradeAllyButton;
            public GameObject ExperienceText;
            public GameObject AbilityUsePanel;
            public GameObject HeroStageInformation;
            public GameObject StageCompletePopup;
        }
    }

    public bool ShowResetButton = false;
}
