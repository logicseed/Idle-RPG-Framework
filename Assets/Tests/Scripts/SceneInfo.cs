using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class SceneInfo : MonoBehaviour
{
    public Text displayText;

    public bool showSceneTime = true;
    public bool showExperience = false;
	
	void Update ()
    {
        var frameText = new StringBuilder();
        frameText.AppendLine("SCENE INFO");

        if (showSceneTime) frameText.AppendLine("Time: " + Time.timeSinceLevelLoad);
        if (showExperience) frameText.AppendLine("Experience: " + GameManager.HeroManager.experience);

        displayText.text = frameText.ToString();
	}
}
