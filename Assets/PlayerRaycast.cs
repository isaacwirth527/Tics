using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public TextMesh speechText;
    string noText;
    // Start is called before the first frame update
    void Start()
    {
        noText = "";
    }

    // Update is called once per frame
    void Update()
    {
        Ray playerRay = new Ray(transform.position, transform.forward);
        float maxRayDistance = 1f; // just a bit in front
        Debug.DrawRay(playerRay.origin, playerRay.direction * maxRayDistance, Color.red);
        RaycastHit raycastHit = new RaycastHit();

        if (Physics.Raycast(playerRay, out raycastHit, maxRayDistance))
   
        {
                if (raycastHit.transform != null && raycastHit.transform.tag == "DialoguePeople")
                 {
                     dialogueScript person = raycastHit.collider.gameObject.GetComponent<dialogueScript>();
                     string displayText = person.getText();
                     speechText.text = displayText;
                 }
        }
        if (raycastHit.transform == null || raycastHit.transform.tag != "DialoguePeople" )
        {
            speechText.text = noText;
        }
    }
}

