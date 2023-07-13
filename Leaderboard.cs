using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    public Text leaderboardText;

    private Dictionary<string, int> leaderboardData = new Dictionary<string, int>();

    private const int maxEntries = 10;

    private void Start()
    {
        LoadLeaderboardData();
        DisplayLeaderboard();
    }

    public void AddEntry(string playerName, int score)
    {
        if (!leaderboardData.ContainsKey(playerName))
        {
            leaderboardData.Add(playerName, score);
        }
        else
        {
            leaderboardData[playerName] = score;
        }

        SaveLeaderboardData();
        DisplayLeaderboard();
    }

    private void LoadLeaderboardData()
    {
        for (int i = 1; i <= maxEntries; i++)
        {
            string playerName = PlayerPrefs.GetString("LeaderboardName" + i);
            int score = PlayerPrefs.GetInt("LeaderboardScore" + i);
            if (!string.IsNullOrEmpty(playerName))
            {
                leaderboardData.Add(playerName, score);
            }
        }
    }

    private void SaveLeaderboardData()
    {
        List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>(leaderboardData);
        sortedList.Sort((x, y) => y.Value.CompareTo(x.Value));

        int count = Mathf.Min(sortedList.Count, maxEntries);
        for (int i = 0; i < count; i++)
        {
            PlayerPrefs.SetString("LeaderboardName" + (i + 1), sortedList[i].Key);
            PlayerPrefs.SetInt("LeaderboardScore" + (i + 1), sortedList[i].Value);
        }
        PlayerPrefs.Save();
    }

    private void DisplayLeaderboard()
    {
        leaderboardText.text = "Leaderboard:\n";
        List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>(leaderboardData);
        sortedList.Sort((x, y) => y.Value.CompareTo(x.Value));

        int count = Mathf.Min(sortedList.Count, maxEntries);
        for (int i = 0; i < count; i++)
        {
            leaderboardText.text += (i + 1) + ". " + sortedList[i].Key + " - " + sortedList[i].Value + "\n";
        }
    }
}
