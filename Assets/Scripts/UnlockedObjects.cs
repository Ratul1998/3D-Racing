using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour {

    public int SquadaSelect;
    public int AudiSelect;
    public GameObject FakeAudi;
    public GameObject FakeSquada;
	void Start () {
        SquadaSelect = PlayerPrefs.GetInt("SquadaBought");
        AudiSelect = PlayerPrefs.GetInt("AudiBought");
        if (SquadaSelect == 100)
        {
            FakeSquada.SetActive(false);
        }
        if (AudiSelect == 1000)
        {
            FakeAudi.SetActive(false);
        }

    }
	
	
}
