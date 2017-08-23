using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Debug = ConditionalDebug;

/// <summary>
/// Controls the hero input.
/// </summary>
public class HeroInputController : MonoBehaviour
{
    protected HeroController hero;

    protected bool awaitingTarget = false;
    protected Ability waitingAbility;

    /// <summary>
    /// Sets up the hero input.
    /// </summary>
    protected void Start()
    {
        hero = GameManager.Hero;
    }

    /// <summary>
    /// Updates the hero input every frame.
    /// </summary>
    protected void Update()
    {
        if (EventSystem.current == null)
        {
            Debug.LogError("Stage does not have event system; exiting. Add an event system to be able to play this stage.");
            GameManager.LoadZone(GameManager.WorldManager.LastZone);
        }

        // Process touch input
        if (Input.touchCount > 0)
        {
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    if (!IsPointerOverUIObject()) ProcessTap(touch.position);
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (!IsPointerOverUIObject()) ProcessTap(Input.mousePosition);
        }

        // This works with the mobile back button too
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.OnStage)
            {
                GameManager.LoadZone(GameManager.WorldManager.LastZone);
            }
        }
    }

    /// <summary>
    /// Process a tap at a screen position.
    /// </summary>
    /// <param name="position">The screen position of the tap.</param>
    private void ProcessTap(Vector2 position)
    {
        if (!GameManager.OnStage) return;

        var worldPosition = Camera.main.ScreenToWorldPoint(position);

        // Character tap
        foreach (var character in GameManager.AllCharactersExcept(hero))
        {
            if (Vector2.Distance(worldPosition, character.transform.position) < GameManager.GameSettings.Constants.Range.Touch)
            {
                GameManager.Hero.CombatController.TargetController = character;
                GameManager.Hero.HeroMovementController.HasLocationTarget = false;

                if (awaitingTarget && waitingAbility != null)
                {
                    awaitingTarget = false;
                    GameManager.Hero.UseAbility(waitingAbility);
                }
                return;
            }
        }

        GameManager.Hero.HeroMovementController.Location = worldPosition;
        GameManager.Hero.CombatController.TargetController = null;
    }

    /// <summary>
    /// Awaits a target for targetable abilities when hero doesn't have a target.
    /// </summary>
    /// <param name="ability">The ability to use once a target is found.</param>
    public void AwaitTarget(Ability ability)
    {
        awaitingTarget = true;
        waitingAbility = ability;
    }

    /// <summary>
    /// Detects if a touch or click is over a UI object.
    /// </summary>
    /// <returns>True if a UI was tapped; false otherwise.</returns>
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
}
