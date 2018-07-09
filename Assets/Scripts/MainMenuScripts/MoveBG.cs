using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBG : MonoBehaviour {

    public GameObject BackGround;
    public float ManipulationX,ManipulationY;
    public float OffSetX, OffSetY;
	
	void Update () {
        BackGround.transform.position = new Vector2(-Input.mousePosition.x / ManipulationX + OffSetX, Input.mousePosition.y / ManipulationY + OffSetY);
	}
}
