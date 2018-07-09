using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySet : MonoBehaviour {

    public float QuantityOfEnemies;
    public float QOE_Rate;
    public int IntervalOfChange;
    public int IntervalOfSpawning;
    public float Speed;
    public int Goal;
    public int Lifes;

    public void SetDif()
    {
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().QuantityOfEnemies = QuantityOfEnemies;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().IntervalOfChange = IntervalOfChange;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().IntervalOfSpawning = IntervalOfSpawning;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().QOE_Rate = QOE_Rate;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Speed = Speed;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Goal = Goal;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().Lifes = Lifes;
        GameObject.Find("ProgressKeeper").GetComponent<PrgKeeper>().CurrentLvl = gameObject.GetComponent<lvlIndxr>().Index;
    }
}
