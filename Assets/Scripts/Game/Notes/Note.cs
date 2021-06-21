
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Note : MonoBehaviour
{
    //Where the note appears, in beats
    public float beatPosition;

    //The time the note appears in the song
    public float songPosition;

    //The note's physical position
    public Vector3 position;

    //The note's row number
    public int row;

    void Update()
    {
        //Auto
        //if (Conductor.Instance.songPosition >= songPosition)
        //{
        //    Destroy(this.gameObject);
        //}

        if (Conductor.Instance.songPosition - songPosition - 0.045f > 0.12f)
        {
            Destroy(this.gameObject);
            Beatmap.Instance.totalNotes[row-1].RemoveAt(0);
            Debug.Log(row + ": Miss");
        }
    }

    public virtual string getType() {
        return "Note";
    }
}
