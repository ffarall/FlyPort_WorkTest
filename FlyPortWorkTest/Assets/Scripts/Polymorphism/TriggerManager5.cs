using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager5 : TriggerManager
{
    [Tooltip("Third colour to swap, of the object this script is attached to.")]
    [SerializeField]
    private Color ThirdColour = Color.green;

    [Tooltip("Fourth colour to swap, of the object this script is attached to.")]
    [SerializeField]
    private Color FourthColour = Color.yellow;

    [Tooltip("Fifth colour to swap, of the object this script is attached to.")]
    [SerializeField]
    private Color FifthColour = Color.cyan;

    protected override void Init()
    {
        _maxColour = 5;
    }

    protected override void ChangeColour()
    {
        Renderer render = GetComponent<Renderer>();

        switch (_currentColour)
        {
            case 0: render.material.color = FirstColour; break;
            case 1: render.material.color = SecondColour; break;
            case 2: render.material.color = ThirdColour; break;
            case 3: render.material.color = FourthColour; break;
            case 4: render.material.color = FifthColour; break;
        }
        _currentColour++;

        if (_currentColour >= _maxColour)
        {
            _currentColour = 0;
        }
    }
}
