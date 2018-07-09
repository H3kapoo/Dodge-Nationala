using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lvlIndxr : MonoBehaviour {

    public int Index;
    public void Update()
    {
        if (GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Completed[Index])
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}

