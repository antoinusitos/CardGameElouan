using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMenuState : GameState
{
    private UIManager _uiManager = null;

    public void OnStateEnter()
    {
        Debug.Log("IMenuState Enter");
        _uiManager = UIManager.GetInstance();
    }

    public StateCondition OnStateUpdate()
    {
        Debug.Log("IMenuState Update");

        if (_uiManager.GetStateMenuButton())
            return StateCondition.SUCCESS;
            
        return StateCondition.LOOP;
    }

    public void OnStateExit()
    {
        Debug.Log("IMenuState Exit");
        _uiManager.HideMenuButton();
    }

    public EGameState GetGameState()
    {
        return EGameState.MENU;
    }
}
