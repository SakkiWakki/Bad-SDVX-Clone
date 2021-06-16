using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCamera : MonoBehaviour
{

    public float offset;
    void Start()
    {
    }


    void Update()
    {
        float songPositionInZ = (Conductor.Instance.songPositionInBeats * 24.5f);
        if (Conductor.Instance.musicSource.isPlaying)
            transform.position = new Vector3(19.62f, 10.97101f, songPositionInZ-offset);
    }
}
