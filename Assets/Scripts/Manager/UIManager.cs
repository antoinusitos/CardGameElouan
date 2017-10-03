using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
    public GameObject buttonP1 = null;
    public GameObject buttonP2 = null;

    public GameObject menuButton = null;
    private PlayButton _playButton = null;

    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////
    /// MENU
    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////

    public void HideMenuButton()
    {
        menuButton.SetActive(false);
    }

    public bool GetStateMenuButton()
    {
        if (_playButton == null)
            _playButton = menuButton.GetComponent<PlayButton>();
        return _playButton.GetClicked();
    }

    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////
    /// GAME
    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////

    public void ShowPlayerButton(Player player)
    {
        if (player.GetID() == 1)
        {
            buttonP1.GetComponent<ReadyButton>().SetPlayer(player);
            buttonP1.SetActive(true);
        }
        else
        {
            buttonP2.GetComponent<ReadyButton>().SetPlayer(player);
            buttonP2.SetActive(true);
        }
    }

    public void HidePlayersButton()
    {
        buttonP1.SetActive(false);
        buttonP2.SetActive(false);
    }



    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////
    /// SINGLETON
    ///////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////

    private void Awake()
    {
        Instance = this;
        HidePlayersButton();
    }
    
    private static UIManager Instance = null;
    public static UIManager GetInstance() { return Instance; }
}
