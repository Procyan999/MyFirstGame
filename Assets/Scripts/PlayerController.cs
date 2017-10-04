using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float jump = 10.0f;
    Rigidbody2D rb;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * (jump * rb.mass * rb.gravityScale * 20.0f));
        }
    }
}
