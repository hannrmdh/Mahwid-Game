using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Materi : MonoBehaviour
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

    public void IdzharSyafawi()
    {
        SceneManager.LoadScene("Scene_IdzharSyafawi");
    }

    public void IkhfaSyafawi()
    {
        SceneManager.LoadScene("Scene_IkhfaSyafawi");
    }

     public void IdghamMimi()
    {
        SceneManager.LoadScene("Scene_IdghamMimi");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }
}