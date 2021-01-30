using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    //public Vector3 vektorr;
    public float speed = 3.0f;
    //  public float rSpeed = 100.0f;
    public Vector3 rotationSpeed = new Vector3(0, 400, 0);
    private float maxSpeed = 0.5f;
    private Rigidbody rb;
    private Vector2 inputDirection;

    private bool isSchmoovin = false;
    //float moveSpeed = 5.0f;
    
    void Start()
    {
        //vektorr = transform.forward;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputDirection = inputs.normalized;
    

    //float moveh = Input.GetAxis("Horizontal");
    //float movev = Input.GetAxis("Vertical");
    //Vector3 movement = new Vector3(moveh, 0.0f, movev);

    //if (Input.GetKey(KeyCode.W))
    //{
    //    //transform.Translate(transform.forward * Time.deltaTime);
    //    isSchmoovin = true;
    //    rb.AddForce(movement * speed);
    //}

    //if (Input.GetKey(KeyCode.S))
    //{
    //    //transform.Translate(-transform.forward * Time.deltaTime);
    //    isSchmoovin = true;
    //    rb.AddForce(movement * speed);
    //}

    //if (Input.GetKey(KeyCode.A))
    //{
    //    rSpeed = -100.0f;
    //}
    //else
    //{
    //    rSpeed = 100.0f;
    //}

    //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
    //{
    //    transform.Rotate(Vector3.up * rSpeed * Time.deltaTime);
    //}
}

    private void FixedUpdate()
    {

        Quaternion deltaRotation = Quaternion.Euler(inputDirection.x * rotationSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
        rb.MovePosition(rb.position + transform.forward * speed * inputDirection.y * Time.fixedDeltaTime);

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
