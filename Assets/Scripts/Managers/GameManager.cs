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

    public List<GameObject> Characters
    {
        get
        {
            var characters = new List<GameObject>();
            characters.AddRange(allies);
            characters.AddRange(enemies);
            //characters.AddRange(bosses);
            characters.AddRange(hero);

            return characters;
        }
    }
}
