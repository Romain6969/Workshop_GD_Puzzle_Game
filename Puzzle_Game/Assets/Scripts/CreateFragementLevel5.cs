using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CreateFragementLevel5 : MonoBehaviour
{
    public List<GameObject> Fragement;
    public static float NombreAleatoire;
    public int NombreTotalePaD = 5;
    public int NombreTotalePaA = 5;
    public int NombreTotaleRus = 1;
    public int NombreTotaleIns = 15;
    public TMP_Text NbPaD;
    public TMP_Text NbPaA;
    public TMP_Text NbIns;
    public TMP_Text NbRus;
    public string Scene;
    public ScoreGood goodScore;
    public ScoreEvil evilScore;
    public float NBTarsh1 = 1f;
    public float NBTarsh2 = 2f;
    public float NBTarsh3 = 3.5f;
    public int TotaleGoodPaD = 0;
    public int TotaleEvilPaA = 0;


    private void FixedUpdate()
    {
        NbPaD.text = $"{NombreTotalePaD}";
        NbPaA.text = $"{NombreTotalePaA}";
        NbRus.text = $"{NombreTotaleRus}";
        NbIns.text = $"{NombreTotaleIns}";

        NombreAleatoire = Random.Range(0f, 4f);

        Debug.Log(goodScore.PacteDVer);
        Debug.Log(evilScore.PacteAVer);
        Debug.Log(TotaleEvilPaA);
        Debug.Log(TotaleGoodPaD);

        bool PacteDver = goodScore.PacteDVer;
        bool PacteAver = evilScore.PacteAVer;

        if (NombreTotalePaD != 0)
        {
            if (NombreAleatoire >= 0 && NombreAleatoire < NBTarsh1)
            {
                if (GameObject.Find("PacteDiable") == null && GameObject.Find("PacteDiable(Clone)") == null && GameObject.Find("PacteAnge") == null && GameObject.Find("PacteAnge(Clone)") == null && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotalePaD -= 1;
                    Instantiate(Fragement[0]);
                    if (PacteDver == true)
                    {
                        goodScore.scoreGood = goodScore.scoreGood + TotaleGoodPaD;
                    }
                    if (PacteAver == true)
                    {
                        evilScore.scoreEvil += evilScore.scoreEvil + TotaleEvilPaA;
                    }
                }
            }
        }
        if (NombreTotalePaD == 0)
        {
            NBTarsh1 = 0;
        }
        if (NombreTotalePaA != 0)
        {
            if (NombreAleatoire >= NBTarsh1 && NombreAleatoire < NBTarsh2)
            {
                if (GameObject.Find("PacteDiable") == null && GameObject.Find("PacteDiable(Clone)") == null && GameObject.Find("PacteAnge") == null && GameObject.Find("PacteAnge(Clone)") == null && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotalePaA -= 1;
                    Instantiate(Fragement[1]);
                    if (PacteDver == true)
                    {
                        goodScore.scoreGood += goodScore.scoreGood + TotaleGoodPaD;
                    }
                    if (PacteAver == true)
                    {
                        evilScore.scoreEvil += evilScore.scoreEvil + TotaleEvilPaA;
                    }
                }
            }
        }
        if (NombreTotalePaA == 0)
        {
            NBTarsh1 = 1.5f;
            NBTarsh2 = 1.5f;
            NBTarsh3 = 3.25f;
        }
        if (NombreTotaleIns != 0)
        {
            if (NombreAleatoire >= NBTarsh2 && NombreAleatoire < NBTarsh3)
            {
                if (GameObject.Find("PacteDiable") == null && GameObject.Find("PacteDiable(Clone)") == null && GameObject.Find("PacteAnge") == null && GameObject.Find("PacteAnge(Clone)") == null && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleIns -= 1;
                    Instantiate(Fragement[2]);
                    if (PacteDver == true)
                    {
                        goodScore.scoreGood += goodScore.scoreGood + TotaleGoodPaD;
                    }
                    if (PacteAver == true)
                    {
                        evilScore.scoreEvil += evilScore.scoreEvil + TotaleEvilPaA;
                    }
                }
            }
        }
        if (NombreTotaleIns == 0)
        {
            NBTarsh1 = 1.5f;
            NBTarsh2 = 3.25f;
            NBTarsh3 = 3.25f;
        }
        if (NombreTotaleRus != 0)
        {
            if (NombreAleatoire >= NBTarsh3 && NombreAleatoire <= 4)
            {

                if (GameObject.Find("PacteDiable") == null && GameObject.Find("PacteDiable(Clone)") == null && GameObject.Find("PacteAnge") == null && GameObject.Find("PacteAnge(Clone)") == null && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
                {
                    NombreTotaleRus -= 1;
                    Instantiate(Fragement[3]);
                    if (PacteDver == true)
                    {
                        goodScore.scoreGood += goodScore.scoreGood + TotaleGoodPaD;
                    }
                    if (PacteAver == true)
                    {
                        evilScore.scoreEvil += evilScore.scoreEvil + TotaleEvilPaA;
                    }
                }
            }
        }
        if (NombreTotaleRus == 0)
        {
            NBTarsh3 = 4;
        }
        if (NombreTotalePaD == 0 && NombreTotalePaA == 0 && NombreTotaleRus == 0 && NombreTotaleIns == 0 && GameObject.Find("PacteDiable") == null && GameObject.Find("PacteDiable(Clone)") == null && GameObject.Find("PacteAnge") == null && GameObject.Find("PacteAnge(Clone)") == null && GameObject.Find("Ruse") == null && GameObject.Find("Ruse(Clone)") == null && GameObject.Find("Instabilite") == null && GameObject.Find("Instabilite(Clone)") == null)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
