using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManagerRandom : TriggerManager
{
    protected override void ChangeColour()
    {
        Renderer render = GetComponent<Renderer>();

        _currentColour = (Random.value < 0.5) ? 0 : 1;
        switch (_currentColour)
        {
            case 0: render.material.color = FirstColour; break;
            case 1: render.material.color = SecondColour; break;
        }
    }
}
