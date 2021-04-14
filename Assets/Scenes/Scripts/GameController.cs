using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameController : MonoBehaviour
{
    
    
    //Variables
    [SerializeField] Chords currentChord;
    [SerializeField] GameObject fingerPixel;
    [SerializeField] Camera mainCamera;
    [SerializeField] Text chordText;

    public Slider timeBar;
    private float newSpace;
    private float newFspace;
    private TextMeshProUGUI fingerText;

    List<GameObject> fingerInstances;

    public float timer;


    public float timePassed;

    public List<Chords> chordCollection;

    public int setTimer1;
    public int setTimer2;
    public int setTimer3;
    public int[] numberarray;
    int currentChordIndex;
    int clickNUmber;


    public bool randomizedOn;
    public bool nextC;

    public GameObject buttonAR;

    public Button nextButton;
    public Button previousButton;


    void Start()
    {
        
        timeBar.maxValue = 20f;
        setTimer1 = 10;
        setTimer2 = 20;
        setTimer3 = 30;

        

        randomizedOn = false;
        fingerInstances = new List<GameObject>();
        timer = 20f;
        newFspace = GetComponent<PixelEditor>().fretSpace;
        newSpace = GetComponent<PixelEditor>().space;
        currentChordIndex = 0;
        currentChord = chordCollection[numberarray[currentChordIndex]];
        Refresh();        
    }

    public void Set10seconds()
    {
        timeBar.maxValue = setTimer1;
        timer = setTimer1;
        timePassed = 0;
        
    }
    public void Set20seconds()
    {
        timeBar.maxValue = setTimer2;
        timer = setTimer2;
        timePassed = 0;
    }
    public void Set30seconds()
    {
        timeBar.maxValue = setTimer3;
        timer = setTimer3;
        timePassed = 0;
    }
    public void ActivateRandomizer()
    {
        randomizedOn = true;    
        clickNUmber++;
    }
    public void DeActivateRandom()
    {
        randomizedOn = false;
        clickNUmber = 0;
    }
    public void Randomize()
    {        
        if( clickNUmber <=1)
        {
            buttonAR.GetComponentInChildren<Text>().text ="Auto";
            nextButton.gameObject.SetActive(false);
            previousButton.gameObject.SetActive(false);
            if (timePassed > timer)
            {
                print(numberarray.Length);
                currentChord = chordCollection[numberarray[Random.Range(0, numberarray.Length)]];
                
                
                timePassed = 0;
                Refresh();
            }
        }
        else
        {
            buttonAR.GetComponentInChildren<Text>().text ="Manual";
            clickNUmber = 0;
            randomizedOn = false;
            nextButton.gameObject.SetActive(true);
            previousButton.gameObject.SetActive(true);
            GetCurrentChord();            
        }
    }

    public void TimerCount()
    {
        timePassed = timePassed+Time.deltaTime;
        timePassed.ToString("0");

    }
    public void GetCurrentChord()
    {
            currentChordIndex++;
            if(currentChordIndex>= numberarray.Length)
            {
                currentChordIndex = 0;
            }
            currentChord = chordCollection[numberarray[currentChordIndex]];
            Refresh();
    }
    public void GetLastChord()
    {
        currentChordIndex--;
        if (currentChordIndex <=0)
        {
            currentChordIndex = 3;
        }
        currentChord = chordCollection[numberarray[currentChordIndex]];
        Refresh();

    }

    //Functions
    public void Refresh()
    {
        print(chordCollection);
        print(currentChord);
        print(currentChordIndex);
        chordText.text = currentChord.chordName;
        foreach (GameObject g in fingerInstances)
        {
            Destroy(g);

        }

        fingerInstances.Clear();

        for (int i = 0; i < currentChord.indexFinger.Count; i++)
        {
            if (currentChord.indexFinger[i] > 0)
            {
                GameObject g = Instantiate(fingerPixel, new Vector3((5 - i) * newSpace, (4 + newFspace / 2f) - newFspace * currentChord.indexFinger[i], 0f), Quaternion.identity);

                g.GetComponentInChildren<TextMeshProUGUI>().text ="1";
                fingerInstances.Add(g);
                //print(fingerText);
            }
        }
        for (int i = 0; i < currentChord.middleFinger.Count; i++)
        {
            if (currentChord.middleFinger[i] > 0)
            {
                GameObject g = Instantiate(fingerPixel, new Vector3((5 - i) * newSpace, (4 + newFspace / 2f) - newFspace * currentChord.middleFinger[i], 0f), Quaternion.identity);
                g.GetComponentInChildren<TextMeshProUGUI>().text = "2";
                fingerInstances.Add(g);
            }
        }
        for (int i = 0; i < currentChord.ringFinger.Count; i++)
        {
            if (currentChord.ringFinger[i] > 0)
            {
                GameObject g = Instantiate(fingerPixel, new Vector3((5 - i) * newSpace, (4 + newFspace / 2f) - newFspace * currentChord.ringFinger[i], 0f), Quaternion.identity);
                g.GetComponentInChildren<TextMeshProUGUI>().text = "3";
                fingerInstances.Add(g);
            }
        }
        for (int i = 0; i < currentChord.pinkyFinger.Count; i++)
        {
            if (currentChord.pinkyFinger[i] > 0)
            {
                GameObject g = Instantiate(fingerPixel, new Vector3((5 - i) * newSpace, (4 + newFspace / 2f) - newFspace * currentChord.pinkyFinger[i], 0f), Quaternion.identity);
                g.GetComponentInChildren<TextMeshProUGUI>().text = "4";
                fingerInstances.Add(g);
            }
        }
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
       
        if (randomizedOn)
        {
            TimerCount();
            Randomize();
            timeBar.value = timePassed;
        }
        else
        {
            timePassed = 0;
            timeBar.value = 0;
        }
        
        
        //print(timePassed);


    }
}
