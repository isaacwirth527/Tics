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
    public GameObject fadeScreen;
    public FadeScript fade;

    Movement movementScript;
    int days;
    void Start()
    {
        for (int i = 1; i < 5; i++)
        {
            splashScreen[i].SetActive(false);
        }
        movementScript = player.GetComponent<Movement>();
        fade = fadeScreen.GetComponent<FadeScript>();
    }

    void Update()
    {
        days = movementScript.returnDayOfWeek();
        if (days == 5)
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
        fade.fadeInMethod();
        movementScript.gameObject.SetActive(false);
        
    }

    IEnumerator displayScreen()
    {
       
        yield return new WaitForSeconds(lengthOfScreen);
        fade.fadeOutMethod();
        splashScreen[days].SetActive(false);
        dayCamera.gameObject.SetActive(false);
        movementScript.gameObject.SetActive(true);
        Debug.Log("Screen Coroutine running");


    }
}
