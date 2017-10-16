using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    private Rigidbody2D rb;
    private GameObject cool;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update() {

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 ho = new Vector2(0.0f, 20.0f);
            rb.AddForce(ho * 10);
        }

        float yes = Input.GetAxis("Horizontal");
        Vector2 wow = new Vector2(yes, 0.0f);
        rb.AddForce(wow * 10);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Spike"))
        {
            Destroy(this.gameObject);
            Die();
        }
        if (col.CompareTag("point"))
        {
            count++;
            setCountText();
        }
    }
    void setCountText(){
        countText.text = "Count:" + count.ToString;
    }
    public void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
