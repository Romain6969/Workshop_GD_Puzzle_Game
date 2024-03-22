using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateFragementLevel6 : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotaleRes = 1;
    public int NombreTotaleAmM = 2;
    public int NombreTotaleFle = 5;
    public int NombreTotaleSpi = 5;
    public int NombreTotaleStab = 15;
    public TMP_Text NbRes;
    public TMP_Text NbAmM;
    public TMP_Text NbFle;
    public TMP_Text NbStab;
    public TMP_Text NbSpi;
    public string Scene;
    public float NBTarsh1 = 0.5f;
    public float NBTarsh2 = 1.75f;
    public float NBTarsh3 = 3f;
    public float NBTarsh4 = 4.25f;

    private void FixedUpdate()
    {
        NbRes.text = $"{NombreTotaleRes}";
        NbAmM.text = $"{NombreTotaleAmM}";
        NbFle.text = $"{NombreTotaleFle}";
        NbStab.text = $"{NombreTotaleStab}";
        NbSpi.text = $"{NombreTotaleSpi}";

        NombreAleatoire = Random.Range(0f, 5f);

        if (NombreTotaleRes != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {

                if (GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleRes -= 1;
                    Instantiate(Fragement[0]);
                }
            }
        }
        if (NombreTotaleRes == 0)
        {
            NBTarsh1 = 0;
        }
        if (NombreTotaleAmM != 0)
        {
            if (NombreAleatoire > NBTarsh1 && NombreAleatoire < NBTarsh2)
            {
                if (GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleAmM -= 1;
                    Instantiate(Fragement[1]);
                }
            }
        }
        if (NombreTotaleAmM == 0)
        {
            NBTarsh1 = 0.5f;
            NBTarsh2 = 0.5f;
        }
        if (NombreTotaleFle != 0)
        {
            if (NombreAleatoire >= NBTarsh2 && NombreAleatoire <= NBTarsh3)
            {
                if (GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleFle -= 1;
                    Instantiate(Fragement[2]);
                }
            }
        }
        if (NombreTotaleFle == 0)
        {
            NBTarsh2 = 3;
        }
        if (NombreTotaleStab != 0)
        {
            if (NombreAleatoire > NBTarsh3 && NombreAleatoire < NBTarsh4)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null && GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null)
                {
                    NombreTotaleStab -= 1;
                    Instantiate(Fragement[3]);
                }
            }
        }
        if (NombreTotaleStab == 0)
        {
            NBTarsh1 = 0.75f;
            NBTarsh2 = 0.75f;
            NBTarsh3 = 2.25f;
        }
        if (NombreTotaleSpi != 0)
        {
            if (NombreAleatoire >= NBTarsh4 && NombreAleatoire <= 5)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null && GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null)
                {
                    NombreTotaleSpi -= 1;
                    Instantiate(Fragement[4]);
                }
            }
        }
        if (NombreTotaleSpi == 0)
        {
            NBTarsh3 = 5;
        }
        if (NombreTotaleRes == 0 && NombreTotaleAmM == 0 && NombreTotaleFle == 0 && NombreTotaleSpi == 0 && NombreTotaleStab == 0 && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null && GameObject.Find("Restauration") == null && GameObject.Find("Restauration(Clone)") == null && GameObject.Find("AmeMotivante") == null && GameObject.Find("AmeMotivante(Clone)") == null && GameObject.Find("Fletrissement") == null && GameObject.Find("Fletrissement(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
