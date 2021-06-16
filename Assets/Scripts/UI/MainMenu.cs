using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : GameManager
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }

    public void StartClicked()
    {
        GameManager.Instance.SwitchState(GameManager.State.SELECTINIT, 1.5f);
    }
}
