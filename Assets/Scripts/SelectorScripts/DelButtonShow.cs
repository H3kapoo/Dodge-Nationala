using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DelButtonShow : MonoBehaviour {

    public GameObject[] DelButtons;

    void Update () {

        for(int i = 0; i < DelButtons.Length; i++)
        {
            if (GameObject.Find("Canvas").GetComponent<FillLoadMenu>().Filled[i])
            {
                DelButtons[i].GetComponent<Image>().enabled = true;
                DelButtons[i].GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            }
            else
            {
                DelButtons[i].GetComponent<Image>().enabled = false;
                DelButtons[i].GetComponentInChildren<TextMeshProUGUI>().enabled = false;
            }
        }
	}
}
