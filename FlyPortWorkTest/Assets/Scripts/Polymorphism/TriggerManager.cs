using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [Tooltip("First colour to swap, of the object this script is attached to.")]
    [SerializeField] 
    protected Color FirstColour = Color.red;

    [Tooltip("Second colour to swap, of the object this script is attached to.")]
    [SerializeField] 
    protected Color SecondColour = Color.blue;

    [Tooltip("If true, the object will change colour with the OnTriggerEnter event. Otherwise it will change with the OnTriggerExit event.")]
    [SerializeField] 
    protected bool TriggerWhenEnter = true;

    protected int _currentColour = 0;
    protected int _maxColour = 2;

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

        switch(_currentColour)
        {
            case 0: render.material.color = FirstColour; break;
            case 1: render.material.color = SecondColour; break;
        }
        _currentColour++;

        if (_currentColour >= _maxColour)
        {
            _currentColour = 0;
        }
    }
}
