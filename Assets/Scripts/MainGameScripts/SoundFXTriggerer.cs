using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXTriggerer : MonoBehaviour {
    public AudioSource MasterFX;
    public bool TriggerPoint, TriggerBuff, TriggerHealth,TriggerDamage;

    public void Update()
    {
        if (TriggerPoint)
        {
            GameObject.Find("SoundFX").GetComponent<AudioSource>().clip = GameObject.Find("SoundFX").GetComponent<SoundFXHolder>().FX[0];
            MasterFX.Play();
            TriggerPoint = false;
        }
        if (TriggerBuff)
        {
            GameObject.Find("SoundFX").GetComponent<AudioSource>().clip = GameObject.Find("SoundFX").GetComponent<SoundFXHolder>().FX[1];
            MasterFX.Play();
            TriggerBuff = false;
        }
        if (TriggerHealth)
        {
            GameObject.Find("SoundFX").GetComponent<AudioSource>().clip = GameObject.Find("SoundFX").GetComponent<SoundFXHolder>().FX[2];
            MasterFX.Play();
            TriggerHealth = false;
        }
        if (TriggerDamage)
        {
            GameObject.Find("SoundFX").GetComponent<AudioSource>().clip = GameObject.Find("SoundFX").GetComponent<SoundFXHolder>().FX[3];
            MasterFX.Play();
            TriggerDamage = false;
        }
    }
}
