﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	// Use this for initialization
	
	// Update is called once per frame
    //We changed it from Update to FixedUpdate for physics based methods
	void FixedUpdate () {
        //add A Forward force
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0,-sidewaysForce * Time.deltaTime);
        }
    }
}
