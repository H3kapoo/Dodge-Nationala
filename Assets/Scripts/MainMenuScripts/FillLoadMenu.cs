using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
public class FillLoadMenu : MonoBehaviour {

    public GameObject[] Slots;
    public bool[] Filled;
    private void Start()
    {
        int i = 0;
        DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath + "/");
        FileInfo[] info = dir.GetFiles("*.dge");
        foreach (FileInfo f in info)
        {
            string g = f.Name;
            g = g.Substring(0, g.Length - 4);
            Debug.Log(g);
            Slots[i].GetComponent<TextMeshProUGUI>().text = g;
            Filled[i] = true;
            i++;
        }
    }
}
