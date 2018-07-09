using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string Scene;
	
	public void SceneLoad()
    {
        if (SceneManager.GetActiveScene().name == "NewMenu")
        {
            //From ConfirmName
            if (GameObject.FindGameObjectWithTag("PlayerNameField").GetComponent<TextMeshProUGUI>().text.Length > 3)
            {
                DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath + "/");
                FileInfo[] info = dir.GetFiles("*.dge");
                if (info.Length == 5)
                {
                    //Full
                }
                else
                {
                    GameObject.Find("PassNameToSelector").GetComponent<PassName>().NameToPass = GameObject.FindGameObjectWithTag("PlayerNameField").GetComponent<TextMeshProUGUI>().text;
                    SceneManager.LoadScene(Scene);
                }
            }

        }
        if (SceneManager.GetActiveScene().name == "NewSelector")
        {
                SceneManager.LoadScene(Scene);
        }
        if (SceneManager.GetActiveScene().name == "MainGame" || SceneManager.GetActiveScene().name == "MainGame2")
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
