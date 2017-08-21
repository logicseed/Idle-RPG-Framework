using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the game.
/// </summary>
public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    protected GameSettings gameSettings;
    protected bool onStage = false;

    protected AbilityManager abilityManager;
    protected AllyManager allyManager;
    protected BossManager bossManager;
    protected EnemyManager enemyManager;
    protected HeroManager heroManager;
    protected InventoryManager inventoryManager;
    protected QueueManager queueManager;
    protected RosterManager rosterManager;
    protected StageManager stageManager;
    protected WorldManager worldManager;

    protected DateTime lastRewardTime;
    protected float partialRewards;

    /// <summary>
    /// Performs initialization prior to next frame.
    /// </summary>
    protected override void Awake()
    {
        base.Awake();

        InitializeWorldEntityManagers();
        InitializeStageEntityManagers();
        InitializeGameWorldManagers();

        SceneManager.activeSceneChanged += OnSceneChanged;
    }

    /// <summary>
    /// Keeps track of a spawned boss and ends the stage after its death.
    /// </summary>
    /// <param name="boss">The boss to keep track of.</param>
    protected IEnumerator CheckBoss(BossController boss)
    {
        while (boss != null && boss.CharacterState != CharacterState.Dead)
        {
            yield return new WaitForSeconds(1.0f);
        }
        StageManager.EndStage();
    }

    /// <summary>
    /// Initialize game world managers.
    /// </summary>
    protected void InitializeGameWorldManagers()
    {
        SaveGame save = null;
        if (SaveGameManager.SaveGameExists) save = SaveGameManager.LoadGame();

        worldManager = new WorldManager(save);

        if (save != null) lastRewardTime = save.LastRewardTime;
        else lastRewardTime = DateTime.Now;
    }

    /// <summary>
    /// Initializes the world.
    /// </summary>
    public static void InitializeWorld()
    {
        if (WorldManager.LastZone != null && WorldManager.LastZone != String.Empty)
        {
            LoadZone(WorldManager.LastZone);
            return;
        }
        LoadWorld();
    }

    /// <summary>
    /// Initialize world entity managers.
    /// </summary>
    protected void InitializeWorldEntityManagers()
    {
        SaveGame save = null;
        if (SaveGameManager.SaveGameExists) save = SaveGameManager.LoadGame();

        heroManager = HeroManager.Load(save);
        abilityManager = new AbilityManager(save);
        rosterManager = new RosterManager(save);
        inventoryManager = new InventoryManager(save);
    }

    /// <summary>
    /// Loads the user interface for a stage scene.
    /// </summary>
    protected void LoadStageUi()
    {
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.HeroStageInformation, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.AbilityUsePanel, uiCanvas.transform, false);
    }

    /// <summary>
    /// Loads the user interface for the world scene.
    /// </summary>
    protected void LoadWorldUi()
    {
        // Spawn UiCanvas
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.AssignmentPanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.UpgradePanel, uiCanvas.transform, false);
        if (GameSettings.ShowResetButton) Instantiate(GameSettings.Prefab.UI.ResetButton, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.ExperienceText, uiCanvas.transform, false);
    }

    /// <summary>
    /// Loads the user interface for a zone scene.
    /// </summary>
    protected void LoadZoneUi()
    {
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.AssignmentPanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.UpgradePanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.BackToWorldButton, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.ExperienceText, uiCanvas.transform, false);
    }

    /// <summary>
    /// Called when the game manager is destroyed.
    /// </summary>
    protected void OnDestroy()
    {
        SaveGame();
        SceneManager.activeSceneChanged -= OnSceneChanged;
    }

    /// <summary>
    /// Called when the scene changes.
    /// </summary>
    /// <param name="previousScene">The previous scene.</param>
    /// <param name="newScene">The new scene.</param>
    protected void OnSceneChanged(Scene previousScene, Scene newScene)
    {
        if (newScene.name == "Start") return;
        if (newScene.name == "World")
        {
            LoadWorldUi();
            return;
        }

        var sceneType = newScene.path.Split('/')[2];

        if (sceneType == "Zones") LoadZoneUi();
        else LoadStageUi();
    }

    /// <summary>
    /// Sets up the game manager.
    /// </summary>
    protected void Start()
    {
        DontDestroyOnLoad(gameObject);
        InitializeWorld();
    }

    /// <summary>
    /// Updates the game manager every frame.
    /// </summary>
    protected void Update()
    {
        if (onStage && QueueManager != null && HeroManager.Hero != null)
        {
            // End stage conditions.
            if (QueueManager.QueuesAreComplete || HeroManager.Hero.IsDead)
            {
                onStage = false;
                lastRewardTime = DateTime.Now;
                StageManager.EndStage();
            }
        }

        if (!onStage)
        {
            GenerateIdleRewards();
        }
    }

    /// <summary>
    /// Generate idle rewards per frame.
    /// </summary>
    protected void GenerateIdleRewards()
    {
        var rewardSeconds = (DateTime.Now - lastRewardTime).TotalSeconds;
        lastRewardTime = DateTime.Now;

        var maxRewardSeconds = GameManager.GameSettings.Max.RewardTime * 3600;
        if (rewardSeconds > maxRewardSeconds) rewardSeconds = maxRewardSeconds;

        var newExperience = 0.0f;

        newExperience += RosterManager.TotalAssignedLevels + HeroManager.Level;
        newExperience *= WorldManager.LastIdleFactor;
        newExperience *= (float)rewardSeconds;

        newExperience += partialRewards;
        partialRewards = 0.0f;
        if (newExperience > 1.0f)
        {
            HeroManager.Experience += (int)newExperience;
            partialRewards = newExperience - (int)newExperience;
        }
        else
        {
            partialRewards = newExperience;
        }
    }

    /// <summary>
    /// Returns the ability manager.
    /// </summary>
    public static AbilityManager AbilityManager { get { return GameManager.Instance.abilityManager; } }

    /// <summary>
    /// Returns a list of all characters on the stage.
    /// </summary>
    public static List<GameCharacterController> AllCharacters
    {
        get
        {
            var allCharacters = new List<GameCharacterController>();

            if (EnemyManager != null) EnemyManager.AddAllToList(ref allCharacters);
            if (BossManager != null) BossManager.AddAllToList(ref allCharacters);
            if (AllyManager != null) AllyManager.AddAllToList(ref allCharacters);
            if (HeroManager != null) HeroManager.AddHeroToList(ref allCharacters);

            return allCharacters;
        }
    }

    /// <summary>
    /// Returns a list of all enemies on the stage.
    /// </summary>
    public static List<GameCharacterController> AllEnemies
    {
        get
        {
            var allEnemies = new List<GameCharacterController>();

            if (EnemyManager != null) EnemyManager.AddAllToList(ref allEnemies);
            if (BossManager != null) BossManager.AddAllToList(ref allEnemies);

            return allEnemies;
        }
    }

    /// <summary>
    /// Returns a list of all friendlies on the stage.
    /// </summary>
    public static List<GameCharacterController> AllFriendlies
    {
        get
        {
            var allFriendlies = new List<GameCharacterController>();

            if (AllyManager != null) AllyManager.AddAllToList(ref allFriendlies);
            if (HeroManager != null) HeroManager.AddHeroToList(ref allFriendlies);

            return allFriendlies;
        }
    }

    /// <summary>
    /// Returns the stage ally manager.
    /// </summary>
    public static AllyManager AllyManager { get { return GameManager.Instance.allyManager; } }

    /// <summary>
    /// Returns the stage boss manager.
    /// </summary>
    public static BossManager BossManager { get { return GameManager.Instance.bossManager; } }

    /// <summary>
    /// Whether or not the hero can be upgraded.
    /// </summary>
    public static bool CanUpgradeHero
    {
        get
        {
            return UpgradeHeroCost <= GameManager.HeroManager.Experience;
        }
    }

    /// <summary>
    /// Returns the stage enemy manager.
    /// </summary>
    public static EnemyManager EnemyManager { get { return GameManager.Instance.enemyManager; } }

    /// <summary>
    /// Returns the game settings.
    /// </summary>
    public static GameSettings GameSettings { get { return GameManager.Instance.gameSettings; } }

    /// <summary>
    /// Returns the hero controller.
    /// </summary>
    public static HeroController Hero { get { return GameManager.Instance.heroManager.Hero; } }

    /// <summary>
    /// Returns the hero manager.
    /// </summary>
    public static HeroManager HeroManager { get { return GameManager.Instance.heroManager; } }
    /// <summary>
    /// Returns the inventory manager.
    /// </summary>
    public static InventoryManager InventoryManager { get { return GameManager.Instance.inventoryManager; } }

    /// <summary>
    /// Returns the stage queue manager.
    /// </summary>
    public static QueueManager QueueManager { get { return GameManager.Instance.queueManager; } }

    /// <summary>
    /// Returns the roster manager.
    /// </summary>
    public static RosterManager RosterManager { get { return GameManager.Instance.rosterManager; } }

    /// <summary>
    /// Returns the current stage manager.
    /// </summary>
    public static StageManager StageManager { get { return GameManager.Instance.stageManager; } set { GameManager.Instance.stageManager = value; } }

    /// <summary>
    /// The cost of the next hero upgrade.
    /// </summary>
    public static int UpgradeHeroCost
    {
        get
        {
            return (int)(GameManager.HeroManager.Level * GameManager.GameSettings.Constants.UpgradeHeroCost);
        }
    }

    /// <summary>
    /// Returns the world manager.
    /// </summary>
    public static WorldManager WorldManager { get { return GameManager.Instance.worldManager; } }

    /// <summary>
    /// Returns a list of all characters on the stage except the specified character.
    /// </summary>
    /// <param name="self">The character on the stage that isn't included in the list.</param>
    /// <returns>A list of characters on the stage.</returns>
    public static List<GameCharacterController> AllCharactersExcept(GameCharacterController self)
    {
        var allExceptSelf = AllCharacters;
        allExceptSelf.Remove(self);
        return allExceptSelf;
    }

    /// <summary>
    /// Whether or not the specified ally can be upgraded.
    /// </summary>
    /// <param name="allyName">The name of the ally to upgrade.</param>
    /// <returns>Whether or not the ally can be upgraded.</returns>
    public static bool CanUpgradeAlly(string allyName)
    {
        return UpgradeAllyCost(allyName) <= GameManager.HeroManager.Experience;
    }

    /// <summary>
    /// Gets a world entity manager corresponding to the specified type.
    /// </summary>
    /// <param name="entityType">The type of entity to get the manager of.</param>
    /// <returns>The world entity manager for the specified type.</returns>
    public static WorldEntityManager GetManagerByType(ListableEntityType entityType)
    {
        switch (entityType)
        {
            case ListableEntityType.Ability: return AbilityManager;
            case ListableEntityType.Inventory: return InventoryManager;
            case ListableEntityType.Roster: return RosterManager;

            case ListableEntityType.NonListable: default: return null;
        }
    }

    /// <summary>
    /// Loads a stage.
    /// </summary>
    /// <param name="stage">The sage to load.</param>
    public static void LoadStage(SceneField stage)
    {
        if (WorldManager.UnlockedStages.Contains(stage))
        {
            Debug.Log("Loading stage: " + stage);
            WorldManager.SetLastStage(stage);
            GameManager.Instance.onStage = true;
            GameManager.Instance.InitializeStageEntityManagers();
            SceneManager.LoadScene(stage);
        }
    }

    /// <summary>
    /// Loads the world scene.
    /// </summary>
    public static void LoadWorld()
    {
        SceneManager.LoadScene("World");
    }

    /// <summary>
    /// Loads a zone.
    /// </summary>
    /// <param name="zone">The name of the zone to load.</param>
    public static void LoadZone(string zone)
    {
        if (WorldManager.UnlockedZones.Contains(zone))
        {
            Debug.Log("Loading zone: " + zone);
            WorldManager.SetLastZone(zone);
            SceneManager.LoadScene(zone);
        }
    }

    /// <summary>
    /// Upgrades the specified ally.
    /// </summary>
    /// <param name="allyName">The name of the ally to upgrade.</param>
    public static void UpgradeAlly(string allyName)
    {
        if (CanUpgradeAlly(allyName))
        {
            GameManager.HeroManager.Experience -= UpgradeAllyCost(allyName);
            GameManager.RosterManager.AllyLevels[allyName]++;
        }
    }

    /// <summary>
    /// Gets the cost of the next upgrade for the specified ally.
    /// </summary>
    /// <param name="allyName">THe name of the ally to upgrade.</param>
    /// <returns>The experience cost of the next upgrade for the ally.</returns>
    public static int UpgradeAllyCost(string allyName)
    {
        return (int)(GameManager.RosterManager.AllyLevels[allyName] * GameManager.GameSettings.Constants.UpgradeAllyCost);
    }

    /// <summary>
    /// Upgrades the hero.
    /// </summary>
    public static void UpgradeHero()
    {
        if (CanUpgradeHero)
        {
            GameManager.HeroManager.Experience -= UpgradeHeroCost;
            GameManager.HeroManager.Level++;
        }
    }

    /// <summary>
    /// Initializes the stage entity managers.
    /// </summary>
    public void InitializeStageEntityManagers()
    {
        allyManager = new AllyManager();
        enemyManager = new EnemyManager();
        bossManager = new BossManager();
        queueManager = new QueueManager();
    }

    /// <summary>
    /// Saves the game.
    /// </summary>
    public void SaveGame()
    {
        var save = new SaveGame();

        if (HeroManager != null) HeroManager.Save(ref save);
        if (AbilityManager != null) AbilityManager.Save(ref save);
        if (RosterManager != null) RosterManager.Save(ref save);
        if (InventoryManager != null) InventoryManager.Save(ref save);
        if (WorldManager != null) WorldManager.Save(ref save);
        save.LastRewardTime = lastRewardTime;
        save.IsFilled = true;

        SaveGameManager.SaveGame(save);
    }

    /// <summary>
    /// Called when application is paused.
    /// </summary>
    /// <param name="pause"></param>
    public void OnApplicationPause(bool pause) { SaveGame(); }

    /// <summary>
    /// Called when application is quit.
    /// </summary>
    public void OnApplicationQuit() { SaveGame(); }
}