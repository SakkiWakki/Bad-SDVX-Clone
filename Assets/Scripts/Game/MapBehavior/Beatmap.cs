using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////NO SUPPORT FOR VARIBLE TIME SIGNITURES OR BPM YET////
public class Beatmap : MonoBehaviour
{
    //Temp music stuff, test code
    public int timeSignatureTop = 4;
    public int measureSize;

    //Notes
    public GameObject BTNote;

    //Uses the parser class to help read the KSH file.
    Parser parser;

    public static Beatmap Instance;
    void Start()
    {
        //INIT
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //Create chart, also current test code
        parser = new Parser("Z:/Unity Projects/Bad SDVX Clone/Assets/Resources/666/mxm.ksh");
        parser.KSHMap();
    }


    void Update()
    {
        
    }

    //Creates notes on map
    public void CreateNote(string note, float z) 
    {
        switch (note)
        {
            case "BT1":
                positionNotes(17.6f, 0.01f, z);
                break;
            case "BT2":
                positionNotes(18.94f, 0.01f, z);
                break;
            case "BT3":
                positionNotes(20.3f, 0.01f, z);
                break;
            case "BT4":
                positionNotes(21.65f, 0.01f, z);
                break;

        }
    }

    //For use in CreateNote()
    public void positionNotes(float x, float y, float z)
    {
        Transform pos = BTNote.GetComponent<Transform>();
        pos.position = new Vector3(x, y, z);
        Instantiate(BTNote, pos);
    }
}
