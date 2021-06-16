using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCamera : MonoBehaviour
{
    void Start()
    {
    }


    void Update()
    {
        if (Conductor.Instance.musicSource.isPlaying)
            transform.position = new Vector3(19.62f, 10.97101f, 
                (Conductor.Instance.songPositionInBeats * ((float)Beatmap.Instance.measureSize/ Beatmap.Instance.timeSignatureTop)-22.4f));
    }
}
