using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject background;
    public TextMesh text;
    Color c;
    private void Awake()
    {
        
    
    }
    void Start()
    {
        c = background.GetComponent<Color>();

    }

    // Update is called once per frame
    void Update()
    {
        c = Color.Lerp(Color.black, Color.clear, Time.deltaTime);
        text.color = Color.Lerp(Color.white, Color.clear, Time.deltaTime);
    }


}
