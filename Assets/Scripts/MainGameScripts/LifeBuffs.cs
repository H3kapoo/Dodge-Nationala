using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBuffs : MonoBehaviour
{
    public bool PickedLife = false;
    public int LifeAddAmount = 1;
    void Update()
    {
        CheckIfPickedLife();
    }
    void CheckIfPickedLife()
    {
        if (PickedLife)
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().Life += LifeAddAmount;
            PickedLife = false;
        }
    }
}
