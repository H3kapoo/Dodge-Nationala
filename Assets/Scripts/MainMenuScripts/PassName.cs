using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassName : MonoBehaviour {

    public string NameToPass;

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("PassName");
        if (obj.Length > 1)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
