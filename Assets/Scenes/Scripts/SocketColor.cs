using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketColor : MonoBehaviour
{
    public Color currentColor;
    public GameObject[] socketCollection;

    void Start()
    {
        //currentColor = socketCollection.GetComponentInChildren<SpriteRenderer>().color;
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach(GameObject sp in socketCollection)
        {

        }
        if(ChordList.GetSocketActive())
        {
            print(currentColor);
                        socketCollection.GetComponentInChildren<SpriteRenderer>().color = Color.blue;

        }
        else
        {
            socketCollection.GetComponentInChildren<SpriteRenderer>().color = currentColor;
        }
    }
}
