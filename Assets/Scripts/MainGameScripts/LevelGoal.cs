using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelGoal : MonoBehaviour {

    public TextMeshProUGUI GoalDisplay;
    public int levelGoal;
    public bool Reached = false;

    void Start()
    {
        levelGoal = GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Goal;
        GoalDisplay.text = "Goal: " + levelGoal;
    }
    void Update ()
    {
        GoalDisplay.text = "Goal: " + levelGoal;
        if (GameObject.Find("BuffsMaster").GetComponent<ScoreCountr>().Score >= levelGoal)
        {
            GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Completed[GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().CurrentLvl+1] = true;
            GameObject.Find("ProgressKeeper").GetComponent<SaveComplete>().SaveData(); 
            Reached = true;
            Time.timeScale = 1;
            GameObject.Find("Manager").GetComponent<AudioSource>().mute = true;
            Cursor.visible = true;
        }
        else
            Reached = false;
	}
}
