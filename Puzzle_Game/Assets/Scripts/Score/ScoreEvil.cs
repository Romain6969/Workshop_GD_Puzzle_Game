using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreEvil : MonoBehaviour
{
    public TMP_Text TextEvil;
    public int scoreEvil;
    private int stabiliteEvil = 1;
    private int ameClairEvil = 1;
    private int ameSombreEvil = 2;
    private int pureteEvil = 0;
    private int corruptionEvil = 3;
    private int instabiliteEvil = 7;

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












        TextEvil.text = ($"{scoreEvil}");
    }
}
