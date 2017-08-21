using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Displays combat text in a manner that slowly floats up and fades out.
/// </summary>
public class CombatTextController : MonoBehaviour
{
    private Vector3 endPosition;
    private Vector3 startPosition;
    [SerializeField]
    private Text uiText;

    /// <summary>
    /// Animates the combat text from start position to end position.
    /// </summary>
    /// <param name="startPosition"></param>
    /// <param name="endPosition"></param>
    private IEnumerator Animate(Vector3 startPosition, Vector3 endPosition)
    {
        float timer = 0.0f;
        float percentComplete = 0.0f;

        while (timer <= GameManager.GameSettings.Constants.CombatText.DisplayTime)
        {
            percentComplete = timer / GameManager.GameSettings.Constants.CombatText.DisplayTime;

            // Move text
            transform.position = Vector3.Lerp(startPosition, endPosition, percentComplete);

            // Fade text
            var color = uiText.color;
            color.a = percentComplete;
            uiText.color = color;

            // Update timer and yield
            timer += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }

    /// <summary>
    /// Sets up the floating combat text.
    /// </summary>
    private void Start()
    {
        startPosition = transform.position;

        var randomShift = Random.Range(-GameManager.GameSettings.Constants.CombatText.HorizontalShift, GameManager.GameSettings.Constants.CombatText.HorizontalShift);
        endPosition = startPosition + new Vector3(randomShift, GameManager.GameSettings.Constants.CombatText.FloatDistance, 0.5f);

        StartCoroutine(Animate(startPosition, endPosition));
    }

    /// <summary>
    /// The color of the floating combat text.
    /// </summary>
    public Color Color
    {
        get
        {
            return uiText.color;
        }
        set
        {
            uiText.color = value;
        }
    }

    /// <summary>
    /// The text displayed in the floating combat text.
    /// </summary>
    public string Text
    {
        get
        {
            return uiText.text;
        }
        set
        {
            uiText.text = value;
        }
    }
}