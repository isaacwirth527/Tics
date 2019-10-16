using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class dialogueScript : MonoBehaviour
{
    public string basicSpeech;
    public string mildlyEmbarassed;
    public string veryEmbarassed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getText()
    {
        if (anxiety.embInt < 3)
        {
            return basicSpeech;
        }
        if (anxiety.embInt >= 3 && anxiety.embInt < 6)
        {
            return mildlyEmbarassed;
        }
        if (anxiety.embInt >= 6)
        {
            return veryEmbarassed;
        }
        else
        {
            return veryEmbarassed;
        }
    }
}
