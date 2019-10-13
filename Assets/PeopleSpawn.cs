using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    public GameObject person;
    GameObject[] people;
    public int numOfPeople;
    Rigidbody[] pplRb;
    public float moveSpeed;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
        people = new GameObject[numOfPeople];
        pplRb = new Rigidbody[numOfPeople];
        for (int i = 0; i < numOfPeople; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-2.5f, 2.5f), 0.99f, Random.Range(-70, 23));
            Vector3 rotate = new Vector3(0, 180, 0);
            people[i] = Instantiate(person, randomPos, Quaternion.identity);
            people[i].transform.Rotate(rotate);
            pplRb[i] = people[i].GetComponent<Rigidbody>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (people.Length < numOfPeople -1)
        {
            startPos = new Vector3(Random.Range(-2.5f, 2.5f), 0.99f, -70);
            Instantiate(person, startPos, Quaternion.identity);
        }

   
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < numOfPeople; i++)
        {
            pplRb[i].velocity = Vector3.forward * moveSpeed + Physics.gravity * .69f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < numOfPeople; i++)
        {
            if (other.gameObject.tag == "barrier")
            {
                Destroy(people[i]);
            }
        }
    }
}
