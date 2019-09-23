using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassmateSpawn : MonoBehaviour
{
    public GameObject people;
    public int numOfPeople;
    GameObject[] peopleArray;

    void Start()
    {
        peopleArray = new GameObject[numOfPeople];
        for(int i = 0; i < numOfPeople; i++)
        {
            Vector3 randomSpot = new Vector3(Random.Range(-5, 5), 2, -Random.Range(-20, 20));
            peopleArray[i] = Instantiate(people);
            peopleArray[i].transform.position = randomSpot;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
