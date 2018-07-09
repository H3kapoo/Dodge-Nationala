using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBuffs : MonoBehaviour {

    public TextMeshProUGUI Wleft;
    public TextMeshProUGUI Sleft;
    public bool PickedBuff_W = false;
    public bool PickedBuff_S = false;
    public int WBuff;
    public int SBuff;

    private void Start()
    {
        Wleft.text = "Wbuff: " +  WBuff.ToString();
        Sleft.text = "Sbuff: " + SBuff.ToString();
    }
    void Update () {
        CheckBuffPicked();
    }
    void CheckBuffPicked()
    {
        if (PickedBuff_W)
        {
            WBuff += 1;
            Wleft.text = "Wbuff: " + WBuff.ToString();
            PickedBuff_W = false;
        }
        if (PickedBuff_S)
        {
            SBuff += 1;
            Sleft.text = "Sbuff: " + SBuff.ToString();
            PickedBuff_S = false;
        }
    }
}
