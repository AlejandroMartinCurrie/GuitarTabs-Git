using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Chord", menuName = "Chords")]

public class Chords : ScriptableObject
{   
    public string chordName;
    public int barreChords;
    public int ChordID;
          
    public List<int> indexFinger;
    public List<int> middleFinger;
    public List<int> ringFinger;
    public List<int> pinkyFinger;

}
