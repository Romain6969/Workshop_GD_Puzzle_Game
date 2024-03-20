using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFragement : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;

    private void FixedUpdate()
    {
        NombreAleatoire = Random.Range(0f, 3f);
        if (NombreAleatoire >= 0 && NombreAleatoire < 1)
        {

            if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
            {
                Instantiate(Fragement[0]);
            }
        }
        if (NombreAleatoire >= 1 && NombreAleatoire < 2)
        {
            if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
            {
                Instantiate(Fragement[1]);
            }
        }
        if (NombreAleatoire >= 2 && NombreAleatoire < 3)
        {
            if (GameObject.Find("Stabilite") == null && GameObject.Find("Stabilite(Clone)") == null && GameObject.Find("AmeClair") == null && GameObject.Find("AmeClair(Clone)") == null && GameObject.Find("AmeSombre") == null && GameObject.Find("AmeSombre(Clone)") == null)
            {
                Instantiate(Fragement[2]);
            }
        }


    }
}
