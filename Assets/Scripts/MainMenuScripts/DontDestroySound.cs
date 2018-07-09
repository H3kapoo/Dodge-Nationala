using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySound : MonoBehaviour {

    private void Awake()
    {
        string tag = gameObject.tag;
        GameObject[] obj = GameObject.FindGameObjectsWithTag(tag);
        if (obj.Length > 1)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
