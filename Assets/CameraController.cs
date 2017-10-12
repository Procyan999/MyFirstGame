using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private Vector2 velocity;
    public float smoothTimeY;
    public float smoothTimeX;
    public GameObject player;
    void Start () {
        //  offset = transform.position - player.transform.position;
        player = GameObject.FindGameObjectWithTag("a");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //  transform.position = player.transform.position + offset;
        float posx = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x,smoothTimeX);
        float posy = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);
        transform.position = new Vector3(posx, posy,transform.position.z);

    }
}
