using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownManager : MonoBehaviour
{
    public GameObject countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public AudioSource LevelMusic;
    void Start()
    {
        
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        LevelMusic.Play();
    }
}

