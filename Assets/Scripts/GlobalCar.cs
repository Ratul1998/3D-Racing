using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {

	public static int CarType; //1-Bently, 2-Ferrari, 3-Squada
    public GameObject RaceMode;
    public void Bently()
    {
        CarType = 1;
        RaceMode.SetActive(true);
    }
    public void Ferrari()
    {
        CarType = 2;
        RaceMode.SetActive(true);
    }
    public void squada()
    {
        CarType = 3;
        RaceMode.SetActive(true);
    }
    public void Audir8()
    {
        CarType = 4;
        RaceMode.SetActive(true);
    }

}
