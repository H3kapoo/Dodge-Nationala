using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuff : MonoBehaviour {

    public float Xrange;
    public float Yrange;
    public GameObject[] Buffs;
    public bool IsSpawning;
    public float Interval;
    public float QTTY;
    public float TimeTillDestroy;
    float i = 1, j = 1, k;
    int l;

    void Update() {
            InstantiateBuff();
        if (GameObject.Find("Manager").GetComponent<GameManager>().StillAlive &&Time.timeScale==1)
            Spawn();
    }
    void Spawn()
    {
        j++;
        k = j * 0.01f;
        if ((int)k == Interval * i)
        {
            IsSpawning = true;
        }
        if (k > Interval * i + QTTY)
        {
            IsSpawning = false;
            i++;
            if (i > 1) { i = 1; j = 1; }
        }
    }
    void InstantiateBuff()
    {
        if (IsSpawning)
        {
            l = Random.Range(0, Buffs.Length);
            float RandomX = UnityEngine.Random.Range(-Xrange, Xrange);
            float RandomY = UnityEngine.Random.Range(-Yrange, Yrange);
            GameObject a = (GameObject)Instantiate(Buffs[l], new Vector2(RandomX, RandomY), Quaternion.identity);
            Destroy(a, TimeTillDestroy);
        }
    }
}