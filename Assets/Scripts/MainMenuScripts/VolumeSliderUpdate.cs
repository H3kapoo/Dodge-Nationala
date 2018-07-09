using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class VolumeSliderUpdate : MonoBehaviour {

    private void Update()
    {
        GameObject.Find("MenuPerc").GetComponent<TextMeshProUGUI>().text = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[0].ToString()+"%";
        GameObject.Find("GamePerc").GetComponent<TextMeshProUGUI>().text = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1].ToString() + "%";
        GameObject.Find("MenuVolSlide").GetComponent<Slider>().value = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[0];
        GameObject.Find("GameVolSlide").GetComponent<Slider>().value = GameObject.Find("SoundMenu").GetComponent<VolumeHolder>().Volume[1];
    }
}
