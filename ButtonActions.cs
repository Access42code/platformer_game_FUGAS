using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level1"); // ������������ ����������� ����
    }

    public void LoadLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect"); // ������������ ����� � ������� ����
    }

    public void QuitGame()
    {
        Application.Quit(); // ����� � �������
    }
}