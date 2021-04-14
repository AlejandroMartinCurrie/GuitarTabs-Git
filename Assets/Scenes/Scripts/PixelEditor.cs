using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelEditor : MonoBehaviour
{
    //Variables 
    
    [SerializeField] GameObject cordPixel;
    [SerializeField] GameObject fretPixel;
    


    [SerializeField] Camera mainCamera;
    
    List<GameObject> strings;
    List<GameObject> frets;
 

    public float space;
    public float fretSpace;





    //Function to create the cords for the virtual guitar
    public void CreatingCords()
    {
        //Changing the color of the cords
        cordPixel.GetComponent<SpriteRenderer>().color = Color.black;

        //Using the list created to generate mutiple cords in the scene
        strings = new List<GameObject>();

        for (int i = 0; i < 6; i++)
        {
            strings.Add(Instantiate(cordPixel, new Vector3(0f, 0f, 0f), Quaternion.identity));
        }

        //Spacing the cords in the scene
        for (int i = 0; i < 6; i++)
        {
            strings[i].transform.position = new Vector3(space * i, 0f, 0f);
        }

    }

    //Function to create the frets of the guitar
    public void CreatingFrets()
    {
        //Changing the color of the frets

        fretPixel.GetComponent<SpriteRenderer>().color = Color.black;

        //Using the list created to generate mutiple cords in the scene
        frets = new List<GameObject>();

        for(int i = 0; i< 6; i++)
        {
            frets.Add(Instantiate(fretPixel, new Vector3(0f,0f, 0f), Quaternion.identity));
            float scaleY = 0.5f;
            if(i!= 0)
            {
                scaleY = 0.2f;
            }
            frets[i].transform.localScale = new Vector3(5*space, scaleY, 1f);
        }

        for (int i = 0; i < 6; i++)
        {
            frets[i].transform.position = new Vector3(mainCamera.transform.position.x, 4- fretSpace * i, 0f);
        }
    }

    
    
    void Start()
    {
        //Moving the camera so that the image is in the center of the screen
        mainCamera.transform.position = new Vector3(2.5f * space, 0f, mainCamera.transform.position.z);


        //Initializing the creation of the cords
        CreatingCords();
        CreatingFrets();


        fretSpace = 1.6f;

    }

    
    void Update()
    {

       
    }
}
