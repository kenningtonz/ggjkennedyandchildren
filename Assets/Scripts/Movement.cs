using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject Camera;
    private Camera cam;

    private Vector3 offsetPosition = new Vector3(0, 2, -3);
    private Quaternion offsetRotation = new Quaternion(0, 0,0, 0 );
    public float speed = 3.0f;
    public Vector3 rotationSpeed = new Vector3(0, 1, 0);
    private float maxSpeed = 0.6f;
    private Rigidbody rb;
    private Vector2 inputDirection;
    
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
    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }

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
