using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Displays combat text in a manner that slowly floats up and fades out.
/// </summary>
public class CombatTextController : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 endPosition;

    public Text uiText;

    private void Start()
    {
        startPosition = transform.position;
        
        var randomShift = Random.Range(-GameManager.GameSettings.Constants.CombatText.HorizontalShift, GameManager.GameSettings.Constants.CombatText.HorizontalShift);
        endPosition = startPosition + new Vector3(randomShift, GameManager.GameSettings.Constants.CombatText.FloatDistance, 0.5f);

        StartCoroutine(Animate(startPosition, endPosition));
    }

    public string text
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

    public Color color
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

    IEnumerator Animate(Vector3 startPosition, Vector3 endPosition)
    {
        float timer = 0.0f;
        float percentComplete = 0.0f;

        while (timer <= GameManager.GameSettings.Constants.CombatText.DisplayTime)
        {
            percentComplete = timer / GameManager.GameSettings.Constants.CombatText.DisplayTime;

            transform.position = Vector3.Lerp(startPosition, endPosition, percentComplete);

            var color = uiText.color;
            color.a = percentComplete;
            uiText.color = color;

            timer += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }

}
