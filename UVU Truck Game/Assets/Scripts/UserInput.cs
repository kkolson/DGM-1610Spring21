using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 20f;
    public Rigidbody2D rigidBodyObj;

    private Vector2 direction;

    private void Update()
    {
        direction.x = speed * Input.GetAxis("Horizontal");

        if (Input.GetButton("Jump")) ;
        {
            direction.y = jumpForce;
        }

        rigidBodyObj.AddForce(direction, ForceMode2D.Impulse);
    }
}    

    

