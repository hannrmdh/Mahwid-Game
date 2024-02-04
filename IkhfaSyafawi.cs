using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IkhfaSyafawi : MonoBehaviour
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

    public void Petunjuk()
    {
        SceneManager.LoadScene("Scene_Petunjuk");
    }

    public void Back()
    {
        SceneManager.LoadScene("Scene_Materi");
    }

    public void materi1()
    {
        SceneManager.LoadScene("Scene_IdzharSyafawi");
    }

    public void materi2()
    {
        SceneManager.LoadScene("Scene_IkhfaSyafawi");
    }

     public void materi3()
    {
        SceneManager.LoadScene("Scene_IdghamMimi");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }
    
}