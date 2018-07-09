using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class VolumeSave : MonoBehaviour {

	public void SaveOnChange()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/Sound.sdge", FileMode.OpenOrCreate);
        WhatToSave save = new WhatToSave();
        save.Volume[0] = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[0];
        save.Volume[1] = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1];
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Volume Saved" + " (" + save.Volume[0] + ")" + " (" + save.Volume[1] + ")");
    }
}
