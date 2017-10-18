using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour {
    private Rigidbody2D rb;
    public int count;
    public Text countText;
    private GameMaster gm;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();

    }
    // Update is called once per frame
    void Update() {

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
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
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }
    public void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
