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
    public void CreateNote(string note, int measureCount, int onSectionNum, int totalSectionCount) 
    {
        float z = (measureSize * (measureCount + (float)onSectionNum / totalSectionCount));
        switch (note)
        {
            case "BT1":
                positionNotes(17.6f, 0.01f, z, measureCount, onSectionNum, totalSectionCount, 1);
                break;
            case "BT2":
                positionNotes(18.94f, 0.01f, z, measureCount, onSectionNum, totalSectionCount, 2);
                break;
            case "BT3":
                positionNotes(20.3f, 0.01f, z, measureCount, onSectionNum, totalSectionCount, 3);
                break;
            case "BT4":
                positionNotes(21.65f, 0.01f, z, measureCount, onSectionNum, totalSectionCount, 4);
                break;

        }
    }

    //For use in CreateNote()
    public void positionNotes(float x, float y, float z, int measureCount, int onSectionNum, int totalSectionCount, int row)
    {
        Transform pos = BTNote.GetComponent<Transform>();
        pos.position = new Vector3(x, y, z);

        GameObject note = Instantiate(BTNote, pos);
        Note script = note.GetComponent<Note>();
        script.beatPosition = timeSignatureTop * (measureCount + (float)onSectionNum/totalSectionCount) + 1;
        script.songPosition = script.beatPosition * Conductor.Instance.secPerBeat;
        script.row = row;
    }
}
