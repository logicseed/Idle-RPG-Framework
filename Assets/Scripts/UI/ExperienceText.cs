using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExperienceText : MonoBehaviour
{
    private Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    private void OnGUI()
    {
        text.text = GameManager.HeroManager.Experience + " XP";
    }
}
