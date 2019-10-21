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
    public static int embInt;
    // Start is called before the first frame update
    void Start()
    {
        red.SetActive(false);
        anxietyInt = 0;
        slider.maxValue = anxietyMax;
        embInt = 0;
        embSlider.maxValue = 7;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = anxietyInt;
        embSlider.value = embInt;

        if (anxietyInt >= anxietyMax)
        {
            embInt++;
            Tic();
            StartCoroutine(addEmb());
        }
        

    }

    void Tic()
    {
        player.GetComponent<Animation>().Play();
        player.GetComponent<AudioSource>().Play();
        anxietyInt = 0;

    }
    IEnumerator addEmb()
    {
        yield return new WaitForSeconds(redTimer);
       
        player.GetComponent<Animation>().Stop();
        
    }
}

