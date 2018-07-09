using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class UITriggeres : MonoBehaviour
{

    public void On_Click_Restart()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            SceneManager.LoadScene("MainGame");
        }
        else
        {
            SceneManager.LoadScene("MainGame2");
        }
        
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void On_Click_MainMenu()
    {
        SceneManager.LoadScene("NewMenu");

    }
    public void On_Click_Exit()
    {
        Application.Quit();
    }
    public void On_GoalReached()
    {
        SceneManager.LoadScene("NewSelector");
    }
    public void On_SwitchToLevelSelect()
    {
        SceneManager.LoadScene("NewSelector");
    }   
}
