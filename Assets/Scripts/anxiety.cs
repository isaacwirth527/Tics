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
    public Slider embSlider;
    public GameObject player;
    public GameObject red;
    public int redTimer;
    public static int embMeter;
    // Start is called before the first frame update
    void Start()
    {
        red.SetActive(false);
        anxietyInt = 0;
        slider.maxValue = anxietyMax;
        embMeter = 0;
        embSlider.maxValue = 7;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = anxietyInt;
        embSlider.value = embMeter;

        if (anxietyInt >= anxietyMax)
        {
            Tic();
            StartCoroutine(addEmb());
        }
        

    }

    void Tic()
    {
        red.SetActive(true);
        player.GetComponent<Animation>().Play();
        embMeter++;
        anxietyInt = 0;

    }
    IEnumerator addEmb()
    {
        yield return new WaitForSeconds(redTimer);
       
        player.GetComponent<Animation>().Stop();
        
    }
}

