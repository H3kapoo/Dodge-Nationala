using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLvlSelect : MonoBehaviour {

    public string GameScene;
	public void LoadLevel()
    {
        int i = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().CurrentLvl;
        //split in doua pt 2 harti de la i_max/2
        if (GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Completed[i] == true)
        {
            SceneManager.LoadScene(GameScene);
            if (Time.timeScale == 0)
                Time.timeScale = 1;
        }
        else
        {

        }
    }
}
