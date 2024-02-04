using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("ARTargetMarker");
    }

    public void Petunjuk()
    {
        SceneManager.LoadScene("Scene_Petunjuk");
    }

     public void Tentang()
    {
        SceneManager.LoadScene("Scene_Tentang");
    }

     public void Yukbelajar()
    {
        SceneManager.LoadScene("Scene_Materi");
    }

    public void exit()
    {
        SceneManager.LoadScene("Scene_Exit");
    }
    public void cancel()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }

     public void CobaKuis()
    {
        SceneManager.LoadScene("SceneMenuGame");
    }
    
}

