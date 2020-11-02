using UnityEngine;

/// <summary>
/// Class <c>Singleton</c> models the singleton design pattern in Unity.
/// </summary>
public class Singleton : MonoBehaviour
{
    private static Singleton _instance;

    /// <summary>
    /// Unique instance of the Singleton class.
    /// By definition of the singleton design pattern, the unique instance should be exposed to all other scripts in the project.
    /// Doing so via a property instead of just making the field public, allows the developer to have further control over the 
    /// getter, and setter.
    /// </summary>
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                // Since this class inherits from MonoBehaviour, the constructor is hidden.
                // This double check is to make sure that no other instance is present in the scene, which could have been created
                // using the Unity Editor or with object.Instantiate().
                _instance = FindObjectOfType<Singleton>();
                if (_instance == null)
                {
                    _instance = new GameObject().AddComponent<Singleton>();
                }
            }

            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null)
        {
            // Destroying current instance of a Singleton if another instance has already been created.
            Destroy(gameObject);
        }
        else
        {
            // Making Singleton persist in all scenes.
            DontDestroyOnLoad(gameObject);
        }
    }

    /// <summary>
    /// When called, this method shall print "Singleton is being called." in the console window.
    /// </summary>
    public void HelloSingleton()
    {
        Debug.Log("Singleton is being called.");
    }
}
