using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingScript : MonoBehaviour
{
    public Animation swing;
    public GameObject partnerDoor;
    Animation otherDoorSwing;
    // Start is called before the first frame update
    void Start()
    {
        otherDoorSwing = partnerDoor.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject)
        {
            swing.Play();
            otherDoorSwing.Play();
        }
    }
}
