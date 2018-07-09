using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LifeDisplay : MonoBehaviour {

    public TextMeshProUGUI LifeShow;

    void Start()
    {
        LifeDisply();
    }
	void Update () {
        LifeDisply();
    }
    void LifeDisply()
    {
        LifeShow.text = "Lifes: " + GameObject.Find("PlayerManager").GetComponent<PlayerManager>().Life.ToString();
    }
}
