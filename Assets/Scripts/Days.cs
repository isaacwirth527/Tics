using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Days : MonoBehaviour
{
    public GameObject player;
    public GameObject[] splashScreen;
    public int lengthOfScreen;
    public Camera dayCamera;

    Movement movementScript;
    int days;// Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            splashScreen[i].SetActive(false);
        }
        dayCamera.gameObject.SetActive(false);
        movementScript = player.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        days = movementScript.returnDayOfWeek();
        if (days == 6)
        {
            if(anxiety.anxietyInt < 3)
            {
                SceneManager.LoadScene("GoodEnding");
            }
            if(anxiety.anxietyInt >= 3 && anxiety.anxietyInt < 6)
            {
                SceneManager.LoadScene("MedEnding");
            }
            if(anxiety.anxietyInt >= 6)
            {
                SceneManager.LoadScene("BadEnding");
            }
        }
    }

    public void dayScreen()
    {
        Debug.Log("Day Screen method running");
        StartCoroutine(displayScreen());
        splashScreen[days].SetActive(true);
        dayCamera.gameObject.SetActive(true);
        movementScript.gameObject.SetActive(false);
    }

    IEnumerator displayScreen()
    {
        yield return new WaitForSeconds(lengthOfScreen);
        splashScreen[days].SetActive(false);
        dayCamera.gameObject.SetActive(false);
        movementScript.gameObject.SetActive(true);
        Debug.Log("Screen Coroutine running");
        Movement.dayOfWeek++;
    }
}
