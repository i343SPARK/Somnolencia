using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingFunctionsScript : MonoBehaviour
{
    public GameObject lights;
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
                RenderSettings.fog = true;
                toggleLights = false;
            }
            else
            {
                lights.SetActive(true);
                RenderSettings.fog = false;
                toggleLights = true;
            }
        }
        
        
    }
}
