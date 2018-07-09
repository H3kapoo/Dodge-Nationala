using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationHolder : MonoBehaviour {


    public float TargetDistanceX,TargetDistanceY;
    public void MoveMenu()
    {
        GameObject.Find("Main Camera").GetComponent<MenuBehave>().TargetDistanceX = TargetDistanceX;
        GameObject.Find("Main Camera").GetComponent<MenuBehave>().TargetDistanceY = TargetDistanceY;
        GameObject.Find("Main Camera").GetComponent<MenuBehave>().Moving = true;
    }
}
