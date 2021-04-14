using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordList : MonoBehaviour
{
    //Static Variable has the same value the out all the program
    static List<int> chords;
    static int selectedChord;
    static bool socketActive;
    

    public static void SetSelectedChord(int chordID)
    {
        selectedChord = chordID;
        socketActive = true;
    }
    public static void SetSoketID(int socketNumber)
    {
        if(socketActive)
        {
            SetChord(socketNumber, selectedChord);
            socketActive = false;
            print("yes");
        }
    }

    //Function to give the values in certain positions of the list
    public static void SetChord(int position, int value)
    {
        chords[position] = value;
    }


    public static bool GetSocketActive()
    {
        return socketActive;
    }




    //Creating the new list on awake
    private void Awake()
    {
        chords = new List<int>() { 0, 0, 0, 0 };
    }
}


