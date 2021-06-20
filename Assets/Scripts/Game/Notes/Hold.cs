using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class Hold : MonoBehaviour
{

    //Where the note appears, in beats
    public float beatPosition;

    //The time the note appears in the song
    public float songPosition;

    //The note's physical position
    public Vector3 position;

    //The note's row number
    public int row;

    Hold previousNote;

    [SerializeField] public SpriteAtlas atlas;
    [SerializeField] public string spriteName;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = atlas.GetSprite(spriteName);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
