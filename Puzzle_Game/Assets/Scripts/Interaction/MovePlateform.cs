using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateform : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _rotation = 45;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.rotation = _rotation * -1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.rotation = _rotation;
        }
    }
}
