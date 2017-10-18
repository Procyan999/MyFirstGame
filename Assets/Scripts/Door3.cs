using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("a"))
        {
            SceneManager.LoadScene("Scene4");
        }
    }
}
