using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHalfwayTrigger : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            anim.Play("DoorAnimation");
            // RenderSettings.fog = true;
        }
    }
}
