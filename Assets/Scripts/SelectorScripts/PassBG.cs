using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBG : MonoBehaviour {

    public int BackGroundIndex;
	public void PassBackGround()
    {
        GameObject.Find("PassBG").GetComponent<BgHolder>().BackGroundIndex = BackGroundIndex;
    }
}
