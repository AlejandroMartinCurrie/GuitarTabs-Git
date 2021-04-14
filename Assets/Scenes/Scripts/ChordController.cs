using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChordController : MonoBehaviour
{
    public Chords currentChord;
    private TextMeshProUGUI chordName;
    
    public string nameOfChord;
    public string chordnameGot;


    public int chordID;
    private int clickCounter;
   
    private Vector3 startPosition;
    public GameObject selectionController;
    public Color currentColor;
    void Start()
    {
        nameOfChord = currentChord.chordName;
        chordID = currentChord.ChordID;

        GetComponentInChildren<TextMeshPro>().text = nameOfChord;
        startPosition = transform.position;
        currentColor = selectionController.GetComponentInChildren<SpriteRenderer>().color;
        clickCounter = 1;
    }
    public void ChangePosition()
    {
        transform.position = startPosition;
    }

    public void OnMouseDown()
    {
        ChordList.SetSelectedChord(chordID);
    }

    


    void Update()
    {
        
    }
}
