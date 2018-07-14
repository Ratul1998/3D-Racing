using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {
    public GameObject FinishTrigger;
    public GameObject HalfTrigger;
	void Start () {
        
	}
	void OnTriggerEnter()
    {
        FinishTrigger.SetActive(true);
        HalfTrigger.SetActive(false);
    }
	
	void Update () {
		
	}
}
