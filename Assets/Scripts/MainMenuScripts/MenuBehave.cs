using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehave : MonoBehaviour {
    public string Tag;
    public float TargetDistanceX,TargetDistanceY;
    public bool Moving = false;
    void Update()
    {
        if (Moving)
        {
            Vector2 pos = new Vector2(TargetDistanceX, TargetDistanceY);
            Vector2 currentpos = GameObject.FindGameObjectWithTag(Tag).GetComponent<RectTransform>().localPosition;
            GameObject.FindGameObjectWithTag(Tag).GetComponent<RectTransform>().localPosition = Vector2.Lerp(currentpos, pos, 0.10f);
            if (currentpos == pos)
            {
                Moving = false;
                TargetDistanceX = 0;
                TargetDistanceY = 0;
            }
        }
    }
}
