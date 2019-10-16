using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Days : MonoBehaviour
{
    public GameObject player;
    public GameObject[] splashScreen;
    public int lengthOfScreen;

    Movement movementScript;
    int days;// Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            splashScreen[i].SetActive(false);
        }
        movementScript = player.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        days = movementScript.returnDayOfWeek();
    }

    public void dayScreen()
    {
        Debug.Log("Day Screen method running");
        StartCoroutine(displayScreen());
        splashScreen[days].SetActive(true);
    }

    IEnumerator displayScreen()
    {
        yield return new WaitForSeconds(lengthOfScreen);
        splashScreen[days].SetActive(false);
        Debug.Log("Screen Coroutine running");
        Movement.dayOfWeek++;
    }
}
