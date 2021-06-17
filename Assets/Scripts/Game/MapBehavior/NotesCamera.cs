using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesCamera : MonoBehaviour
{
    private float songPositionInZ;
    private float offset;
    void Start()
    {
    }


    void Update()
    {
        float songPositionInZ = Conductor.Instance.songPosition * (Conductor.Instance.beatPerSec*((float)Beatmap.Instance.measureSize/Beatmap.Instance.timeSignatureTop));
        offset = 0.25f * Beatmap.Instance.measureSize + 23.6f;
        if (Conductor.Instance.musicSource.isPlaying)
            transform.position = new Vector3(19.62f, 10.97101f, songPositionInZ-offset);
    }
}
