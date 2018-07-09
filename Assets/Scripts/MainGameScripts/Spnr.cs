using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spnr : MonoBehaviour {

    public int rand;
    int IntervalOfSpawning;
    public bool IsFiring = false;
    public bool LeftFiring = false;
    public bool RightFiring = false;
    public bool DownFiring = false;
    float Last_IOS;
    float QuantityOfEnemies;
    float Speed;
    float i = 1,j = 1,k;

    void Start()
    {
        IntervalOfSpawning = GameObject.Find("Manager").GetComponent<Difficulty>().IntervalOfSpawning;
        QuantityOfEnemies = GameObject.Find("Manager").GetComponent<Difficulty>().QuantityOfEnemies;
        Last_IOS = IntervalOfSpawning;
    }

    void Update()
    {
        IntervalOfSpawning = GameObject.Find("Manager").GetComponent<Difficulty>().IntervalOfSpawning;
        QuantityOfEnemies = GameObject.Find("Manager").GetComponent<Difficulty>().QuantityOfEnemies;
        if (GameObject.Find("Manager").GetComponent<GameManager>().StillAlive && Time.timeScale == 1)
        {
            Spawn();
            FiringDirection();
        }
    }

    void Spawn()
    {     
        k = j * 0.01f;
        if ((int)k == IntervalOfSpawning * i)
        {
            IsFiring = true;

        }
        if (k > IntervalOfSpawning * i + QuantityOfEnemies)
        {
            IsFiring = false;
            i++;
            if (i > 1) { i = 1; j = 1; }
           
        }

        j++;

        if (Last_IOS != IntervalOfSpawning)
        {
            Last_IOS = IntervalOfSpawning;
            j = 0;
        }    
    }  
    void FiringDirection()
    {
        rand = Random.Range(0, 3);
        if (rand == 0)
        {
            LeftFiring = true;
            RightFiring = false;
            DownFiring = false;
        }
        if (rand == 1)
        {
            LeftFiring = false;
            RightFiring = true;
            DownFiring = false;
        }
        if (rand == 2)
        {
            DownFiring = true;
            LeftFiring = false;
            RightFiring = false;
        }
    }
}
