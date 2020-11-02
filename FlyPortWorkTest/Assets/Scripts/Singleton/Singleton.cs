using UnityEngine;

/// <summary>
/// Class <c>Singleton</c> models the singleton design pattern in Unity.
/// </summary>
public class Singleton
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
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    private Singleton() { }

    /// <summary>
    /// When called, this method shall print "Singleton is being called." in the console window.
    /// </summary>
    public void HelloSingleton()
    {
        Debug.Log("Singleton is being called.");
    }
}
