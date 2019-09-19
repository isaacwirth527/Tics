using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
           rb.velocity = transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            rb.velocity = -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rb.velocity = Vector3.zero;
        }
    }
}

