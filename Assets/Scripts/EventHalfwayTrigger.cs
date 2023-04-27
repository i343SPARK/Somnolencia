using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHalfwayTrigger : MonoBehaviour
{
    public GameObject houseDisapear;
    public Animator anim;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            anim.Play("DoorAnimation");
            houseDisapear.SetActive(false);
            // RenderSettings.fog = true;
        }
    }
}
