
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

    void Start()
    {
        
    }

    void Update()
    {
        switch (row) {
            case 1:
                break;
            case 2:
                break;
            case 3:

                break;
            case 4:

                break;
        }
            
    }

    //For use in update UPDATE FOR NEW INPUT SYSTEM
    void HitCondition()
    {
        
    }
}
