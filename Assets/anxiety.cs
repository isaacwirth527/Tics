using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anxiety : MonoBehaviour
{
    public int anxietyMax;
    public static int anxietyInt;
    public Slider slider;
    public GameObject player;
    public GameObject red;
    public int redTimer;
    // Start is called before the first frame update
    void Start()
    {
        red.SetActive(false);
        anxietyInt = 0;
        slider.value = anxietyInt;
        slider.maxValue = anxietyMax;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = anxietyInt;
        if (anxietyInt >= anxietyMax)
        {
            Tic();
            StartCoroutine(endGame());
        }
        

    }

    void Tic()
    {
        red.SetActive(true);
        player.GetComponent<Animation>().Play();


    }
    IEnumerator endGame()
    {
        yield return new WaitForSeconds(redTimer);
        SceneManager.LoadScene("GameOver");
    }
}

