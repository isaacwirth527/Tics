using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public TextMesh speechText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray playerRay = new Ray(transform.position, transform.forward);
        float maxRayDistance = 1f; // just a bit in front
        Debug.DrawRay(playerRay.origin, playerRay.direction * maxRayDistance, Color.red);
        RaycastHit raycastHit = new RaycastHit();
        if (Physics.Raycast(playerRay, maxRayDistance))
        {
            if(raycastHit.transform.tag == "dialoguePlayer")
            {
                raycastHit.collider.gameObject.GetComponent<dialogueScript>();
                string displayText = dialogueScript.speech;
                speechText.text = displayText;
            }
            
        }
    }
}

