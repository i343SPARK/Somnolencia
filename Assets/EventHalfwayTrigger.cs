using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHalfwayTrigger : MonoBehaviour
{
    public Animator anim;

    public float desinty = 0;
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
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            anim.Play("DoorAnimation");
            secure = true;
            // RenderSettings.fog = true;
        }
    }
}
