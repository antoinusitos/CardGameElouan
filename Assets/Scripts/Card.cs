using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour 
{
    private CardPlace _currentCardPlace = CardPlace.DECK;

    // field to save
    private CardEffect _cardEffect1 = CardEffect.NONE;
    private CardEffect _cardEffect2 = CardEffect.NONE;
    private int _effect1Value = -1;
    private int _effect2Value = -1;

    public void CreateCard(CardEffect effect1, int effect1Value, CardEffect effect2, int effect2Value)
    {
        _cardEffect1 = effect1;
        _effect1Value = effect1Value;
        _cardEffect2 = effect2;
        _effect2Value = effect2Value;
    }

    public string[] GetSaveInfo()
    {
        string[] s = new string[4];

        s[0] = "effect1=" + (int)_cardEffect1;
        s[1] = "effect1Value=" + _effect1Value;
        s[2] = "effect2=" + (int)_cardEffect2;
        s[3] = "effect2Value=" + _effect1Value;

        return s;
    }

    public void Load(string[] s)
    {
        //TODO : add check for each type
        string[] temp = s;
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = temp[i].Split('=')[1];
        }

        CreateCard(
            (CardEffect)(int.Parse(temp[0])),   //_cardEffect1
            int.Parse(temp[1]),                 //_effect1Value
            (CardEffect)(int.Parse(temp[2])),   //_cardEffect2
            int.Parse(temp[3])                  //_effect2Value
        );
    }
}
