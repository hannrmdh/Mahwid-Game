using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScanAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene("Scene_MainMenu");
    }
}
