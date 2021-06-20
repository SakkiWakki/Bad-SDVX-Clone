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
        beatmap = this.gameObject.GetComponent<Beatmap>();
    }

    private void OnEnable()
    {
        controls.Enable();


    }

    public void BT1(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("1");
            Destroy(beatmap.totalNotes[0][0]);
            beatmap.totalNotes[0].RemoveAt(0);
        }
    }

    public void BT2(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("2");
            Destroy(beatmap.totalNotes[1][0]);
            beatmap.totalNotes[1].RemoveAt(0);
        }
    }

    public void BT3(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("3");
            Destroy(beatmap.totalNotes[2][0]);
            beatmap.totalNotes[2].RemoveAt(0);
        }
    }

    public void BT4(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("4");
            Destroy(beatmap.totalNotes[3][0]);
            beatmap.totalNotes[3].RemoveAt(0);
        }
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
