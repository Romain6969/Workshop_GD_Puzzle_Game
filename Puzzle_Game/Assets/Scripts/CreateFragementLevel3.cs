using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateFragementLevel3 : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotaleStab = 20;
    public int NombreTotalePer = 1;
    public int NombreTotaleAmE = 5;
    public int NombreTotaleSpi = 5;
    public TMP_Text NbStab;
    public TMP_Text NbPer;
    public TMP_Text NbAmE;
    public TMP_Text NbSpi;
    public string Scene;
    public float NBTarsh1 = 0.25f;
    public float NBTarsh2 = 1.50f;
    public float NBTarsh3 = 2.75f;

    private void FixedUpdate()
    {
        NbStab.text = $"{NombreTotaleStab}";
        NbPer.text = $"{NombreTotalePer}";
        NbAmE.text = $"{NombreTotaleAmE}";
        NbSpi.text = $"{NombreTotaleSpi}";

        NombreAleatoire = Random.Range(0f, 4f);

        Debug.Log(NombreAleatoire);
        if (NombreTotalePer != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {

                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Persuasion") == null && GameObject.Find("Persuasion(Clone)") == null && GameObject.Find("AmeExplosive") == null && GameObject.Find("AmeExplosive(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotalePer -= 1;
                    Instantiate(Fragement[0]);
                }
            }
        }
        if (NombreTotalePer == 0)
        {
            NBTarsh1 = 0;
        }
        if (NombreTotaleStab != 0)
        {
            if (NombreAleatoire > NBTarsh1 && NombreAleatoire < NBTarsh2)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Persuasion") == null && GameObject.Find("Persuasion(Clone)") == null && GameObject.Find("AmeExplosive") == null && GameObject.Find("AmeExplosive(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleStab -= 1;
                    Instantiate(Fragement[1]);
                }
            }
        }
        if (NombreTotaleStab == 0)
        {
            NBTarsh1 = 0.75f;
            NBTarsh2 = 0.75f;
            NBTarsh3 = 2.25f;
        }
        if (NombreTotaleAmE != 0)
        {
            if (NombreAleatoire >= NBTarsh2 && NombreAleatoire < NBTarsh3)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Persuasion") == null && GameObject.Find("Persuasion(Clone)") == null && GameObject.Find("AmeExplosive") == null && GameObject.Find("AmeExplosive(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleAmE -= 1;
                    Instantiate(Fragement[2]);
                }
            }
        }
        if (NombreTotaleAmE == 0)
        {
            NBTarsh1 = 0.75f;
            NBTarsh2 = 2.25f;
            NBTarsh3 = 2.25f;
        }
        if (NombreTotaleSpi != 0)
        {
            if (NombreAleatoire >= NBTarsh3 && NombreAleatoire <= 4)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Persuasion") == null && GameObject.Find("Persuasion(Clone)") == null && GameObject.Find("AmeExplosive") == null && GameObject.Find("AmeExplosive(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
                {
                    NombreTotaleSpi -= 1;
                    Instantiate(Fragement[3]);
                }
            }
        }
        if (NombreTotaleSpi == 0)
        {
            NBTarsh3 = 4;
        }
        if (NombreTotaleStab == 0 && NombreTotalePer == 0 && NombreTotaleAmE == 0 && NombreTotaleSpi == 0 && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("Persuasion") == null && GameObject.Find("Persuasion(Clone)") == null && GameObject.Find("AmeExplosive") == null && GameObject.Find("AmeExplosive(Clone)") == null && GameObject.Find("Spirale") == null && GameObject.Find("Spirale(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
