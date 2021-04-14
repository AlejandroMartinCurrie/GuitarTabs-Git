using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChordSocket : MonoBehaviour
{
    public int numberEntered;
    public string chorNameGot;
    public int socketID;
    public bool pressedSelection;
    public Color originalColor;
    public GameObject listColor;

    // Start is called before the first frame update
    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
    }


    public void OnMouseDown()
    {
        ChordList.SetSoketID(socketID);
        GetComponentInChildren<TextMeshPro>().text = chorNameGot;
    }

   
    void Update()
    {
       
    }
}
