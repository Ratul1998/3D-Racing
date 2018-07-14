using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour {
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public static float RawTime;

	void Update () {
        MilliCount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = ": " + MilliDisplay;

        if (MilliCount >= 10)
        {
            SecondCount += 1;
            SecondBox.GetComponent<Text>().text = ": " + SecondCount.ToString();
            MilliCount = 0;
        }
        if(SecondCount>=60)
        {
            MinuteCount += 1;
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount.ToString();
            SecondCount = 0;
        }
	}
}
