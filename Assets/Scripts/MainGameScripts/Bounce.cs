using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    public AudioClip[] Audio;
           Rigidbody2D rb;
    public GameObject toDestroy;
    public float RedundantConstraint = 11;
    public float Force = 20;
    public float DimPercenteage = 0;
    public bool onTheWallL = false;
    public bool onTheWallR = false;
    public bool Destroied = false;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
    
    void Update()
    {
        if(toDestroy.transform.position.x > RedundantConstraint)
            toDestroy.transform.position = new Vector2(RedundantConstraint, toDestroy.transform.position.y);
        if(toDestroy.transform.position.x < -RedundantConstraint)
            toDestroy.transform.position = new Vector2(-RedundantConstraint, toDestroy.transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Col")
        {
            rb.AddForce(new Vector2(0,Diminuator(DimPercenteage)));
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "StopR")
        {
            onTheWallR = true;
        }
        
        if (coll.gameObject.tag == "StopL")
        {
            onTheWallL = true;
        }

        if (coll.gameObject.tag == "Sageata")
        {
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerDamage = true;
            Destroy(toDestroy);
        }

        if (coll.gameObject.tag == "Buff1")
        {
            GameObject.Find("BuffsMaster").GetComponent<ScoreCountr>().PickedBuff_1 = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerPoint = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "Buff2")
        {
            GameObject.Find("BuffsMaster").GetComponent<ScoreCountr>().PickedBuff_2 = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerPoint = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "Buff3")
        {
            GameObject.Find("BuffsMaster").GetComponent<ScoreCountr>().PickedBuff_3 = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerPoint = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "BuffW")
        {
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().PickedBuff_W = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerBuff = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "BuffS")
        {
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().PickedBuff_S = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerBuff = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "BuffLife")
        {
            GameObject.Find("BuffsMaster").GetComponent<LifeBuffs>().PickedLife = true;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerHealth = true;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "GNDTrap")
        {
            GameObject.Find("PlayerManager").GetComponent<PlayerManager>().Life--;
            GameObject.Find("SoundFX").GetComponent<SoundFXTriggerer>().TriggerDamage = true;
            Destroy(coll.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D coll1)
    {
        if (coll1.gameObject.tag == "StopR")
        {
            onTheWallR = false;
        }
        
        if (coll1.gameObject.tag == "StopL")
        {
            onTheWallL = false;
        }
    }

    private float Diminuator(float DimPercentage)
    {
        if (DimPercenteage != 0)
        {
            Force = Force - DimPercenteage / 100 * Force;
            return Force;
        }
        else {
            return Force;
        }     
    }  
}
