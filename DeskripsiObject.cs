using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskripsiObject : MonoBehaviour
{
    public Text textNamaObject;
    public Text textDeskripsiObject;

    public GameObject panelDeskripsi; 
    [TextArea]
    
    public string[] keteranganObjects;
    public GameObject[] objectAktif;
    
    

       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTargetFound(GameObject target)
    {
        panelDeskripsi.SetActive(true);

        textNamaObject.text = target.name; //mengambil nama dari nama objek

        for (int i = 0; i < objectAktif.Length; i++)
        {
            if (target.name == objectAktif[i].name)
            {
                textDeskripsiObject.text = keteranganObjects[i]; //mengambiil deskripsi dari index yang sama dengan objek aktif

                break;
            }
        }
        
    }
    public void OnTargetLost()
    {
        panelDeskripsi.SetActive(false);
    }
}