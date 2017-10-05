using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float yes = Input.GetAxis("Horizontal");
        Vector2 wow = new Vector2(yes, 0.0f);
        rb.AddForce(wow*10);
	}
}
