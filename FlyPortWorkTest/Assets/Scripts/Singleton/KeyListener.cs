using UnityEngine;

public class KeyListener : MonoBehaviour
{
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
