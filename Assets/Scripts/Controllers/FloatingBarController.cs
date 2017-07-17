using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

/// <summary>
/// Controls the position, color, and display of a scroll bar above a
/// character's head that represents a character's health, energy, or
/// other endurance attribute.
/// </summary>
public class FloatingBarController : MonoBehaviour
{
    public RectTransform background;
    public RectTransform foreground;
    public Color backgroundColor = Color.red;
    public Color foregroundColor = Color.green;

    private GameCharacterController character;

    // Use this for initialization
    void Start()
    {
        // Get reference to the character that this bar is attached to.
        character = transform.parent.gameObject.GetComponent<GameCharacterController>();

        // Setup colors
        var backgroundImage = background.gameObject.GetComponent<Image>();
        var foregroundImage = foreground.gameObject.GetComponent<Image>();
        backgroundImage.color = backgroundColor;
        foregroundImage.color = foregroundColor;
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            var healthPercentage = (float)character.combat.currentHealth / character.attributes.health;
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
