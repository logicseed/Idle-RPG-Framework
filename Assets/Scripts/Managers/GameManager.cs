using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
///
/// </summary>
public class GameManager : Singleton<GameManager>
{
    //[Header("Settings")]
    public GameSettings gameSettings;
    //public UserSettings userSettings;

    //[Header("World Entity Managers")]
    [HideInInspector] public HeroManager heroManager;
    [HideInInspector] public RosterManager rosterManager;
    [HideInInspector] public InventoryManager inventoryManager;
    [HideInInspector] public AbilityManager abilityManager;
    [HideInInspector] public WorldManager worldManager;
    [HideInInspector] public ZoneManager zoneManager;
    [HideInInspector] public StageManager stageManager;

    //[Header("Stage Entity Managers")]
    [HideInInspector] public AllyManager allyManager;
    [HideInInspector] public EnemyManager enemyManager;
    [HideInInspector] public BossManager bossManager;
    [HideInInspector] public QueueManager queueManager;


    public static GameSettings GameSettings { get { return GameManager.Instance.gameSettings; } }
    //public static UserSettings UserSettings { get { return GameManager.Instance.userSettings; } }
    public static HeroManager HeroManager { get { return GameManager.Instance.heroManager; } }
    public static HeroController Hero { get { return GameManager.Instance.heroManager.Hero; } }
    public static RosterManager RosterManager { get { return GameManager.Instance.rosterManager; } }
    public static InventoryManager InventoryManager { get { return GameManager.Instance.inventoryManager; } }
    public static AbilityManager AbilityManager { get { return GameManager.Instance.abilityManager; } }
    public static WorldManager WorldManager { get { return GameManager.Instance.worldManager; } }
    public static ZoneManager ZoneManager { get { return GameManager.Instance.zoneManager; } }
    public static StageManager StageManager { get { return GameManager.Instance.stageManager; } }
    public static AllyManager AllyManager { get { return GameManager.Instance.allyManager; } }
    public static EnemyManager EnemyManager { get { return GameManager.Instance.enemyManager; } }
    public static BossManager BossManager { get { return GameManager.Instance.bossManager; } }
    public static QueueManager QueueManager { get { return GameManager.Instance.queueManager; } }

    [HideInInspector] public bool bypassSaveGame;

    [HideInInspector] public float loadPercent = 0.0f;
    [HideInInspector] public bool onStage = false;

    [HideInInspector] public GameState state = GameState.LoadingWorld;
    public static GameState State { get { return GameManager.Instance.state; } }

    protected override void Awake()
    {
        base.Awake();

        InitializeWorldEntityManagers();
        InitializeStageEntityManagers();
        InitializeGameWorldManagers();
        loadPercent = 0.5f;

        SceneManager.activeSceneChanged += OnSceneChanged;
    }

    

    private void InitializeWorld()
    {
        loadPercent = 1.0f;
        LoadWorld();
        state = GameState.ChoosingZone;
    }

    private void InitializeGameWorldManagers()
    {
        
    }

    public void InitializeWorldEntityManagers()
    {
        //heroManager = new HeroManager();
        if (bypassSaveGame) return;

        SaveGame save = null;
        if (SaveGameManager.SaveGameExists()) save = SaveGameManager.LoadGame();

        heroManager = HeroManager.Load(save);
        abilityManager = new AbilityManager(save);
        rosterManager = new RosterManager(save);
        inventoryManager = new InventoryManager(save);
        worldManager = new WorldManager(save);
        //zoneManager = ZoneManager.Load(save);
        //stageManager = StageManager.Load(save);
    }

