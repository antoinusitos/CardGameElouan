using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyButton : MonoBehaviour
{
    private Player _associatedPlayer = null;

    public void SetPlayer(Player thePlayer)
    {
        _associatedPlayer = thePlayer;
    }

    public void Execute()
    {
        if(_associatedPlayer)
        {
            _associatedPlayer.SetPlayerState(PlayerState.READY);
        }
    }
}
