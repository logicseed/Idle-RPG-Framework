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
}
