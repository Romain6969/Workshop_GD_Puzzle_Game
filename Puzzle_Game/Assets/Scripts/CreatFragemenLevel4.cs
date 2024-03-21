using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CreatFragemenLevel4 : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotaleRus = 20;
    public int NombreTotaleIns = 20;
    public TMP_Text NbRus;
    public TMP_Text NbIns;
    public string Scene;
    public float NBTarsh1 = 1;
    

    private void FixedUpdate()
    {
        NbRus.text = $"{NombreTotaleRus}";
        NbIns.text = $"{NombreTotaleIns}";

        NombreAleatoire = Random.Range(0f, 2f);

        if (NombreTotaleRus != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {

                if (GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleRus -= 1;
                    Instantiate(Fragement[0]);
                }
            }
        }
        if (NombreTotaleRus == 0)
        {
            NBTarsh1 = 0;
        }
        if (NombreTotaleIns != 0)
        {
            if (NombreAleatoire > NBTarsh1 && NombreAleatoire <= 2)
            {
                if (GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleIns -= 1;
                    Instantiate(Fragement[1]);
                }
            }
        }
        if (NombreTotaleIns == 0)
        {
            NBTarsh1 = 2;
        }
        if (NombreTotaleRus == 0 && NombreTotaleIns == 0 && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
