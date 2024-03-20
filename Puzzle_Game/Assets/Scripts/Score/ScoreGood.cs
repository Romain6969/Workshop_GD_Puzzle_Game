using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGood : MonoBehaviour
{
    public TMP_Text TextGood;
    public int scoreGood;
    public int stabiliteGood = 1;
    public int ameClairGood = 2;
    public int ameSombreGood = 1;
    public int pureteGood = 3;
    public int corruptionGood = 0;
    public int instabiliteGood = 7;
    public int ameExplosifGood = 0;
    public int SpiraleGood = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Stabilite"))
        {
            scoreGood = scoreGood + stabiliteGood;
            Destroy(GameObject.Find("Stabilite"));
            Destroy(GameObject.Find("Stabilite(Clone)"));
        }
        if (collision.CompareTag("AmeClair"))
        {
            scoreGood = scoreGood + ameClairGood;
            Destroy(GameObject.Find("AmeClair"));
            Destroy(GameObject.Find("AmeClair(Clone)"));
        }
        if (collision.CompareTag("AmeSombre"))
        {
            scoreGood = scoreGood + ameSombreGood;
            Destroy(GameObject.Find("AmeSombre"));
            Destroy(GameObject.Find("AmeSombre(Clone)"));
        }
        if (collision.CompareTag("Purete"))
        {
            scoreGood = scoreGood + pureteGood;
            Destroy(GameObject.Find("Purete"));
            Destroy(GameObject.Find("Purete(Clone)"));
        }
        if (collision.CompareTag("Corruption"))
        {
            scoreGood = scoreGood + corruptionGood;
            Destroy(GameObject.Find("Corruption"));
            Destroy(GameObject.Find("Corruption(Clone)"));
        }
        if (collision.CompareTag("Instabilite"))
        {
            scoreGood = scoreGood + instabiliteGood;
            Destroy(GameObject.Find("Instabilite"));
            Destroy(GameObject.Find("Instabilite(Clone)"));
        }
        if (collision.CompareTag("Persuasion"))
        {
            stabiliteGood = pureteGood;
            Destroy(GameObject.Find("Persuasion"));
            Destroy(GameObject.Find("Persuasion(Clone)"));
        }
        if (collision.CompareTag("AmeExplosif"))
        {
            scoreGood = ameExplosifGood;
            Destroy(GameObject.Find("AmeExplosif"));
            Destroy(GameObject.Find("AmeExplosif(Clone)"));
        }
        if (collision.CompareTag("Spirale"))
        {
            scoreGood = scoreGood * SpiraleGood;
            Destroy(GameObject.Find("Spiral"));
            Destroy(GameObject.Find("Spiral(Clone)"));
        }









        TextGood.text = ($"{scoreGood}");
    }
}
