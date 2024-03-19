using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGood : MonoBehaviour
{
    public TMP_Text TextGood;
    private int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Fragment"))
        {
            score = score + 1;
            Destroy(GameObject.Find("Fragment"));
            Destroy(GameObject.Find("Fragment(Clone)"));
        }
        TextGood.text = ($"{score}");
    }
}
