using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject theCar;
    public float carX;
    public float carY;
    public float carZ;


	void Update () {
        carX = theCar.transform.eulerAngles.x;
        carZ = theCar.transform.eulerAngles.z;
        carY = theCar.transform.eulerAngles.y;

        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}
