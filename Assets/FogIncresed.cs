using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogIncresed : MonoBehaviour
{
    float desinty = 1;
    bool secure = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (RenderSettings.fogDensity < 0.46f && secure)
        {
            RenderSettings.fogDensity += desinty * Time.deltaTime;
            Debug.Log(RenderSettings.fogDensity);
        }

        if (RenderSettings.fogDensity >= 0.46f)
        {
            secure = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            secure = true;
        }
    }
}
