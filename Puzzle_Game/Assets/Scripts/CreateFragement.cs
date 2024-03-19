using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFragement : MonoBehaviour
{
    public GameObject Fragement;
    private float _time;

    private void FixedUpdate()
    {
        _time += Time.deltaTime;

        if (_time > 2)
        {
            Instantiate(Fragement);
            _time = 0;
        }
    }
}
