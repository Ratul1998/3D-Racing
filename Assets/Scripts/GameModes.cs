using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModes : MonoBehaviour {

    public static int RaceMode;//0-Race, 1-Score, 2-Time
    public GameObject TrackWindow;
    public void ScoreMode()
    {
        RaceMode = 1;
        TrackWindow.SetActive(true);
        
    }

    public void TimeMode()
    {
        RaceMode = 2;
        TrackWindow.SetActive(true);
        
    }
    public void RacingMode()
    {
        RaceMode = 0;
        TrackWindow.SetActive(true);
        
    }


}
