using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;
public class DeleteSave : MonoBehaviour {

    public GameObject Slot;
    public string TextHolder;
    public int SlotNoToDel;
	public void DelSave()
    {
        string SaveName = Slot.GetComponent<TextMeshProUGUI>().text;
        string path = Application.persistentDataPath + "/" +SaveName + ".dge";
        Debug.Log(path);
        if (File.Exists(path))
        {
            File.Delete(path);
            GameObject.Find("Canvas").GetComponent<FillLoadMenu>().Filled[SlotNoToDel] = false;
            Slot.GetComponent<TextMeshProUGUI>().text = TextHolder;
            GameObject.Find("Occupied").GetComponent<ShowIsFull>().Checked = false;
            GameObject.Find("Occupied").GetComponent<ShowIsFull>().Occupied = 0;
            Debug.Log("Deleted: " + path);
        }
        else
        {
            Debug.Log("NoPath");
        }
    }
}
