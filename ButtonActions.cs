using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1"); // Завантаження початкового рівня
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect"); // Завантаження сцени зі списком рівнів
    }

    public void QuitGame()
    {
        Application.Quit(); // Вихід з додатку
    }
}