using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrgKeeper : MonoBehaviour {

    public int CurrentLvl;
    public float QuantityOfEnemies;
    public float QOE_Rate;
    public int IntervalOfChange;
    public int IntervalOfSpawning;
    public float Speed;
    public int Goal;
    public int Lifes;
    public bool[] Completed;

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("DiffKeeper");
        if (obj.Length > 1)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
