using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreEvil : MonoBehaviour
{
    public TMP_Text TextEvil;
    public int scoreEvil;
    public int stabiliteEvil = 1;
    public int ameClairEvil = 1;
    public int ameSombreEvil = 2;
    public int pureteEvil = 0;
    public int corruptionEvil = 3;
    public int instabiliteEvil = 7;
    public int ameExplosifEvil = 15;
    public int SpiraleEvil = 15;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Stabilite"))
        {
            scoreEvil = scoreEvil + stabiliteEvil;
            Destroy(GameObject.Find("Stabilite"));
            Destroy(GameObject.Find("Stabilite(Clone)"));
        }
        if (collision.CompareTag("AmeClair"))
        {
            scoreEvil = scoreEvil + ameClairEvil;
            Destroy(GameObject.Find("AmeClair"));
            Destroy(GameObject.Find("AmeClair(Clone)"));
        }
        if (collision.CompareTag("AmeSombre"))
        {
            scoreEvil = scoreEvil + ameSombreEvil;
            Destroy(GameObject.Find("AmeSombre"));
            Destroy(GameObject.Find("AmeSombre(Clone)"));
        }
        if (collision.CompareTag("Purete"))
        {
            scoreEvil = scoreEvil + pureteEvil;
            Destroy(GameObject.Find("Purete"));
            Destroy(GameObject.Find("Purete(Clone)"));
        }
        if (collision.CompareTag("Corruption"))
        {
            scoreEvil = scoreEvil + corruptionEvil;
            Destroy(GameObject.Find("Corruption"));
            Destroy(GameObject.Find("Corruption(Clone)"));
        }
        if (collision.CompareTag("Instabilite"))
        {
            scoreEvil = scoreEvil + instabiliteEvil;
            Destroy(GameObject.Find("Instabilite"));
            Destroy(GameObject.Find("Instabilite(Clone)"));
        }
        if (collision.CompareTag("Persuasion"))
        {
            stabiliteEvil = corruptionEvil;
            Destroy(GameObject.Find("Persuasion"));
            Destroy(GameObject.Find("Persuasion(Clone)"));
        }
        if (collision.CompareTag("AmeExplosif"))
        {
            scoreEvil = scoreEvil + ameExplosifEvil;
            Destroy(GameObject.Find("AmeExplosive"));
            Destroy(GameObject.Find("AmeExplosive(Clone)"));
        }
        if (collision.CompareTag("Spirale"))
        {
            scoreEvil = scoreEvil + SpiraleEvil;
            Destroy(GameObject.Find("Spirale"));
            Destroy(GameObject.Find("Spirale(Clone)"));
        }












        TextEvil.text = ($"{scoreEvil}");
    }
}
