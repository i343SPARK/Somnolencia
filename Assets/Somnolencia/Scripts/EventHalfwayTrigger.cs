using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHalfwayTrigger : MonoBehaviour
{
    public GameObject houseDisapear;
    public Animator anim;
    public AudioSource audioSource;
    
    bool secure = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (audioSource.volume < 0.51f && secure)
        {
            audioSource.volume += 0.1f * Time.deltaTime;
        }

        if (audioSource.volume > 0.49f)
        {
            secure = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            anim.Play("DoorAnimation");
            houseDisapear.SetActive(false);
            secure = true;
            audioSource.Play();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
