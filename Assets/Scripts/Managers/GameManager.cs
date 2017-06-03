using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class GameManager : Singleton<GameManager>
{
    public List<GameObject> allies;
    public List<GameObject> enemies;
    //public List<GameObject> bosses;
    public List<GameObject> hero;
    public List<GameObject> queues;
    public string currentStage;
    public List<string> unlockedZones;
    public List<string> unlockedStages;

    private void Start()
    {
        InitializeCharacterLists();
    }

    private void InitializeCharacterLists()
    {
        allies = new List<GameObject>();
        enemies = new List<GameObject>();
        //bosses = new List<GameObject>();
        hero = new List<GameObject>();

        unlockedZones = new List<string>();
        unlockedStages = new List<string>();
    }

    private void Update()
    {
        UpdateCharacterLists();
    }

    private void UpdateCharacterLists()
    {
        allies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Ally"));
        enemies = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        //bosses = new List<GameObject>(GameObject.FindGameObjectsWithTag("Boss"));
        hero = new List<GameObject>(GameObject.FindGameObjectsWithTag("Hero"));
    }

    private void UpdateQueueList()
    {
        queues = new List<GameObject>(GameObject.FindGameObjectsWithTag("Queue"));
    }

    private bool QueuesAreSpawning
    {
        get
        {
            var areSpawning = false;
            foreach (var queue in queues)
            {
                var queueManager = queue.GetComponent<QueueManager>();
                if (queueManager.spawning) areSpawning = true;
            }
            return areSpawning;
        }
    }

    public List<GameObject> AllCharacters
    {
        get
        {
            var allCharacters = new List<GameObject>();
            allCharacters.AddRange(allies);
            allCharacters.AddRange(enemies);
            //characters.AddRange(bosses);
            allCharacters.AddRange(hero);

            return allCharacters;
        }
    }

    public List<GameObject> AllEnemies
    {
        get
        {
            var allEnemies = new List<GameObject>();
            allEnemies.AddRange(enemies);
            //enemies.AddRange(bosses);

            return allEnemies;
        }
    }

    public List<GameObject> AllFriendlies
    {
        get
        {
            var allFriendlies = new List<GameObject>();
            allFriendlies.AddRange(allies);
            allFriendlies.AddRange(hero);

            return allFriendlies;
        }
    }

    public List<GameObject> AllCharactersExcept(GameObject self)
    {
        var allExceptSelf = AllCharacters;
        allExceptSelf.Remove(self);
        return allExceptSelf;
    }

    public void ResetGame()
    {

    }

    public void StartStage()
    {
        InitializeCharacterLists();
    }

    public SaveGame PrepareSaveGame()
    {
        var heroManager = hero[0].GetComponent<HeroManager>();
        var rosterManager = hero[0].GetComponent<RosterManager>();
        var inventoryManager = hero[0].GetComponent<InventoryManager>();
        var abilityManager = hero[0].GetComponent<AbilityManager>();

        var saveGame = new SaveGame();

        saveGame.experience = heroManager.experience;

        var unlockedAllies = new List<string>();
        foreach (var ally in rosterManager.allies)
        {
            unlockedAllies.Add("Ally/" + ally.name);
        }
        saveGame.unlockedAllies = unlockedAllies;

        var assignedAllies = new List<string>();
        foreach (var ally in rosterManager.activeRoster)
        {
            assignedAllies.Add("Ally/" + ally.name);
        }
        saveGame.assignedAllies = assignedAllies;

        saveGame.unlockedZones = unlockedZones;
        saveGame.unlockedStages = unlockedStages;

        var unlockedEquipment = new List<string>();
        foreach (var equipment in inventoryManager.inventory)
        {
            unlockedEquipment.Add("Equipment/" + equipment.name);
        }
        saveGame.unlockedEquipment = unlockedEquipment;

        var assignedEquipment = new List<string>();
        foreach (var equipment in inventoryManager.equipped)
        {
            assignedEquipment.Add("Equipment/" + equipment.Value.name);
        }
        saveGame.assignedEquipment = assignedEquipment;

        var unlockedAbilities = new List<string>();
        foreach (var ability in abilityManager.unlockedAbilities)
        {
            unlockedAbilities.Add("Ability/" + ability.name);
        }
        saveGame.unlockedAbilities = unlockedAbilities;

        var assignedAbilities = new List<string>();
        foreach (var ability in abilityManager.activeAbilities)
        {
            assignedAbilities.Add("Ability/" + ability.name);
        }
        saveGame.assignedAbilities = assignedAbilities;

        saveGame.lastStage = currentStage;
        saveGame.lastStageTime = DateTime.Now;

        saveGame.isFilled = true;
        return saveGame;
    }
}
