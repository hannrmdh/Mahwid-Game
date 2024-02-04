using Collections1 = System.Collections;
using Collections2 = System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR : MonoBehaviour
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

    public void Back()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }
     public void Petunjuk()
    {
        SceneManager.LoadScene("Scene_Download");
    }
    

   
}
