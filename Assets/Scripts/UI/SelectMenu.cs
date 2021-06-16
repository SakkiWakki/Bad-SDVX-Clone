using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenu : GameManager
{
    // Start is called before the first frame update
    public void OnPlaceholderPress()
    {
        GameManager.Instance.SwitchState(GameManager.State.SONG);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
