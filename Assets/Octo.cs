﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octo : MonoBehaviour {

    Rigidbody rigidBody;
        
    // Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        //Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            print("space");
            rigidBody.AddRelativeForce(Vector3.up*7);
        }

        //Rotation
        if (Input.GetKey(KeyCode.A))
        {
            print("rotating left");
        } else if (Input.GetKey(KeyCode.D))
        {
            print("rotating right");
        }
    }
}
