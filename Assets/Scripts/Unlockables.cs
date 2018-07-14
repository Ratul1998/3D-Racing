using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour {

    public GameObject Squada;
    public GameObject Audi;
    public int CashValue;
	void Update () {
        CashValue = GlobalCash.TotalCash;
        if (CashValue >= 100)
        {
            Squada.GetComponent<Button>().interactable = true;
        }
        if (CashValue >= 1000)
        {
            Audi.GetComponent<Button>().interactable = true;
        }
    }

    public void SquadaUnlock()
    {
        Squada.SetActive(false);
        CashValue -= 100;
        GlobalCash.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("SquadaBought", 100);
    }
    public void AudiUnlock()
    {
        Audi.SetActive(false);
        CashValue -= 1000;
        GlobalCash.TotalCash -= 1000;
        PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        PlayerPrefs.SetInt("AudiBought", 1000);
    }
}
