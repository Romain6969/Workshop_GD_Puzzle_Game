using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGood : MonoBehaviour
{
    public TMP_Text TextGood;
    public int scoreGood;
    private int stabiliteGood = 1;
    private int ameClairGood = 2;
    private int ameSombreGood = 1;
    private int pureteGood = 3;
    private int corruptionGood = 0;
    private int instabiliteGood = 7;

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










        TextGood.text = ($"{scoreGood}");
    }
}
