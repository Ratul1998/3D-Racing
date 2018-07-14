using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
    public GameObject MainCamera;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
	
	
	void Update () {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode++;
            }
            StartCoroutine(ModeChange());
        }
	}
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            MainCamera.SetActive(true);
            FPCam.SetActive(false);

        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            MainCamera.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
