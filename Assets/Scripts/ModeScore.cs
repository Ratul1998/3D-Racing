using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModeScore : MonoBehaviour {

    public int ModeSelect;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreBoxes;
    public GameObject ScoreValue;
    void Start () {
        ModeSelect = GameModes.RaceMode;
        if (ModeSelect == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            ScoreBoxes.SetActive(true);
            AICar.SetActive(false);

        }
	}
	void Update () {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
	}
}
