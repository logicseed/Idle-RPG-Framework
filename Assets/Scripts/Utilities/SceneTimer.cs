using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Loads a scene after a specified amount of time.
/// </summary>
public class SceneTimer : MonoBehaviour
{
    public string scene;
    public float delay;
    public float remaining;
    public Scrollbar progress;

    void Start ()
    {
        remaining = delay;
        //StartCoroutine("DelayLoad");
    }

    private void Update()
    {
        remaining -= Time.deltaTime;
        if (progress != null) progress.size = 1 - (remaining / delay);
        if (remaining <= 0) SceneManager.LoadScene(scene);
    }

    IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scene);
    }
}
