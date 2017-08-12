using UnityEngine;

/// <summary>
/// A Unity Singleton pattern GameObject
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    /// <summary>
    /// Gets the current instance of this Singleton.
    /// </summary>
    public static T Instance { get { return instance; } }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else if (instance != this as T)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
