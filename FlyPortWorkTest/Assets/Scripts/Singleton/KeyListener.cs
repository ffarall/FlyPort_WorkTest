using UnityEngine;

public class KeyListener : MonoBehaviour
{
    [Tooltip("Determines which key will activate the debug message sent by the Singleton. The event listened to is KeyUp.")]
    [SerializeField] private KeyCode KeyToListen;

    private void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyUp)
        {
            if (e.keyCode == KeyToListen)
            {
                Singleton.Instance.HelloSingleton();
            }
        }
    }
}
