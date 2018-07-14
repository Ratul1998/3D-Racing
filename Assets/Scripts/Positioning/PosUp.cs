using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour {

    public GameObject positionDisplay;

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CarPosition")
        {

            positionDisplay.GetComponent<Text>().text = "1st Place";
        }
    }
}
