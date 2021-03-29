﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //keep the player in bounds
    void Update()
    {
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate((Vector3.right * (horizontalInput * Time.deltaTime * speed)));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
