using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////NO SUPPORT FOR VARIBLE TIME SIGNITURES OR BPM YET////
public class Beatmap : MonoBehaviour
{
    public int timeSignitureTop = 4;
    public List<List<Note>> totalNotes;

    public static Beatmap Instance;
    public float measureSize = 150;

    //Notes
    public GameObject BTNote;

    Parser parser;


    public void CreateNote(string note, float x, float y, float z)
    {
        if (note.Equals("BT"))
        {
            Transform pos = Instance.GetComponent<Transform>();
            pos.position = new Vector3(x, y, z);
            Instantiate(BTNote, pos);
        }
    }
    void Start()
    {
        //INIT
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
        }

        //Create chart
        parser = new Parser("Z:/Unity Projects/Bad SDVX Clone/Assets/Resources/666/mxm.ksh");
        parser.KSHMap();
    }


    void Update()
    {
        
    }
}
