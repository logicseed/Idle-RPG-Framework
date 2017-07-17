using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class SceneInfo : MonoBehaviour
{
    public Text displayText;
	
	void Update ()
    {
        var frameText = new StringBuilder();
        frameText.AppendLine("SCENE INFO");
        frameText.AppendLine("Time: " + Time.timeSinceLevelLoad);

        displayText.text = frameText.ToString();
	}
}
