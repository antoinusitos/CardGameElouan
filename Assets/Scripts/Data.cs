using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardPlace
{
    DECK,
    HAND,
    BOARD,
}

public enum CardEffect
{
    NONE,
    ATTACK,
    DEFENSE,
    MOVEMENT,
    //...
}

public struct TurnAction
{
    public Card playerCard;
    public Card enemyCard;
}

public enum StateCondition
{
    FAIL,
    SUCCESS,
    LOOP,
}

public enum EGameState
{
    MENU,
    GAME,
    SCORE,
}

public enum GameStep
{ 
    NONE,
    INIT,
    START,
    LOOP,
    END,
}

public enum PlayerState
{
    NONE,
    INIT,
    READY,
    PLAYING,
    WAITING,
    ENDED,
}

public delegate void AfterTransition();

public struct StateTransition
{
    public EGameState stateIN;
    public StateCondition condition;
    public GameState stateOUT;
    public AfterTransition afterTransition; 
}
