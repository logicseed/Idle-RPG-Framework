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
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (T)FindObjectOfType(typeof(T));

                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    instance = singleton.AddComponent<T>();
                    singleton.name = typeof(T).ToString() + " [Singleton]";

                    DontDestroyOnLoad(singleton);
                }
            }
            return instance;
        }
    }
}
