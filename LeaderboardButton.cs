using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderboardButton : MonoBehaviour
{
    public void OpenLeaderboard()
    {
        SceneManager.LoadScene("LeaderboardScene");
    }
}