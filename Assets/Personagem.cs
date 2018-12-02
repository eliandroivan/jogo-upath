using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveY = Input.GetAxis("Vertical") * speed;
        float moveX = Input.GetAxis("Horizontal") * speed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        moveY *= Time.deltaTime;
        //rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(moveX, moveY, 0);

        // Rotate around our y-axis
        //transform.Rotate(0, rotation, 0);
	}
}
