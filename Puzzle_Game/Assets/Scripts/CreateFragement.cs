using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFragement : MonoBehaviour
{
    public GameObject Fragement;

    private void FixedUpdate()
    {
        if (GameObject.Find("Fragment") == null && GameObject.Find("Fragment(Clone)") == null)
        {
            Instantiate(Fragement);
        }
    }
}
