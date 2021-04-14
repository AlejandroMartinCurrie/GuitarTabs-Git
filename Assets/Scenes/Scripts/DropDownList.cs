using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownList : MonoBehaviour
{

    public GameObject aChords;
    public GameObject bChords;
    public GameObject cChords;
    public GameObject dChords;
    public GameObject eChords;
    public GameObject fChords;
    public GameObject gChords;

    public void DropDownHandler(int val)
    {  
        if(val == 0)
        {
            aChords.SetActive(true);
        }
        else
        {
            aChords.SetActive(false);
        }
        if (val == 1)
        {
            bChords.SetActive(true);
        }
        else
        {
            bChords.SetActive(false);
        }
        if (val == 2)
        {
            cChords.SetActive(true);
        }
        else
        {
            cChords.SetActive(false); 
        }
        if (val == 3)
        {
            dChords.SetActive(true);
        }
        else
        {
            dChords.SetActive(false);
        }
        if (val == 4)
        {
            eChords.SetActive(true);
        }
        else
        {
            eChords.SetActive(false);
        }
        if (val == 5)
        {
            fChords.SetActive(true);
        }
        else
        {
            fChords.SetActive(false);
        }
        if (val == 6)
        {
            gChords.SetActive(true);
        }
        else
        {
            gChords.SetActive(false);
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            aChords.SetActive(false);
        }
    }


}
