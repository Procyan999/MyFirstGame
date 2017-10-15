using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    public int LevelToLoad;
    //public Text text;
 //  private void hi;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("a"))
        {
            Application.LoadLevel(LevelToLoad);
        } 
    }
   void  OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("a"))
        {
            if (Input.GetKeyDown("E"))
            {
                Application.LoadLevel(LevelToLoad);
            }
            }
    }
     void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("a"))
        {
          
        }
    }
}
