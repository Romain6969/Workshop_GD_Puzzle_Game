using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateFragementLevel2 : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotalePur = 20;
    public int NombreTotaleCor = 20;
    public int NombreTotaleIns = 20;
    public TMP_Text NbPur;
    public TMP_Text NbCor;
    public TMP_Text NbIns;
    public string Scene;
    public float NBTarsh1 = 1;
    public float NBTarsh2 = 2;

    private void FixedUpdate()
    {
        NbPur.text = $"{NombreTotalePur}";
        NbCor.text = $"{NombreTotaleCor}";
        NbIns.text = $"{NombreTotaleIns}";

        NombreAleatoire = Random.Range(0f, 3f);

        Debug.Log(NombreAleatoire);
        if (NombreTotalePur != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {

                if (GameObject.Find("Purete") == null && GameObject.Find("Purete(Clone)") == null && GameObject.Find("Corruption") == null && GameObject.Find("Corruption(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotalePur -= 1;
                    Instantiate(Fragement[0]);
                }
            }
        }
        if (NombreTotalePur == 0)
        {
            NBTarsh1 = 0;
        }
        if (NombreTotaleCor != 0)
        {
            if (NombreAleatoire > NBTarsh1 && NombreAleatoire < NBTarsh2)
            {
                if (GameObject.Find("Purete") == null && GameObject.Find("Purete(Clone)") == null && GameObject.Find("Corruption") == null && GameObject.Find("Corruption(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleCor -= 1;
                    Instantiate(Fragement[1]);
                }
            }
        }
        if (NombreTotaleCor == 0)
        {
            NBTarsh1 = 0.5f;
            NBTarsh2 = 0.5f;
        }
        if (NombreTotaleIns != 0)
        {
            if (NombreAleatoire >= NBTarsh2 && NombreAleatoire <= 3)
            {
                if (GameObject.Find("Purete") == null && GameObject.Find("Purete(Clone)") == null && GameObject.Find("Corruption") == null && GameObject.Find("Corruption(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleIns -= 1;
                    Instantiate(Fragement[2]);
                }
            }
        }
        if (NombreTotaleIns == 0)
        {
            NBTarsh2 = 3;
        }
        if (NombreTotalePur == 0 && NombreTotaleCor == 0 && NombreTotaleIns == 0 && GameObject.Find("Purete") == null && GameObject.Find("Purete(Clone)") == null && GameObject.Find("Corruption") == null && GameObject.Find("Corruption(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
