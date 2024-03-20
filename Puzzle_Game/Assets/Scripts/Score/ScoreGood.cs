using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class ScoreGood : MonoBehaviour
{
    public TMP_Text TextGood;
    public SpriteRenderer spriterend;
    public Sprite newSprite;
    public Sprite OldSprite;
    public int scoreGood;
    public int stabiliteGood = 1;
    public int ameClairGood = 2;
    public int ameSombreGood = 1;
    public int pureteGood = 3;
    public int corruptionGood = 0;
    public int instabiliteGood = 7;
    public int ameExplosifGood = 0;
    public int SpiraleGood = 2;

    private void Start()
    {
        spriterend.sprite = OldSprite;
    }
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
            spriterend.sprite = newSprite;
        }
        if (collision.CompareTag("AmeExplosif"))
        {
            scoreGood = ameExplosifGood;
            Destroy(GameObject.Find("AmeExplosive"));
            Destroy(GameObject.Find("AmeExplosive(Clone)"));
        }
        if (collision.CompareTag("Spirale"))
        {
            scoreGood = scoreGood * SpiraleGood;
            Destroy(GameObject.Find("Spirale"));
            Destroy(GameObject.Find("Spirale(Clone)"));
        }









        TextGood.text = ($"{scoreGood}");
    }
}
