using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Loads a scene after a specified amount of time.
/// </summary>
public class SceneTimer : MonoBehaviour
{
    public string scene;
    public float delay;

	void Start ()
    {
        StartCoroutine("DelayLoad");
    }

    IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scene);
    }
}