    public void InitializeStageEntityManagers()
    {
        allyManager = new AllyManager();
        enemyManager = new EnemyManager();
        bossManager = new BossManager();
        queueManager = new QueueManager();
    }
    



    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        InitializeWorld();
    }


    private void Update()
    {
        //if (queueManager.HasQueues && !queueManager.QueuesAreSpawning && !stageManager.hasSpawnedBoss)
        //{
        //    stageManager.hasSpawnedBoss = true;
        //    var boss = stageManager.SpawnBoss();
        //    if (boss != null)
        //    {
        //        StartCoroutine(CheckBoss(boss));
        //    }
        //    else
        //    {
        //        StageManager.EndStage();
        //    }
        //}
        if (onStage)
        {
            if (queueManager.HasQueues && !queueManager.QueuesAreSpawning && enemyManager.GetAll().Count == 0)
            {
                onStage = false;
                StageManager.EndStage();
            }
        }
    }

    private IEnumerator CheckBoss(BossController boss)
    {
        while (boss.state != CharacterState.Dead)
        {
            Debug.Log("Checking Boss");
            yield return new WaitForSeconds(1.0f);
        }
        StageManager.EndStage();
    }

    public static void LoadStage(SceneField stage)
    {
        if (WorldManager.UnlockedStages.Contains(stage))
        {
            GameManager.Instance.onStage = true;
            SceneManager.LoadScene(stage);
        }
    }

    public static void LoadZone(string zone)
    {
        if (WorldManager.UnlockedZones.Contains(zone))
        {
            SceneManager.LoadScene(zone);
        }
    }

    public static void LoadWorld()
    {
        SceneManager.LoadScene("World");
    }

    private void OnSceneChanged(Scene previousScene, Scene newScene)
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

    private void LoadWorldUi()
    {
        // Spawn UiCanvas
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.AssignmentPanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.UpgradePanel, uiCanvas.transform, false);
        if (GameSettings.ShowResetButton) Instantiate(GameSettings.Prefab.UI.ResetButton, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.ExperienceText, uiCanvas.transform, false);
    }

    private void LoadZoneUi()
    {
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.AssignmentPanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.UpgradePanel, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.BackToWorldButton, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.ExperienceText, uiCanvas.transform, false);
    }

    private void LoadStageUi()
    {
        var uiCanvas = Instantiate(GameSettings.Prefab.UI.UiCanvas);
        uiCanvas.name = GameSettings.Prefab.UI.UiCanvas.name;
        Instantiate(GameSettings.Prefab.UI.HeroStageInformation, uiCanvas.transform, false);
        Instantiate(GameSettings.Prefab.UI.AbilityUsePanel, uiCanvas.transform, false);
    }

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

    public static List<GameCharacterController> AllCharactersExcept(GameCharacterController self)
    {
        var allExceptSelf = AllCharacters;
        allExceptSelf.Remove(self);
        return allExceptSelf;
    }

    public void SaveGame()
    {
        var save = new SaveGame();

        if (HeroManager != null) HeroManager.Save(ref save);
        if (AbilityManager != null) AbilityManager.Save(ref save);
        if (RosterManager != null) RosterManager.Save(ref save);
        if (InventoryManager != null) InventoryManager.Save(ref save);
        if (WorldManager != null) WorldManager.Save(ref save);
        //if (ZoneManager != null) zoneManager.Save(ref save);
        //if (StageManager != null) stageManager.Save(ref save);
        save.isFilled = true;

        SaveGameManager.SaveGame(save);
    }

    public HeroController hero { get { return heroManager.Hero; } }

    public void OnDestroy()
    {
        if (!bypassSaveGame) SaveGame();
        SceneManager.activeSceneChanged -= OnSceneChanged;
    }


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

    public static void UpgradeHero()
    {
        if (CanUpgradeHero())
        {
            GameManager.HeroManager.experience -= UpgradeHeroCost();
            GameManager.HeroManager.level++;
        }
    }

    public static bool CanUpgradeHero()
    {
        return UpgradeHeroCost() <= GameManager.HeroManager.experience;
    }

    public static int UpgradeHeroCost()
    {
        return (int)(GameManager.HeroManager.level * GameManager.GameSettings.Constants.UpgradeHeroCost);
    }

    public static void UpgradeAlly(string allyName)
    {
        if (CanUpgradeAlly(allyName))
        {
            GameManager.HeroManager.experience -= UpgradeAllyCost(allyName);
            GameManager.RosterManager.levels[allyName]++;
        }
    }

    public static bool CanUpgradeAlly(string allyName)
    {
        return UpgradeAllyCost(allyName) <= GameManager.HeroManager.experience;
    }

    public static int UpgradeAllyCost(string allyName)
    {
        return (int)(GameManager.RosterManager.levels[allyName] * GameManager.GameSettings.Constants.UpgradeAllyCost);
    }
}
