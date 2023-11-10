using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float forceMultiplier = 3f;
    public float maximumVelocity = 3f;


     void Start()
    {
      
    }

    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");

        if(GetComponent<Rigidbody>().velocity.x <= maximumVelocity)
        {
        GetComponent<Rigidbody>().AddForce(new Vector3( horizontalInput * forceMultiplier,0,0));
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }
}
