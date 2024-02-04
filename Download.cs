using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Download : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void Back()
    {
        SceneManager.LoadScene("ARTargetMarker");
    }
    

    public void URL()
    {
        Application.OpenURL("https://bit.ly/MahwidGame_ImageTarget");
    }
}
