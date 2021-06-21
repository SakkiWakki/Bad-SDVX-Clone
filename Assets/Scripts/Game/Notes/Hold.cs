using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class Hold : Note
{
    public Hold previousNote; //reference to the previous note thats connected to this section
    public Hold nextNote; //reference to the next note thats connected to this section

    string state = "normal";

    [SerializeField] public SpriteAtlas atlas;
    [SerializeField] public string spriteName;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite(spriteName);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Conductor.Instance.songPosition >= songPosition && this.state != "dim") { //check to see if the songpostion is past this note, need to rewrite so that it dont call when theres an input
            turnDim(this);
        }
        
    }           

    void turnDim(Hold note) { //turn all section linked to this note dim
        note.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite("dim");
        note.state = "dim";
        if (note.nextNote != null) {
            turnDim(note.nextNote);
        }
    }

    void turnBright(Hold note) { //turn all section linked to this note bright
        note.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite("bright");
        note.state = "bright";
        if (note.nextNote != null) {
            turnBright(note.nextNote);
        }
    }

    public override string getType() {
        return "Hold";
    }
}
