using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tentang : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }

    public void Next()
    {
        SceneManager.LoadScene("Scene_Tentang 1");
    }
    
}