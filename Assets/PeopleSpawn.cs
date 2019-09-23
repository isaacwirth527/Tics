using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    GameObject person;
    GameObject[] people;
    public int numOfPeople;
    // Start is called before the first frame update
    void Start()
    {
        people = new GameObject[numOfPeople];
        for (int i = 0; i < numOfPeople; i++)
        {
            people[i] = Instantiate(person);
            people[i].transform.position = new Vector3(Random.Range(-1, -2), 0.99f, Random.Range(0, 20));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
