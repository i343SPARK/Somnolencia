using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingFunctionsScript : MonoBehaviour
{
    public GameObject lights;
    public GameObject sound;
    private bool toggleLights = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (toggleLights)
            {
                lights.SetActive(false);
                sound.SetActive(true);
                RenderSettings.fog = true;
                toggleLights = false;
            }
            else
            {
                lights.SetActive(true);
                sound.SetActive(false);
                RenderSettings.fog = false;
                toggleLights = true;
            }
        }
        
        
    }
}
