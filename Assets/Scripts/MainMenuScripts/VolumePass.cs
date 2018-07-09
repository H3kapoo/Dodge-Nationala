using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumePass : MonoBehaviour {

	public void VolumePasser(int VolumeIndex)
    {
        GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[VolumeIndex]=(int)GetComponent<Slider>().value;
    }
}
