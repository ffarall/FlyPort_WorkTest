using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManagerAlt : MonoBehaviour
{
    [Tooltip("List of colours that this object circles through.")]
    [SerializeField]
    private Color[] ColoursList = { Color.red, Color.blue };

    [Tooltip("If true, the object will change colour with the OnTriggerEnter event. Otherwise it will change with the OnTriggerExit event.")]
    [SerializeField]
    private bool TriggerWhenEnter = true;

    protected int _currentColour = 0;

    private void Awake()
    {
        ChangeColour();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TriggerWhenEnter)
        {
            ChangeColour();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!TriggerWhenEnter)
        {
            ChangeColour();
        }
    }

    protected void ChangeColour()
    {
        Renderer render = GetComponent<Renderer>();

        render.material.color = ColoursList[_currentColour];
        _currentColour++;

        if (_currentColour >= ColoursList.Length)
        {
            _currentColour = 0;
        }
    }
}
