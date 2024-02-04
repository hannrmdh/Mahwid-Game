using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Petunjuk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void Back()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }
public void Next()
    {
        SceneManager.LoadScene("Scene_Download");
    }
}
