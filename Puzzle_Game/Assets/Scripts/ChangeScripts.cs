using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScripts : MonoBehaviour
{
    public string Scene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
