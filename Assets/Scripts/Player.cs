using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Card> _cardInDeck = new List<Card>();

    private Card[] _cardInHand = null;

    private int _cardNumberInHand = 5; //TODO : put this value in a file

    private int _life = 10; //TODO : put this value in a file

    private int _ID = -1; // only useful for the multiplayer

    private bool _turn = false;

    private float _timeToPlay = 10.0f; //TODO : put this value in a file

    private float _timeRemainingToPlay = 0f;

    private List<TurnAction> _allActionsInGame = new List<TurnAction>();

    private PlayerState _currentPlayerState = PlayerState.NONE;

    public void InitPlayer(int ID)
    {
        _ID = ID;

        // every card is null at the beginning
        _cardInHand = new Card[_cardNumberInHand];

        //TODO : get the values from the file (see above)

        _currentPlayerState = PlayerState.INIT;

        UIManager.GetInstance().ShowPlayerButton(this);
    }

    public int GetID()
    {
        return _ID;
    }

    public PlayerState GetPlayerState()
    {
        return _currentPlayerState;
    }

    public void SetPlayerState(PlayerState newPlayerState)
    {
        _currentPlayerState = newPlayerState;
    }

    public void LoadDeck()
    {
        //TODO : allow player to load his deck
        //      one deck per file
        //      show all files and select one to load
    }
}
