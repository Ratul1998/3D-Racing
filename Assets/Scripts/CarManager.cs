using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarManager : MonoBehaviour {

    public GameObject DreamCar;
    public GameObject mycar;
	void Start () {
        DreamCar.GetComponent<CarAIControl>().enabled=true;
        mycar.GetComponent<CarController>().enabled=true;
    }
	
	
	void Update () {
		
	}
}
