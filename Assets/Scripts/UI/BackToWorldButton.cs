using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackToWorldButton : MonoBehaviour
{
    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadWorld);
    }
    public void LoadWorld()
    {
        GameManager.LoadWorld();
    }
}
