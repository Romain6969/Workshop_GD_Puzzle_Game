using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InequalityInBetween : MonoBehaviour
{
    public int _difference;
    public int _goodScore;
    public int _evilScore;
    public string Scene;
    public ScoreEvil scoreEvil;
    public ScoreGood scoreGood;

    private void Start()
    {
    }
    private void FixedUpdate()
    {
        _evilScore = scoreEvil.scoreEvil;
        _goodScore = scoreGood.scoreGood;
        _difference = _goodScore - _evilScore;

        if (_difference >= 20)
        {
            SceneManager.LoadScene(Scene);
        }
        if (_difference <= -20)
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
