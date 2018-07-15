using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01 : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject[] Mark;
    public int MarkTracker = 0;
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            
            this.GetComponent<BoxCollider>().enabled = false;
            TheMarker.transform.position = Mark[MarkTracker+1].transform.position;
            MarkTracker ++;
            if (MarkTracker == (Mark.Length-1))
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
