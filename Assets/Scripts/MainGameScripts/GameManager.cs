using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Button[] DeathMenus;
    public Button[] WinMenus;
    public bool StillAlive;
    public bool Paused=false;
    public bool ShowDeathUI = false;
    public bool ShowWinUI = false;
   
    void Start()
    {
        Cursor.visible = false;
        StillAlive = true;
        ShowDeathInterface();
        ShowWinInterface();
       // SoundStop();
        QualitySettings.SetQualityLevel(6);
    }
     void Update()
    {
        OnEscKey();
        ShowDeathInterface();
        ShowWinInterface();
        CheckGoal();
        CheckDeath();
    }
    void ShowDeathInterface()
    {
        foreach (Button b in DeathMenus)
        {
            b.GetComponent<Image>().enabled = ShowDeathUI;
            b.GetComponent<Button>().interactable = ShowDeathUI;
            b.GetComponent<Button>().enabled = ShowDeathUI;
            b.GetComponentInChildren<TextMeshProUGUI>().enabled = ShowDeathUI;        
        }
    }
    void ShowWinInterface()
    {
        foreach (Button b in WinMenus)
        {
            b.GetComponent<Image>().enabled = ShowWinUI;
            b.GetComponent<Button>().interactable = ShowWinUI;
            b.GetComponent<Button>().enabled = ShowWinUI;
            b.GetComponentInChildren<TextMeshProUGUI>().enabled = ShowWinUI;
        }
    }
    void OnEscKey()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                ShowDeathUI = true;
                GameObject.Find("Manager").GetComponent<AudioSource>().mute = true;
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1;
                ShowDeathUI = false;
                GameObject.Find("Manager").GetComponent<AudioSource>().mute = false;
                Cursor.visible = false;
            }
        }
    }
    void CheckDeath()
    {
        if (GameObject.Find("PlayerManager").GetComponent<PlayerManager>().Life == 0)
        {
            StillAlive = false;
            if (GameObject.Find("Manager").GetComponent<LevelGoal>().Reached)
            {
                ShowDeathUI = false;
            }
            else
            {
                ShowDeathUI = true;
            }
            GameObject.Find("Manager").GetComponent<AudioSource>().mute = true;
            Cursor.visible = true;
        }
    }
    void CheckGoal()
    {
        if ((GameObject.Find("Manager").GetComponent<LevelGoal>().Reached))
        {
            StillAlive = false;
            ShowWinUI = true;           
        }
    }
    /*void SoundStop()
    {
        if (SceneManager.GetActiveScene().name == "MainGame")
        {
            GameObject.Find("SaveLoadData").GetComponent<AudioSource>().mute = true;
        }
        else
        {
            GameObject.Find("SaveLoadData").GetComponent<AudioSource>().mute = false;
        }
    }*/
}
