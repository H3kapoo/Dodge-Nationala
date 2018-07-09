using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class ContinueButton : MonoBehaviour {

	
	public void Continue () {
        if (GameObject.Find("PassNameToSelector").GetComponent<PassName>().NameToPass != "")
        {
            SceneManager.LoadScene("NewSelector");
        }
        else
        {
            Debug.Log("Nothing To Continue From");
        }
	}
    public void Update()
    {
        if (GameObject.Find("PassNameToSelector").GetComponent<PassName>().NameToPass == "") {
            gameObject.GetComponentInChildren<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponentInChildren<Button>().interactable = true;
        }
    }
}
