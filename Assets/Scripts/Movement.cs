using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    //public Vector3 vektorr;
    public float speed = 5.0f;
    public float rSpeed = 100.0f;
    private Rigidbody rb;

    private bool isSchmoovin = false;
    //float moveSpeed = 5.0f;
    
    void Start()
    {
        //vektorr = transform.forward;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveh, 0.0f, movev);

        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(transform.forward * Time.deltaTime);
            isSchmoovin = true;
            rb.AddForce(movement * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(-transform.forward * Time.deltaTime);
            isSchmoovin = true;
            rb.AddForce(movement * speed);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rSpeed = -100.0f;
        }
        else
        {
            rSpeed = 100.0f;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rSpeed * Time.deltaTime);
        }
    }
}
