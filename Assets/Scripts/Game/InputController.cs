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
        if (context.phase == InputActionPhase.Performed && beatmap.totalNotes[row].Count > 0)
        {
            Note noteScript = beatmap.totalNotes[row][0].GetComponent<Note>();
            float timeDifference = Math.Abs(noteScript.songPosition - Conductor.Instance.songPosition) - offset;

            if (timeDifference <= 0.046f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Beatmap.Instance.combo++;
                Beatmap.Instance.score += 1000;
            }
            else if (timeDifference <= 0.120f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Beatmap.Instance.combo++;
                Beatmap.Instance.score += 500;
            }
        }
    }

    private void longNoteInput(InputAction.CallbackContext context, int row, float offset = 0.045f)
    {
        if (context.performed && beatmap.totalNotes[row].Count > 0)
        {
            Note noteScript = beatmap.totalNotes[row][0].GetComponent<Note>();
            float timeDifference = Math.Abs(noteScript.songPosition - Conductor.Instance.songPosition) - offset;

            if (timeDifference <= 0.046f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Beatmap.Instance.combo++;
                Beatmap.Instance.score += 1000;
            }
            else if (timeDifference <= 0.120f)
            {
                Destroy(beatmap.totalNotes[row][0]);
                beatmap.totalNotes[row].RemoveAt(0);
                Beatmap.Instance.combo++;
                Beatmap.Instance.score += 500;
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

    public void LongBT1(InputAction.CallbackContext context)
    {
        longNoteInput(context, 8);
    }

    public void LongBT2(InputAction.CallbackContext context)
    {
        longNoteInput(context, 9);
    }

    public void LongBT3(InputAction.CallbackContext context)
    {
        longNoteInput(context, 10);
    }

    public void LongBT4(InputAction.CallbackContext context)
    {
        longNoteInput(context, 11);
    }

    public void LongFX1(InputAction.CallbackContext context)
    {
        longNoteInput(context, 12);
    }

    public void LongFX2(InputAction.CallbackContext context)
    {
        longNoteInput(context, 13);
    }


    private void OnDisable()
    {
        controls.Disable();
    }
}
