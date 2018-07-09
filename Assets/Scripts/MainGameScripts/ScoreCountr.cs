using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCountr : MonoBehaviour {

    public TextMeshProUGUI ScoreCount;
    public bool PickedBuff_1 = false;
    public bool PickedBuff_2 = false;
    public bool PickedBuff_3 = false;
    public int Score=0;
    public int Buff1Score;
    public int Buff2Score;
    public int Buff3Score;

    private void Start()
    {
        ScoreCount.text =  "Score: " + Score.ToString();
    }
    void Update () {
        PickBuffCheck();
    }
    void PickBuffCheck()
    {
        if (PickedBuff_1)
        {
            Score += Buff1Score;
            ScoreCount.text = "Score: " + Score.ToString();
            PickedBuff_1 = false;
        }
        if (PickedBuff_2)
        {
            Score += Buff2Score;
            ScoreCount.text = "Score: " + Score.ToString();
            PickedBuff_2 = false;
        }
        if (PickedBuff_3)
        {
            Score += Buff3Score;
            ScoreCount.text = "Score: " + Score.ToString();
            PickedBuff_3 = false;
        }
    }
}
