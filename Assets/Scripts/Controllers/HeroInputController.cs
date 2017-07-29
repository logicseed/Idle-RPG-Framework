using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
///
/// </summary>
public class HeroInputController : MonoBehaviour
{
    private HeroController hero;

    private bool awaitingTarget = false;
    private Ability waitingAbility;

    private void Start()
    {
        hero = GameManager.Hero;
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
                    if (!EventSystem.current.IsPointerOverGameObject()) ProcessTap(touch.position);
                }
            }
        }

        // Process keyboard input
        if (Input.GetMouseButton(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject()) ProcessTap(Input.mousePosition);
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
        foreach ( var character in GameManager.AllCharacters)
        {
            if (Vector2.Distance(worldPosition, character.transform.position) < 0.2f) //TODO: No magic numbers
            {
                hero.combat.target = character;
                if (awaitingTarget && waitingAbility != null)
                {
                    awaitingTarget = false;
                    hero.UseAbility(waitingAbility);
                }
                return;
            }
        }
        ((HeroMovementController)hero.movement).location = worldPosition;
        hero.combat.target = null;
    }

    internal void AwaitTarget(Ability ability)
    {
        awaitingTarget = true;
        waitingAbility = ability;
    }
}
