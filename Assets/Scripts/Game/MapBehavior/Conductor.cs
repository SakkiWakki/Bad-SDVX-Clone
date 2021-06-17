using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    //Offset of the song
    public float offset;

    public float songBpm;
    public float secPerBeat;
    public float beatPerSec;

    //Current song position, in seconds
    public float songPosition;

    //Current song position, in beats
    public float songPositionInBeats;

    //How many seconds have passed since the song started
    public double trackStartTime;
    public AudioSource musicSource;

    public GameObject beatmap;

    public static Conductor Instance;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        musicSource = GetComponent<AudioSource>();
        secPerBeat = 60f / songBpm;
        beatPerSec = songBpm / 60f;

        Invoke("StartSong", 2f);
    }

    void StartSong()
    {
        //Record the time when the music starts
        trackStartTime = AudioSettings.dspTime+1;
        musicSource.PlayScheduled(trackStartTime);

        //Start the music
        musicSource.Play();

        //Create track
        beatmap.SetActive(true);
    }

    void FixedUpdate()
    {
        if (musicSource.isPlaying)
        {
            songPosition = (float)(AudioSettings.dspTime - trackStartTime);
            songPositionInBeats = songPosition / secPerBeat;
        }
    }
}
