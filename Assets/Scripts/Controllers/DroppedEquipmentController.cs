using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Controls the motion of dropped equipment on the stage.
/// </summary>
public class DroppedEquipmentController : MonoBehaviour
{
    private Vector3 endPosition;
    private Vector3 startPosition;
    [SerializeField]
    private Image image;

    /// <summary>
    /// Image component of dropped equipment indicator.
    /// </summary>
    public Image Image
    {
        get
        {
            return image;
        }

        set
        {
            image = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;

        var randomShift = Random.Range(-GameManager.GameSettings.Constants.CombatText.HorizontalShift, GameManager.GameSettings.Constants.CombatText.HorizontalShift);
        endPosition = startPosition + new Vector3(randomShift, GameManager.GameSettings.Constants.CombatText.FloatDistance, 0.5f);

        StartCoroutine(Animate(startPosition, endPosition));
    }

    /// <summary>
    /// Animates the dropped equipment from start position to end position.
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

            // Update timer and yield
            timer += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }
}
