using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class <c>Singleton</c> models the singleton design pattern in Unity.
/// </summary>
public class Singleton : MonoBehaviour
{
    /// <summary>
    /// Unique instance of the Singleton class.
    /// By definition of the singleton design pattern, the unique instance should be exposed to all other scripts in the project.
    /// Doing so via a property instead of just making the field public, allows the developer to have further control over the 
    /// getter, and setter.
    /// </summary>
    public static Singleton Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            // Since this class inherits from MonoBehaviour, the constructor is hidden.
            // This double check is to make sure that no other instance is present in the scene, which could have been created
            // using the Unity Editor or with object.Instantiate().
            Instance = FindObjectOfType<Singleton>();
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            // Destroying current instance of a Singleton if another instance has already been created.
            Destroy(gameObject);
        }
    }
}
