using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBg : MonoBehaviour {

    public GameObject[] BackGrounds;

	void Update () {
		if(GameObject.Find("PassBG") != null)
        {
            if (GameObject.Find("PassBG").GetComponent<BgHolder>().BackGroundIndex == 0)
            {
                BackGrounds[0].GetComponent<SpriteRenderer>().enabled = true;
                BackGrounds[1].GetComponent<SpriteRenderer>().enabled = false;
            }
            if (GameObject.Find("PassBG").GetComponent<BgHolder>().BackGroundIndex == 1)
            {
                BackGrounds[0].GetComponent<SpriteRenderer>().enabled = false;
                BackGrounds[1].GetComponent<SpriteRenderer>().enabled = true;
            }
        }
	}
}
