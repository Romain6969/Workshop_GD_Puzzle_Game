using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGood : MonoBehaviour
{
    public TMP_Text TextGood;
    public int scoreGood;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Stabilite"))
        {
            scoreGood = scoreGood + 1;
            Destroy(GameObject.Find("Stabilite"));
            Destroy(GameObject.Find("Stabilite(Clone)"));
        }
        if (collision.CompareTag("AmeClair"))
        {
            scoreGood = scoreGood + 2;
            Destroy(GameObject.Find("AmeClair"));
            Destroy(GameObject.Find("AmeClair(Clone)"));
        }
        if (collision.CompareTag("AmeSombre"))
        {
            scoreGood = scoreGood + 1;
            Destroy(GameObject.Find("AmeSombre"));
            Destroy(GameObject.Find("AmeSombre(Clone)"));
        }
        if (collision.CompareTag("Purete"))
        {
            scoreGood = scoreGood + 3;
            Destroy(GameObject.Find("Purete"));
            Destroy(GameObject.Find("Purete(Clone)"));
        }
        if (collision.CompareTag("Corruption"))
        {
            scoreGood = scoreGood + 0;
            Destroy(GameObject.Find("Corruption"));
            Destroy(GameObject.Find("Corruption(Clone)"));
        }
        if (collision.CompareTag("Instabilite"))
        {
            scoreGood = scoreGood + 7;
            Destroy(GameObject.Find("Instabilite"));
            Destroy(GameObject.Find("Instabilite(Clone)"));
        }










        TextGood.text = ($"{scoreGood}");
    }
}
