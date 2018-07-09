using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VolumeLvlUpdate : MonoBehaviour {

	
	void Update () {
        if (SceneManager.GetActiveScene().name == "NewMenu")
        {
            GameObject.Find("SoundMenu").GetComponent<AudioSource>().volume = (float)GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[0]/100;
            GameObject.Find("SoundMenu").GetComponent<AudioSource>().mute = false;
        }
        if (SceneManager.GetActiveScene().name == "NewSelector")
        {
            GameObject.Find("SoundMenu").GetComponent<AudioSource>().mute = false;
        }
        if (SceneManager.GetActiveScene().name == "MainGame" || SceneManager.GetActiveScene().name == "MainGame2")
        {
            GameObject.Find("Manager").GetComponent<AudioSource>().volume = (float)GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1] / 100;
            GameObject.Find("SoundFX").GetComponent<AudioSource>().volume = (float)GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1] / 100;
            GameObject.Find("SoundMenu").GetComponent<AudioSource>().mute = true;
        }
    }
}
