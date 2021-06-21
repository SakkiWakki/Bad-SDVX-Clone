using System;
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

    private void chipInput(InputAction.CallbackContext context, int row, float offset = 0.045f)
    {
        Note noteScript = beatmap.totalNotes[row][0].GetComponent<Note>();
        if (context.started)
        {
            Debug.Log(noteScript.songPosition);
            float timeDifference = Math.Abs(noteScript.songPosition - Conductor.Instance.songPosition) - offset;

            if (timeDifference <= 0.046f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Debug.Log("1 : " + timeDifference + " Critical");
            }
            else if (timeDifference <= 0.120f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Debug.Log("1 : " + timeDifference + " Near");
            }
        }
    }

    public void BT1(InputAction.CallbackContext context)
    {
        chipInput(context, 0);
    }

    public void BT2(InputAction.CallbackContext context)
    {
        chipInput(context, 1);
    }

    public void BT3(InputAction.CallbackContext context)
    {
        chipInput(context, 2);
    }

    public void BT4(InputAction.CallbackContext context)
    {
        chipInput(context, 3);
    }

    public void FX1(InputAction.CallbackContext context)
    {
        chipInput(context, 4);
    }

    public void FX2(InputAction.CallbackContext context)
    {
        chipInput(context, 5);
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
