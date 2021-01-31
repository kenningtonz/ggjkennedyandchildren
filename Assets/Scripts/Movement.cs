using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    public GameObject Camera;
    private Camera cam;

    private Vector3 offsetPosition = new Vector3(0, 2, -3);
    private Quaternion offsetRotation = new Quaternion(0, 0,0, 0 );
    public float speed = 3.0f;
    public Vector3 rotationSpeed = new Vector3(0, 400, 0);
    private float maxSpeed = 0.5f;
    private Rigidbody rb;
    private Vector2 inputDirection;

    private bool isSchmoovin = false;

    
    void Start()
    {
        cam = Camera.GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();

        cam.transform.parent = gameObject.transform;
        cam.transform.localPosition = offsetPosition;
        cam.transform.localRotation = offsetRotation;
    }

    void Update()
    {
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputDirection = inputs.normalized;
    

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
