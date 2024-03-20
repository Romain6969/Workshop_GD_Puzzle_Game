using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreGravity : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public int Gravity = 5;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody2D.gravityScale = Gravity;
        }
    }
}
