using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering.VirtualTexturing;

public class ScoreEvil : MonoBehaviour
{
    public ScoreGood goodScore;
    public TMP_Text TextEvil;
    public SpriteRenderer spriterendStab;
    public SpriteRenderer spriterendIns;
    public Sprite newSprite;
    public Sprite OldSprite;
    public Sprite NewSpriteIns;
    public Sprite OldSpriteIns;
    public int scoreEvil;
    public int stabiliteEvil = 1;
    public int ameClairEvil = 1;
    public int ameSombreEvil = 2;
    public int pureteEvil = 1;
    public int corruptionEvil = 5;
    public int instabiliteEvil = 7;
    public int ameExplosifEvil = 15;
    public int SpiraleEvil = 15;
    public int RuseEvil = 7;
    public int PacteDiableEvil = 12;
    public int PacteAngeEvil = 5;
    public int RestaurationEvil = 0;
    public bool PacteAVer = false;
    public int AmeMotivanteEvil = 0;
    public bool AmeMotivVer = false;
    public int FretrissementEvil = 1;
    public bool FretissVer = false;

    private void Start()
    {
        spriterendStab.sprite = OldSprite;
        spriterendIns.sprite = OldSpriteIns;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FretissVer == true)
        {
            scoreEvil = scoreEvil - 1;
        }
        if (goodScore.FretissVer == true)
        {
            goodScore.scoreGood -= 1;
        }
        if (goodScore.scoreGood < 0)
        {
            goodScore.scoreGood = 0;
        }
        if (AmeMotivVer == true)
        {
            stabiliteEvil = stabiliteEvil + 2;
            ameSombreEvil = ameSombreEvil + 2;
            corruptionEvil = corruptionEvil + 2;
            instabiliteEvil = instabiliteEvil + 2;
            ameExplosifEvil = ameExplosifEvil + 2;
            RuseEvil = RuseEvil + 2;
            SpiraleEvil = SpiraleEvil + 2;
            PacteDiableEvil = PacteDiableEvil + 2;
        }
        if (collision.CompareTag("Stabilite"))
        {
            scoreEvil = scoreEvil + stabiliteEvil;
            Destroy(GameObject.Find("Stabilite"));
            Destroy(GameObject.Find("Stabilite(Clone)"));
        }
        if (collision.CompareTag("AmeClair"))
        {
            scoreEvil = scoreEvil - ameClairEvil;
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
            spriterendStab.sprite = newSprite;
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
        if (collision.CompareTag("Ruse"))
        {
            scoreEvil = scoreEvil + RuseEvil;
            instabiliteEvil = -7;
            goodScore.instabiliteGood = 7;
            spriterendIns.sprite = NewSpriteIns;
            Destroy(GameObject.Find("Ruse"));
            Destroy(GameObject.Find("Ruse(Clone)"));
        }
        if (collision.CompareTag("PacteDiable"))
        {
            scoreEvil = scoreEvil + PacteDiableEvil;
            Destroy(GameObject.Find("PacteDiable"));
            Destroy(GameObject.Find("PacteDiable(Clone)"));
        }
        if (collision.CompareTag("PacteAnge"))
        {
            scoreEvil = scoreEvil - PacteAngeEvil;
            PacteAVer = true;
            Destroy(GameObject.Find("PacteAnge"));
            Destroy(GameObject.Find("PacteAnge(Clone)"));
        }
        if (collision.CompareTag("Restauration"))
        {
            scoreEvil = scoreEvil + RestaurationEvil;
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
        if (scoreEvil < 0)
        {
            scoreEvil = 0;
        }
        TextEvil.text = ($"{scoreEvil}");
    }
}
