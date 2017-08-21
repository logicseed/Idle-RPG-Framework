using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the position, color, and display of a scroll bar above a
/// character's head that represents a character's health, energy, or
/// other endurance attribute.
/// </summary>
public class FloatingBarController : MonoBehaviour
{
    [SerializeField]
    protected RectTransform background;

    protected GameCharacterController character;

    [SerializeField]
    protected RectTransform foreground;

    /// <summary>
    /// Sets up the floating bar.
    /// </summary>
    protected void Start()
    {
        // Get reference to the character that this bar is attached to.
        character = transform.parent.gameObject.GetComponent<GameCharacterController>();

        // Setup colors
        var backgroundImage = background.gameObject.GetComponent<Image>();
        var foregroundImage = foreground.gameObject.GetComponent<Image>();
        backgroundImage.color = GameManager.GameSettings.Constants.Colors.FloatingBarBackground;
        foregroundImage.color = GameManager.GameSettings.Constants.Colors.FloatingBarForeground;
    }

    /// <summary>
    /// Updates the floating bar every frame.
    /// </summary>
    protected void Update()
    {
        try
        {
            var healthPercentage = (float)character.CombatController.CurrentHealth / character.Attributes.health;
            healthPercentage = Mathf.Max(Mathf.Min(healthPercentage, 1), 0);

            var newBarScale = new Vector3(healthPercentage, 1, 1);
            foreground.localScale = newBarScale;
        }
        catch (NullReferenceException)
        {
            character = transform.parent.gameObject.GetComponent<GameCharacterController>();
        }
    }
}