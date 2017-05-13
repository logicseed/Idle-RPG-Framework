using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLayerOrderer : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var heroes = GameObject.FindGameObjectsWithTag("Hero");
        var allies = GameObject.FindGameObjectsWithTag("Ally");
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (var hero in heroes)
        {
            hero.GetComponent<SpriteRenderer>().sortingOrder = (int)Mathf.Ceil(hero.transform.position.y * 100) * -1;
        }

        foreach (var ally in allies)
        {
            ally.GetComponent<SpriteRenderer>().sortingOrder = (int)Mathf.Ceil(ally.transform.position.y * 100) * -1;
        }

        foreach (var enemy in enemies)
        {
            enemy.GetComponent<SpriteRenderer>().sortingOrder = (int)Mathf.Ceil(enemy.transform.position.y * 100) * -1;
        }
    }
}
