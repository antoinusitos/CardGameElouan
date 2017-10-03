using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameState : GameState
{
    private Player _player1 = null;
    private Player _player2 = null;

    private GameStep _currentGameStep = GameStep.NONE;

    public void OnStateEnter()
    {
        Debug.Log("IGameState Enter");
        GameObject go = new GameObject("Players");
        _player1 = go.AddComponent<Player>();
        _player2 = go.AddComponent<Player>();

        _player1.InitPlayer(1);
        _player2.InitPlayer(2);

        _currentGameStep = GameStep.INIT;
    }

    public StateCondition OnStateUpdate()
    {
        Debug.Log("IGameState Update");
        
        switch(_currentGameStep)
        {
            case GameStep.INIT:
                InitLoop();
                break;

            case GameStep.LOOP:
                GameLoop();
                break;
        }

        return StateCondition.LOOP;
    }

    public void OnStateExit()
    {
        Debug.Log("IGameState Exit");
    }

    private void InitLoop()
    {
        if (
            _player1.GetPlayerState() == PlayerState.READY &&
            _player2.GetPlayerState() == PlayerState.READY
         )
        {
            Debug.Log("Both Players Ready !");
            UIManager.GetInstance().HidePlayersButton();
            _currentGameStep = GameStep.LOOP;
        }
    }

    private void GameLoop()
    {

    }

    public EGameState GetGameState()
    {
        return EGameState.GAME;
    }
}
