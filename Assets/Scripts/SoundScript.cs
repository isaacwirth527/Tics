using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    // DECLARE THE AUDIO SOURCE
    public AudioSource thisAudioSource;

    // SET THE SOURCE VOLUME TO ZERO
    public float currentVolume = 0;

    // SET THE TARGET VOLUME TO ZERO - WE'LL BE UPDATING THIS
    public float targetVolume = 0;

    void OnTriggerEnter(Collider c)
    {
        // PLAY THE AUDIO SOURCE
        if (c.gameObject.tag == "player")
        {
            thisAudioSource.Play();
            targetVolume = 1;
        }
    }

    void OnTriggerExit(Collider c)
    {
        // STOP THE AUDIO SOURCE - ABRUPTLY
        // thisAudioSource.Stop();

        // SET THE TARGET VOLUME TO ZERO
        if (c.gameObject.tag == "player")
        {
            targetVolume = 0;
        }
    }


    void Update()
    {
        // ALWAYS SET THE AUDIO SOURCE VOLUME TO THIS VARIABLE
        thisAudioSource.volume = currentVolume;

        // SMOOTHLY INTERPOLATE BETWEEN THE CURRENT VOLUME AND THE TARGET VOLUME
        currentVolume = Mathf.Lerp(currentVolume, targetVolume, Time.deltaTime);

        // TO AVOID A 'HARD STOP' WHEN EXITING THE TRIGGER, ONLY STOP THE AUDIO SOURCE WHEN IT FALLS BELOW .01F
        if (currentVolume < .01f)
        {
            thisAudioSource.Stop();
        }
    }
}