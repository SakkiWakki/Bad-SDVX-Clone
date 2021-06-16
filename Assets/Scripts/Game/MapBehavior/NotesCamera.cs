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
        float cameraPos = (Conductor.Instance.songPositionInBeats * ((float)Beatmap.Instance.measureSize / Beatmap.Instance.timeSignatureTop));
        if (Conductor.Instance.musicSource.isPlaying)
            transform.position = new Vector3(19.62f, 10.97101f, cameraPos - offset);
    }
}
