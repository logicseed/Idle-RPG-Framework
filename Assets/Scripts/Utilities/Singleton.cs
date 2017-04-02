using UnityEngine;

/// <summary>
///
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    /// <summary>
    ///
    /// </summary>
    private static T instance;

    /// <summary>
    ///
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
