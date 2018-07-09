using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Difficulty : MonoBehaviour {

    public int IntervalOfSpawning;
    public int IntervalOfChange;
    int Last_IOC;
    public float QuantityOfEnemies;
    public float QOE_Rate;
    public float Speed;
    float i=1,j=1,k;

	void Start () {

        Last_IOC = IntervalOfChange;
        GetFromKeeper();
    }

	void Update () {

        if (GameObject.Find("Manager").GetComponent<GameManager>().StillAlive)
            DiffChange();
    }

    void DiffChange()
    {
        k = j * 0.01f;
        if ((int)k == IntervalOfChange * i)
        {
            QuantityOfEnemies += QOE_Rate;
            i++;
            if (i > 1) { i = 1; j = 1;k = 0; }
        }

        j++;

        if (Last_IOC != IntervalOfChange)
        {
            Last_IOC = IntervalOfChange;
            j = 0;
        }
        
    }
    
    void GetFromKeeper()
    {
        IntervalOfSpawning = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().IntervalOfSpawning;
        IntervalOfChange = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().IntervalOfChange;
        QuantityOfEnemies = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().QuantityOfEnemies;
        QOE_Rate = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().QOE_Rate;
        Speed = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Speed;
    }
}
