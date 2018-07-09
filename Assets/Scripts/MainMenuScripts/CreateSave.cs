using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class CreateSave : MonoBehaviour {


    public void CreateTheSave()
    {
        if (GameObject.FindGameObjectWithTag("PlayerNameField").GetComponent<TextMeshProUGUI>().text.Length < 4)
        {
            Debug.Log("Name Too Short");
        }
        else
        {
            DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath + "/");
            FileInfo[] info = dir.GetFiles("*.dge");
            if (info.Length == 5)
            {
                Debug.Log("Full Occupied Slots");
            }
            else
            {
                EmptySave();
            }

        }
    }
    void EmptySave()
    {
        BinaryFormatter bf = new BinaryFormatter();
        Debug.Log("Name It's Ok");
        string Name = GameObject.FindGameObjectWithTag("PlayerNameField").GetComponent<TextMeshProUGUI>().text;
        FileStream file = File.Open(Application.persistentDataPath + "/" + Name + ".dge", FileMode.OpenOrCreate);
        WhatToSave save = new WhatToSave();
        save.Completed[0] = true;
        for (int i = 1; i < save.Completed.Length; i++)
        {
            save.Completed[i] = false;
        }
        save.Completed[26] = true;
        bf.Serialize(file, save);
        file.Close();
    }
}
