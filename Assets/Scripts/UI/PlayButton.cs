using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour 
{
    private bool _clicked = false;

    public void Execute()
    {
        _clicked = true;
    }

    public bool GetClicked()
    {
        return _clicked;
    }

}
