using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ScoreGood : MonoBehaviour
{
    public ScoreEvil evilScore;
    public TMP_Text TextGood;
    public SpriteRenderer spriterendStab;
    public SpriteRenderer spriterendIns;
    public Sprite newSprite;
    public Sprite OldSprite;
    public Sprite NewSpriteIns;
    public Sprite OldSpriteIns;
    public int scoreGood;
    public int stabiliteGood = 1;
    public int ameClairGood = 2;
    public int ameSombreGood = 1;
    public int pureteGood = 5;
    public int corruptionGood = 1;
    public int instabiliteGood = 7;
    public int ameExplosifGood = 0;
    public int SpiraleGood = 2;
    public int RuseGood = 7;
    public int PacteDiableGood = 5;
    public bool PacteDVer = false;
    public int PacteAngeGood = 12;
    public bool RestoVer = false;
    public int AmeMotivanteGood = 2;
    public bool AmeMotivVer = false;
    public int FretrissementGood = 1;
    public bool FretissVer = false;
    public string Scene;

    private void Start()
    {
        spriterendStab.sprite = OldSprite;
        spriterendIns.sprite = OldSpriteIns;

    }

    private void FixedUpdate()
    {
        TextGood.text = ($"{scoreGood}");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PacteDVer == true)
        {
            scoreGood = scoreGood + 1;
        }
        if (evilScore.PacteAVer == true)
        {
            evilScore.scoreEvil += 1;
        }
        if (FretissVer == true)
        {
            scoreGood = scoreGood - 1;
        }
        if (evilScore.FretissVer == true)
        {
            evilScore.scoreEvil -= 1;
        }
        if (evilScore.scoreEvil < 0)
        {
            evilScore.scoreEvil = 0;
        }
        if (AmeMotivVer == true)
        {
            stabiliteGood = stabiliteGood + 2;
            ameClairGood = ameClairGood + 2;
            pureteGood = pureteGood + 2;
            instabiliteGood = instabiliteGood + 2;
            RuseGood = RuseGood + 2;
            PacteAngeGood = PacteAngeGood + 2;
        }
        if (collision.CompareTag("Stabilite"))
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
            scoreGood = scoreGood - ameSombreGood;
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
            spriterendStab.sprite = newSprite;
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
        if (collision.CompareTag("Ruse"))
        {
            scoreGood = scoreGood + RuseGood;
            instabiliteGood = -7;
            evilScore.instabiliteEvil = 7;
            spriterendIns.sprite = NewSpriteIns;
            Destroy(GameObject.Find("Ruse"));
            Destroy(GameObject.Find("Ruse(Clone)"));
        }
        if (collision.CompareTag("PacteDiable"))
        {
            scoreGood = scoreGood - PacteDiableGood;
            PacteDVer = true;
            Destroy(GameObject.Find("PacteDiable"));
            Destroy(GameObject.Find("PacteDiable(Clone)"));
        }
        if (collision.CompareTag("PacteAnge"))
        {
            scoreGood = scoreGood + PacteAngeGood;
            Destroy(GameObject.Find("PacteAnge"));
            Destroy(GameObject.Find("PacteAnge(Clone)"));
        }
        if (collision.CompareTag("Restauration"))
        {
            scoreGood = 0;
            evilScore.scoreEvil = 0;
            RestoVer = true;
            Destroy(GameObject.Find("Restauration"));
            Destroy(GameObject.Find("Restauration(Clone)"));
        }
        if (collision.CompareTag("AmeMotivante"))
        {
            AmeMotivVer = true;
            Destroy(GameObject.Find("AmeMotivante"));
            Destroy(GameObject.Find("AmeMotivante(Clone)"));
        }
        if (collision.CompareTag("Fretrissement"))
        {
            FretissVer = true;
            Destroy(GameObject.Find("Fletrissement"));
            Destroy(GameObject.Find("Fletrissement(Clone)"));
        }

        if (AmeMotivVer == true)
        {
            scoreGood = scoreGood + AmeMotivanteGood;
        }
        if (scoreGood < 0)
        {
            scoreGood = 0;
        }
        if (RestoVer == true)
        {
            if (scoreGood > 20)
            {
                SceneManager.LoadScene(Scene);
            }
            if (evilScore.scoreEvil > 20)
            {
                SceneManager.LoadScene(Scene);
            }
        }
        
        
    }
}
