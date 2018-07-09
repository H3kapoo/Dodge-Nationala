using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;
public class VolumeLoad : MonoBehaviour {

	void Start () {
        if (File.Exists(Application.persistentDataPath + "/Sound.sdge"))
        {
            using (FileStream file = File.Open(Application.persistentDataPath + "/Sound.sdge", FileMode.Open))
            {
                WhatToSave load = new WhatToSave();
                BinaryFormatter bf = new BinaryFormatter();
                load = (WhatToSave)bf.Deserialize(file);
                GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[0] = load.Volume[0];
                GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1] = load.Volume[1];
                Debug.Log("Volume Loaded" + " (" + load.Volume[0] + ")" + " (" + load.Volume[1] + ")");
            }
        }
    }
}
