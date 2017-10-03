using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    // Use this for initialization
     void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        Vector2 movement = new Vector2(moveHorizontal, 2.0f);
        rb.AddForce(movement * 5);
    }

    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
