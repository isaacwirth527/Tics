using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    public Animation playing;
    public AnimationClip[] fadeInAndOut;

 
     
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fadeInMethod()
    {
        playing.clip= fadeInAndOut[0];
        playing.Play();
    }

    public void fadeOutMethod()
    {
        playing.clip = fadeInAndOut[1];
        playing.Play();
    }
}
