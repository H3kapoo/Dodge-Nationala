using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Rigidbody2D rb;
    public float AD = 30;
    public float W = 30;
    public float S = 30;
    public int Wleft;
    public int Sleft;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	void Update ()
    {
        MoveAD();
        MoveW();
        MoveS();
    }
    void MoveAD()
    {
        if (Input.GetKey(KeyCode.A) && !GetComponent<Bounce>().onTheWallL)
        {
            rb.AddForce(new Vector2(-AD, 0), ForceMode2D.Impulse);
            if (!Input.GetKey(KeyCode.W))
            {
                rb.constraints = RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }               
        }
        if (Input.GetKey(KeyCode.D) && !GetComponent<Bounce>().onTheWallR)
        {
            rb.AddForce(new Vector2(AD, 0), ForceMode2D.Impulse);
            if (!Input.GetKey(KeyCode.S))
            {
                rb.constraints = RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
        }
    }
    void MoveW()
    {
        if (Input.GetKeyDown(KeyCode.W) && GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().WBuff != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.AddForce(new Vector2(0, W), ForceMode2D.Impulse);
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().WBuff--;
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().Wleft.text = "Wbuff: " + GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().WBuff;
        }
    }
    void MoveS()
    {
        if (Input.GetKeyDown(KeyCode.S) && GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().SBuff != 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.AddForce(new Vector2(0, -S), ForceMode2D.Impulse);
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().SBuff--;
            GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().Sleft.text = "Sbuff: " + GameObject.Find("BuffsMaster").GetComponent<PlayerBuffs>().SBuff;
        }
    }
}
