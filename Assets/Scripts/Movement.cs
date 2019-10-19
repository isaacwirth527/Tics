using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 inputVector;
    public Rigidbody thisRigidbody;
    public Vector3 startPos;
    public static int dayOfWeek;
    public Days dayManager;

    void Start()
    {
        dayOfWeek = 0;
        startPos = new Vector3(0, 0.15f, 54.96f);
        thisRigidbody = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        dayManager.dayScreen();
    }

    public float mouseX;
    public float mouseY;

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
    }

    void FixedUpdate()
    {
        thisRigidbody.velocity = inputVector * moveSpeed + Physics.gravity * .69f;
    }

    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "people")
            {
                anxiety.anxietyInt++;
            }

         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "stopY")
        {
            Debug.Log("FrozeY");
        }
        if(other.gameObject.tag == "teacher")
        {
            StartCoroutine(waitAndMove());
            
        }
    }

    IEnumerator waitAndMove()
    {
        thisRigidbody.isKinematic = true;
        dayOfWeek++;
        yield return new WaitForSeconds(3f);
        dayManager.dayScreen();
        transform.position = startPos;
        thisRigidbody.isKinematic = false;
    }

   public int returnDayOfWeek()
    {
        return dayOfWeek;
    }

}


