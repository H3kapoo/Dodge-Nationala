using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildSpnr : MonoBehaviour {

	Rigidbody2D rb;
    public Vector2 Force;
    public Transform[] obstPos;
    public GameObject[] obstPref;
    public GameObject ParentOfEnemies;
    public bool DownGoing = false;
    public bool LeftGoing = false;
    public bool RightGoing = true;
    public float Speed;
    
    void Update () {
        InstantiateEnemies();
	}
    int ZCheck(bool LeftGoing,bool DownGoing)
    {
        if(LeftGoing == true)
        {
  
            return 90;
        }
        if(LeftGoing == false)
        {
            return -90;
        }
        if(DownGoing == true)
        {
            return 180;
        }
        else
        {
            return 0;
        }
    }
    int WCheck(bool DownGoing)
    {
        if(DownGoing == true)
        {
            return 0;
        }
        else
        {
            return 90;
        }
    }
    float Rnd()
    {
        float k = (float)Random.Range(5, 11) / 10;
        return k;
    }
    void InstantiateEnemies()
    {
        if (GameObject.Find("PH_General").GetComponent<Spnr>().IsFiring)
        {
            if (GameObject.Find("PH_General").GetComponent<Spnr>().LeftFiring && RightGoing)
            {
                int i = Random.Range(0, obstPos.Length);
                int j = Random.Range(0, obstPref.Length);
                GameObject a = (GameObject)Instantiate(obstPref[j], new Vector2(obstPos[i].position.x, obstPos[i].position.y), new Quaternion(0, 0, ZCheck(LeftGoing, DownGoing), WCheck(DownGoing)));
                a.transform.SetParent(ParentOfEnemies.transform);
                rb = a.GetComponent<Rigidbody2D>();
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                Speed = GameObject.Find("Manager").GetComponent<Difficulty>().Speed;
                rb.AddForce(Force * Speed * Rnd());
                Destroy(a, 17 / Rnd());

            }
            if (GameObject.Find("PH_General").GetComponent<Spnr>().RightFiring && LeftGoing)
            {
                int i = Random.Range(0, obstPos.Length);
                int j = Random.Range(0, obstPref.Length);
                GameObject a = (GameObject)Instantiate(obstPref[j], new Vector2(obstPos[i].position.x, obstPos[i].position.y), new Quaternion(0, 0, ZCheck(LeftGoing, DownGoing), WCheck(DownGoing)));
                a.transform.SetParent(ParentOfEnemies.transform);
                rb = a.GetComponent<Rigidbody2D>();
                Vector2 scale = a.transform.localScale;
                scale.x *= -1;
                a.transform.localScale = scale;
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                Speed = GameObject.Find("Manager").GetComponent<Difficulty>().Speed;
                rb.AddForce(Force * Speed * Rnd());
                Destroy(a, 17 / Rnd());

            }
            if (GameObject.Find("PH_General").GetComponent<Spnr>().DownFiring && DownGoing)
            {
                int i = Random.Range(0, obstPos.Length);
                int j = Random.Range(0, obstPref.Length);
                GameObject a = (GameObject)Instantiate(obstPref[j], new Vector2(obstPos[i].position.x, obstPos[i].position.y), new Quaternion(0, 0, ZCheck(LeftGoing, DownGoing), WCheck(DownGoing)));
                a.transform.SetParent(ParentOfEnemies.transform);
                rb = a.GetComponent<Rigidbody2D>();
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                Speed = GameObject.Find("Manager").GetComponent<Difficulty>().Speed;
                rb.AddForce(Force * Speed * Rnd());
                Destroy(a, 10 / Rnd());
            }
        }
    }
}
