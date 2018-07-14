using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject ferrari;
    public GameObject Bently;
    public GameObject Squada;
    public GameObject AudiR8;
    public int carimport;
	void Start () {
        carimport = GlobalCar.CarType;
        if (carimport == 1)
        {
            ferrari.SetActive(true);
        }
        else if(carimport==2)
        {
            Bently.SetActive(true);
        }
        else if (carimport == 3)
        {
            Squada.SetActive(true);
        }
        else if (carimport == 4)
        {
            AudiR8.SetActive(true);
        }
        else
        {
            Bently.SetActive(true);
        }
	}
	
	
}
