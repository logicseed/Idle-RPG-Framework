using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Keeps a text object updated with the current experience.
/// </summary>
public class ExperienceText : MonoBehaviour
{
    private Text text;

    /// <summary>
    /// Refreshes every GUI refresh.
    /// </summary>
    protected void OnGUI()
    {
        text.text = GameManager.HeroManager.Experience + " XP";
    }

    /// <summary>
    /// Sets up the text.
    /// </summary>
    protected void Start()
    {
        text = GetComponent<Text>();
    }
}