using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
    public GameObject FXHold;

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
        parser = new Parser("./Assets/Resources/666/mxm.ksh");
        parser.KSHMap();
    }


    void Update()
    {
        
    }

    //Creates notes on map
    public void CreateNote(string note, int measureCount, int onSectionNum, int totalSectionCount) 
    {
        float z = (measureSize * (measureCount + (float)onSectionNum / totalSectionCount));
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

        float z = (measureSize * (measureCount + (float)onSectionNum / totalSectionCount));

        switch (note) {
            case "BT1":
                totalNotes[0].Add(positionHoldNotes(BTHold, 17.6f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 1));
                break;
            case "BT2":
                totalNotes[1].Add(positionHoldNotes(BTHold, 18.94f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 2));
                break;
            case "BT3":
                totalNotes[2].Add(positionHoldNotes(BTHold, 20.3f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 3));
                break;
            case "BT4":
                totalNotes[3].Add(positionHoldNotes(BTHold, 21.65f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 4));
                break;
            case "FX1":
                totalNotes[4].Add(positionHoldNotes(FXHold, 18.27f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 5));
                break;
            case "FX2":
                totalNotes[5].Add(positionHoldNotes(FXHold, 20.98f, 0.005f, z, measureCount, onSectionNum, totalSectionCount, 6));
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
        script.beatPosition = timeSignatureTop * (measureCount + (float)onSectionNum/totalSectionCount) + 1;
        script.songPosition = script.beatPosition * Conductor.Instance.secPerBeat;
        script.row = row;

        return note;
    }

    public GameObject positionHoldNotes(GameObject noteType, float x, float y, float z, int measureCount, int onSectionNum, int totalSectionCount, int row) {

        GameObject note = Instantiate(noteType, this.gameObject.transform);
        Transform pos = note.GetComponent<Transform>();

        z -=  note.GetComponent<Renderer>().bounds.size.z * 2; //note offset

        float newSize = (float) measureSize / ((float) totalSectionCount / (float) timeSignatureTop); //calculate new size for note
        float scaleY = newSize / note.GetComponent<Renderer>().bounds.size.z; //calculate scale

        pos.localScale = new Vector3(1.9f, scaleY / 4, 2f); //change the scale, dk why / 4 is perfect
        z += note.GetComponent<Renderer>().bounds.size.z / 2; //note offset
        pos.position = new Vector3(x, y, z); //change position of note
        
        Hold script = note.GetComponent<Hold>(); //get the component of the note and change the values
        script.beatPosition = timeSignatureTop * (measureCount + (float)onSectionNum/totalSectionCount) + 1;
        script.songPosition = script.beatPosition * Conductor.Instance.secPerBeat;
        script.row = row;

        if (totalNotes[row - 1].Count == 0)
            return note;

        GameObject previous = totalNotes[row - 1][totalNotes[row - 1].Count - 1]; //get the previous note on the lane

        //kinda scuffed check, since its using note position and length which can vary alot, should implement something else like perhad record list of section number, though currently with high epsilon it work
        if (Math.Abs((previous.GetComponent<Transform>().position.z + previous.GetComponent<Renderer>().bounds.size.z) - z) < float.Epsilon + 20 && previous.GetComponent<Note>().getType() == "Hold") {
            script.previousNote = previous.GetComponent<Hold>();
            script.previousNote.nextNote = script;
        }

        return note;

    }
}
