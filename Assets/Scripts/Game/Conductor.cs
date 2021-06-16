using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    //Offset of the song
    public float offset;

    public float songBpm;
    public float secPerBeat;

    //Current song position, in seconds
    public float songPosition;

    //Current song position, in beats
    public float songPositionInBeats;

    //How many seconds have passed since the song started
    public float dspSongTime;
    public AudioSource musicSource;

    public GameObject beatmap;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        secPerBeat = 60f / songBpm;

        Invoke("StartSong", 3f);
    }

    void StartSong()
    {
        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        //Start the music
        musicSource.Play();

        //Create track
        Instantiate(beatmap);
    }

    void FixedUpdate()
    {
        if (musicSource.isPlaying)
        {
            songPosition = (float)(AudioSettings.dspTime - dspSongTime);
            songPositionInBeats = songPosition / secPerBeat;
        }
    }
}
