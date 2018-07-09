using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowIsFull : MonoBehaviour {

    public int Occupied;
    public bool Checked = false;
	void Update () {
        int Fillers = GameObject.Find("Canvas").GetComponent<FillLoadMenu>().Filled.Length;

        if (!Checked)
        {
            for (int i = 0; i < Fillers; i++)
            {
                if (GameObject.Find("Canvas").GetComponent<FillLoadMenu>().Filled[i])
                {
                    Occupied++;
                }

            }
            Checked = true;
        }

        if (Occupied==5)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
	}
}
