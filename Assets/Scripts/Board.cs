using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour 
{
    private Card _currentCard = null;

    public void PlayCard(Card theCard)
    {
        _currentCard = theCard;
        //...
    }
	
}
