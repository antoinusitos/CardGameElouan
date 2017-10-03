using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IScoreState : GameState
{

    public void OnStateEnter()
    {
        Debug.Log("IScoreState Enter");
    }

    public StateCondition OnStateUpdate()
    {
        Debug.Log("IScoreState Update");
        return StateCondition.LOOP;
    }

    public void OnStateExit()
    {
        Debug.Log("IScoreState Exit");
    }

    public EGameState GetGameState()
    {
        return EGameState.SCORE;
    }
}
