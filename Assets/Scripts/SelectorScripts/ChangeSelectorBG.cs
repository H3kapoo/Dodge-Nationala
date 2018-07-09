using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSelectorBG : MonoBehaviour {

    public Sprite BG;

	public void ChangeBackGround()
    {
        GameObject.Find("BG").GetComponent<SpriteRenderer>().sprite = BG;
    }
}
