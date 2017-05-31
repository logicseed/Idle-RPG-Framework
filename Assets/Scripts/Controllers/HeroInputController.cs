using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///
/// </summary>
public class HeroInputController : MonoBehaviour
{
    private HeroManager hero;

    private void Start()
    {
        hero = GetComponent<HeroManager>();
    }

    private void Update()
    {
        // Process touch input
        if (Input.touchCount > 0)
        {
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    ProcessTap(touch.position);
                }
            }
        }

        // Process keyboard input
        if (Input.GetMouseButton(0))
        {
            ProcessTap(Input.mousePosition);
        }

        // This works with the Android back button too
        if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene("World"); }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="position"></param>
    private void ProcessTap(Vector2 position)
    {
        var worldPosition = Camera.main.ScreenToWorldPoint(position);

        // Character tap
        foreach ( var character in GameManager.Instance.AllCharacters)
        {
            if (Vector2.Distance(worldPosition, character.transform.position) < 0.1f) //TODO: No magic numbers
            {
                try
                {
                    hero.combat.target = character;
                    return;
                }
                catch (NullReferenceException)
                {
                    hero = GetComponent<HeroManager>();
                    return;
                }
            }
        }

        // Location tap
        try
        {
            Debug.Log(worldPosition);
            ((HeroMovementController)hero.movement).location = worldPosition;
        }
        catch (NullReferenceException)
        {
            hero = GetComponent<HeroManager>();
        }
    }
}
