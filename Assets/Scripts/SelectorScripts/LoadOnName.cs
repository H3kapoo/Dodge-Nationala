using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
public class LoadOnName : MonoBehaviour {

    public bool Loaded = false;
    void Update()//maybe update?
    {
        if (!Loaded && SceneManager.GetActiveScene().name=="NewSelector")
        {
            string Name = "/" + GameObject.FindGameObjectWithTag("PassName").GetComponent<PassName>().NameToPass + ".dge";
            if (File.Exists(Application.persistentDataPath + Name))
            {
                using (FileStream file = File.Open(Application.persistentDataPath + Name, FileMode.Open))
                {
                    WhatToSave load = new WhatToSave();
                    BinaryFormatter bf = new BinaryFormatter();
                    load = (WhatToSave)bf.Deserialize(file);
                    for (int i = 0; i < load.Completed.Length; i++)
                    {
                        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Completed[i] = load.Completed[i];
                    }
                }
            }
            Loaded = true;
        }
        if ( SceneManager.GetActiveScene().name != "NewSelector")
        {
            Loaded = false;
        }
    }
}
