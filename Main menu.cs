using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            string playerName = PlayerPrefs.GetString("PlayerName");
            playerNameText.text = "Welcome, " + playerName + "!";
        }
    }
}
