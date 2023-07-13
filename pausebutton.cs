using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject pausePanel;

    private bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; 
            pausePanel.SetActive(true); 
        }
        else
        {
            Time.timeScale = 1f; 
            pausePanel.SetActive(false);
        }
    }
}