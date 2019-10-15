using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "barrier")
        {
            startPos = new Vector3(Random.Range(-2.5f, 2.5f), 0.5f, -70);
            transform.position = startPos;

        }
    }
}
