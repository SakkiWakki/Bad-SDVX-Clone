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
    public GameObject FXNote;

    public GameObject BTHold;

    //Uses the parser class to help read the KSH file.
    Parser parser;


    //List of list of notes
    public List<GameObject>[] totalNotes = new List<GameObject>[8];

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

        for (int i = 0; i < 8; i++)
        {
            totalNotes[i] = new List<GameObject>();
        }


        //Create chart, also current test code
        parser = new Parser("./Assets/Resources/666/adv.ksh");
        parser.KSHMap();
    }


    void Update()
    {

    }

    //Creates notes on map
    public void CreateNote(string note, int measureCount, int onSectionNum, int totalSectionCount)
    {
        float z = (measureSize * (measureCount + (float)onSectionNum / totalSectionCount));
        if (z == 15300) Debug.Log("measureCount " + measureCount + " onSectionNum " + onSectionNum + " totalSectionCount " + totalSectionCount);
        switch (note)
        {
            case "BT1":
                totalNotes[0].Add(positionNotes(BTNote, 17.6f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 1));
                break;
            case "BT2":
                totalNotes[1].Add(positionNotes(BTNote, 18.94f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 2));
                break;
            case "BT3":
                totalNotes[2].Add(positionNotes(BTNote, 20.3f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 3));
                break;
            case "BT4":
                totalNotes[3].Add(positionNotes(BTNote, 21.65f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 4));
                break;
            case "FX1":
                totalNotes[4].Add(positionNotes(FXNote, 18.27f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 5));
                break;
            case "FX2":
                totalNotes[5].Add(positionNotes(FXNote, 20.98f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 6));
                break;

        }
    }

    //Creates long note
    public void createHoldNote(string note, int measureCount, int onSectionNum, int totalSectionCount) {

        switch (note) {
            case "BT1":
                
                break;
            case "BT2":
                
                break;
            case "BT3":
                
                break;
            case "BT4":
                
                break;
            case "FX1":
                
                break;
            case "FX2":
                
                break;
        }

    }

    //For use in CreateNote()
    public GameObject positionNotes(GameObject noteType, float x, float y, float z, int measureCount, int onSectionNum, int totalSectionCount, int row)
    {
        GameObject note = Instantiate(noteType, this.gameObject.transform);
        Transform pos = note.GetComponent<Transform>();
        pos.position = new Vector3(x, y, z);
        Note script = note.GetComponent<Note>();
        script.beatPosition = timeSignatureTop * (measureCount + (float)onSectionNum / totalSectionCount) + 1;
        script.songPosition = script.beatPosition * Conductor.Instance.secPerBeat;
        script.row = row;

        return note;
    }


    public void positionHoldNotes(GameObject noteType, float x, float y, float z, int measureCount, int onSectionNum, int totalSectionCount, int row) {

        GameObject note = Instantiate(noteType, this.gameObject.transform);
        Transform pos = note.GetComponent<Transform>();
        pos.position = new Vector3(x, y, z);
        Hold script = note.GetComponent<Note>();
        script.beatPosition = timeSignatureTop * (measureCount + (float)onSectionNum/totalSectionCount) + 1;
        script.songPosition = script.beatPosition * Conductor.Instance.secPerBeat;
        script.row = row;

    }
}
}

