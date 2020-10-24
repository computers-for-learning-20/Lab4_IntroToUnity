﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 180f;
    
    private float fbInput;
    private float lrInput;
    
    private Rigidbody _rb;
    
    void Start()
    {
        //You'll need to add a rigidbody to the marble first
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Put code is for movement using the Sprite's native variables here
        fbInput = Input.GetAxis("Vertical")*moveSpeed;
        lrInput = Input.GetAxis("Horizontal")*rotateSpeed;

        // Commenting out these 2 lines to use RigidBody controls instead
        this.transform.Translate(Vector3.forward * fbInput* Time.deltaTime);
        this.transform.Rotate(Vector3.up* lrInput* Time.deltaTime);
        
    }
    
    void FixedUpdate()
    {
        /* I don't think we should have both sets
         * of controls running at the same time.
         * They both work fine though.
         * Commenting these out for now.
         * 
        Vector3 rotation = Vector3.up * lrInput;

        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position +
            this.transform.forward * fbInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
        */
    }
    
}
