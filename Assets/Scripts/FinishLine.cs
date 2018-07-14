using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {
    public GameObject FinishTrigger;
    public GameObject HalfTrigger;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public GameObject LapCount;
    public static int lapdone;

    public float RawTime;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            lapdone++;
            FinishTrigger.SetActive(false);
            HalfTrigger.SetActive(true);
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                Debug.Log("Best Lap");
                PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
                PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

            }
            LapTimeManager.MilliCount = 0;
            LapTimeManager.SecondCount = 0;
            LapTimeManager.MinuteCount = 0;
            LapTimeManager.RawTime = 0;
            LapCount.GetComponent<Text>().text = "Laps : " + lapdone;

            MilliBox.GetComponent<Text>().text = ":00";
            MinuteBox.GetComponent<Text>().text = "00";
            SecondBox.GetComponent<Text>().text = ":00";

        }
    }
  
}
