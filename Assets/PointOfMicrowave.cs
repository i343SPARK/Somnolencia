using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfMicrowave : MonoBehaviour
{
    public GameObject lights, sound, sound2;
    
    private bool secureSound = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (secureSound && sound2.GetComponent<AudioSource>().pitch > -0.1f)
        {
            sound2.GetComponent<AudioSource>().pitch -= 0.1f * Time.deltaTime;
        }
        else
        {
            secureSound = false;
        }

        if (sound2.GetComponent<AudioSource>().pitch < -0.1f)
        {
            sound2.SetActive(false);
        }
    }
    
    public void ActivationOfMicrowaveEvent()
    {
        lights.SetActive(false);
        sound.SetActive(true);
        RenderSettings.fog = true;
        sound2.GetComponent<AudioSource>().pitch = 1;
        secureSound = true;
    }
}
