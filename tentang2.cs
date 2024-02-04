using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tentang2 : MonoBehaviour
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

    public void Before()
    {
        SceneManager.LoadScene("Scene_Tentang");
    }
    
}