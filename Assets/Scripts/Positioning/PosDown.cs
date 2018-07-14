using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour {
    public GameObject positionDisplay;

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "CarPosition")
        {

            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
    }

}
