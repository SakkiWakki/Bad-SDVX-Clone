using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text combo;
    public Text score;


    void Update()
    {
        combo.text = "Combo\n" + Beatmap.Instance.combo;
        score.text = "Score\n" + Beatmap.Instance.score;
    }
}
