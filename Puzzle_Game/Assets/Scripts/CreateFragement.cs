using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CreateFragement : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotaleStab = 20;
    public int NombreTotaleAmC = 20;
    public int NombreTotaleAmS = 20;
    public TMP_Text NbStab;
    public TMP_Text NbAmC;
    public TMP_Text NbAmS;
    public string Scene;
    public float NBTarsh1 = 1;
    public float NBTarsh2 = 2;

    private void FixedUpdate()
    {
        NbStab.text = $"{NombreTotaleStab}";
        NbAmC.text = $"{NombreTotaleAmC}";
        NbAmS.text = $"{NombreTotaleAmS}";

        NombreAleatoire = Random.Range(0f,3f);

        Debug.Log(NombreAleatoire);
        if(NombreTotaleStab != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {

                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
                {
                    NombreTotaleStab -= 1;
                    Instantiate(Fragement[0]);
                }
            }
        }
        if(NombreTotaleStab == 0)
        {
            NBTarsh1 = 0;
        }
        if(NombreTotaleAmC != 0)
        {
            if (NombreAleatoire > NBTarsh1 && NombreAleatoire < NBTarsh2)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
                {
                    NombreTotaleAmC -= 1;
                    Instantiate(Fragement[1]);
                }
            }
        }
        if (NombreTotaleAmC == 0)
        {
            NBTarsh1 = 0.5f;
            NBTarsh2 = 0.5f;
        }
        if (NombreTotaleAmS != 0)
        {
            if (NombreAleatoire >= NBTarsh2 && NombreAleatoire <= 3)
            {
                if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
                {
                    NombreTotaleAmS -= 1;
                    Instantiate(Fragement[2]);
                }
            }
        }
        if (NombreTotaleAmS == 0)
        {
            NBTarsh2 = 3;
        }
        if (NombreTotaleStab == 0 && NombreTotaleAmC == 0 && NombreTotaleAmS == 0 && GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
