using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public int Life;
    public bool UnSpawned;
    public GameObject prefOb;
    public GameObject a;

     void Start()
     {
        Life = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Lifes;
     }
     void Update()
     {
        SpawnPlayer();
        CheckIfPlayerNull();
        CheckIfDeadInScene();
     }
    void SpawnPlayer()
    {
        if (UnSpawned == true && Life > 0 && GameObject.Find("Manager").GetComponent<GameManager>().StillAlive)
        {
            float RandomX = UnityEngine.Random.Range(-10f, 10f);
            float RandomY = UnityEngine.Random.Range(-3f, 3f);
            a = (GameObject)Instantiate(prefOb, new Vector2(RandomX, RandomY), Quaternion.identity);
            a.transform.parent = this.transform;
            UnSpawned = false;
        }
    }
    void CheckIfPlayerNull()
    {
        if (a == null)
        {
            Life--;
            if (Life <= 0)
            {
                Life = 0;
            }
            UnSpawned = true;
        }
    }
    void CheckIfDeadInScene()
    {
        if (GameObject.Find("Manager").GetComponent<GameManager>().StillAlive == false)
            Destroy(a);
    }
} 
