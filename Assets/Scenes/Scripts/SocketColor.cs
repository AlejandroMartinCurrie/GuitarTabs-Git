using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketColor : MonoBehaviour
{
    public Color currentColor;

    void Start()
    {
        currentColor = GetComponentInChildren<SpriteRenderer>().color;    
    }

    // Update is called once per frame
    void Update()
    {
        if(ChordList.GetSocketActive())
        {
            print("Activo");
        }
    }
}
