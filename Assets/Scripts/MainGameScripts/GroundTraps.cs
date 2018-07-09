using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTraps : MonoBehaviour {

    public GameObject ParentOfEnemies;
    public GameObject Trap;
    public float MaxRangeFromCenter;
    public float Height=-6.19f;
    public float Interval;
    public float QTTY;
    public float TimeTillDestroy;
    public bool IsSpawning;
    float i, j, k;

	void Update () {
        InstantiateTrapGND();
        if (GameObject.Find("Manager").GetComponent<GameManager>().StillAlive && Time.timeScale==1)
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
            if (i > 3) { i = 1; j = 1; }

        }
    }
    void InstantiateTrapGND()
    {
        if (IsSpawning)
        {
            GameObject r = (GameObject)Instantiate(Trap, new Vector2(Random.Range(-MaxRangeFromCenter, MaxRangeFromCenter), Height), Quaternion.identity);
            Destroy(r, TimeTillDestroy);
            r.transform.SetParent(ParentOfEnemies.transform);
        }
    }
}
