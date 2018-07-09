using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LoadFromSlot : MonoBehaviour {

    public GameObject Slot;
    public int SlotNo;
	public void LoadSlot()
    {
        string name = Slot.GetComponent<TextMeshProUGUI>().text;
        GameObject.FindGameObjectWithTag("PassName").GetComponent<PassName>().NameToPass = name;
        if (GameObject.Find("Canvas").GetComponent<FillLoadMenu>().Filled[SlotNo])
        {
            SceneManager.LoadScene("NewSelector");
        }
        else
        {
            Debug.Log("No Save There");
        }
    }
}
