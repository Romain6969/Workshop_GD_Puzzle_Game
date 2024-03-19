using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InequalityInBetween : MonoBehaviour
{
    private int _difference;
    private int _goodScore;
    private int _evilScore;
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
        Debug.Log(_difference);

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
