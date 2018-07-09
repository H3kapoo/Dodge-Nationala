using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveComplete : MonoBehaviour {

    public void SaveData()
    {
        string Name = GameObject.Find("PassNameToSelector").GetComponent<PassName>().NameToPass;
        string Path = Application.persistentDataPath + "/" + Name + ".dge";

        WhatToSave save = new WhatToSave();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Path, FileMode.OpenOrCreate);
        for (int i = 0; i < save.Completed.Length; i++)
        {
            save.Completed[i] = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Completed[i];
        }
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("PROGRESS SAVED");
    }
}
