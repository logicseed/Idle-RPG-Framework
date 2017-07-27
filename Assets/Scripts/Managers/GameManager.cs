using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///
/// </summary>
public class GameManager : Singleton<GameManager>
{
    [Header("Settings")]
    public GameSettings gameSettings;
    public UserSettings userSettings;

    [Header("World Entity Managers")]
    public HeroManager heroManager;
    public RosterManager rosterManager;
    public InventoryManager inventoryManager;
    public AbilityManager abilityManager;
    public ZoneManager zoneManager;
    public StageManager stageManager;

    [Header("Stage Entity Managers")]
    public AllyManager allyManager;
    public EnemyManager enemyManager;
    public BossManager bossManager;
    public QueueManager queueManager;


    public static GameSettings GameSettings { get { return GameManager.Instance.gameSettings; } }
    public static UserSettings UserSettings { get { return GameManager.Instance.userSettings; } }
    public static HeroManager HeroManager { get { return GameManager.Instance.heroManager; } }
    public static RosterManager RosterManager { get { return GameManager.Instance.rosterManager; } }
    public static InventoryManager InventoryManager { get { return GameManager.Instance.inventoryManager; } }
    public static AbilityManager AbilityManager { get { return GameManager.Instance.abilityManager; } }
    public static ZoneManager ZoneManager { get { return GameManager.Instance.zoneManager; } }
    public static StageManager StageManager { get { return GameManager.Instance.stageManager; } }
    public static AllyManager AllyManager { get { return GameManager.Instance.allyManager; } }
    public static EnemyManager EnemyManager { get { return GameManager.Instance.enemyManager; } }
    public static BossManager BossManager { get { return GameManager.Instance.bossManager; } }
    public static QueueManager QueueManager { get { return GameManager.Instance.queueManager; } }

    public bool bypassSaveGame;

    private void Awake()
    {
        InitializeWorldEntityManagers();
        InitializeStageEntityManagers();
    }

    public void InitializeWorldEntityManagers()
    {
        if (bypassSaveGame) return;

        SaveGame save = null;
        if (SaveGameManager.SaveGameExists()) save = SaveGameManager.LoadGame();

        heroManager = HeroManager.Load(save);
        rosterManager = RosterManager.Load(save);
        inventoryManager = InventoryManager.Load(save);
        abilityManager = new AbilityManager(save);
        zoneManager = ZoneManager.Load(save);
        stageManager = StageManager.Load(save);
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
    }


    private void Update()
    {

    }



    public static List<GameCharacterController> AllCharacters
    {
        get
        {
            var allCharacters = new List<GameCharacterController>();

            EnemyManager.AddAllToList(ref allCharacters);
            BossManager.AddAllToList(ref allCharacters);
            AllyManager.AddAllToList(ref allCharacters);
            HeroManager.AddHeroToList(ref allCharacters);

            return allCharacters;
        }
    }

    public static List<GameCharacterController> AllEnemies
    {
        get
        {
            var allEnemies = new List<GameCharacterController>();

            EnemyManager.AddAllToList(ref allEnemies);
            BossManager.AddAllToList(ref allEnemies);

            return allEnemies;
        }
    }

    public static List<GameCharacterController> AllFriendlies
    {
        get
        {
            var allFriendlies = new List<GameCharacterController>();

            AllyManager.AddAllToList(ref allFriendlies);
            HeroManager.AddHeroToList(ref allFriendlies);

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

        heroManager.Save(ref save);
        rosterManager.Save(ref save);
        inventoryManager.Save(ref save);
        abilityManager.Save(ref save);
        zoneManager.Save(ref save);
        stageManager.Save(ref save);
        save.isFilled = true;

        SaveGameManager.SaveGame(save);
    }

    public void ResetGame()
    {
        SaveGameManager.SaveGame(new SaveGame());
    }

    public HeroController hero { get { return heroManager.hero; } }

    public void OnDestroy()
    {
        if (!bypassSaveGame) SaveGame();
    }


    public static WorldEntityManager GetManagerByType(ListableEntityType entityType)
    {
        switch (entityType)
        {
            case ListableEntityType.Ability: return AbilityManager;

            case ListableEntityType.NonListable: default: return null;
        }
    }

}
