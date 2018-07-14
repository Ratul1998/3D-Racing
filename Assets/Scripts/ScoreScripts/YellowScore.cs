using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour {

	void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 200;
        gameObject.SetActive(false);
    }
}
