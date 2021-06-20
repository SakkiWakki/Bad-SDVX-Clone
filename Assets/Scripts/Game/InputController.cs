using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    GameControls controls;

    Beatmap beatmap;
    private void Awake()
    {
        controls = new GameControls();
        controls.Gameplay.BT.performed += cxt => OnPress(cxt.control);
    }

    private void OnEnable()
    {
        controls.Enable();
       

    }

    private void OnPress(InputControl control)
    {
        beatmap = this.gameObject.GetComponent<Beatmap>();
        switch (control.name)
        {
            case "q":
                beatmap.totalNotes[0].RemoveAt(0);
                Destroy(beatmap.totalNotes[0][0]);
                break;
            case "w":
                beatmap.totalNotes[1].RemoveAt(0);
                Destroy(beatmap.totalNotes[1][0]);
                break;
            case "numpad8":
                beatmap.totalNotes[2].RemoveAt(0);
                Destroy(beatmap.totalNotes[2][0]);
                break;
            case "numpad9":
                beatmap.totalNotes[3].RemoveAt(0);
                Destroy(beatmap.totalNotes[3][0]);
                break;
            default:
                break;
        }
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
