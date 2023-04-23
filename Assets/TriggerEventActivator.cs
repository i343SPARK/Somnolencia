using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventActivator : MonoBehaviour
{
    public GameObject doorEvent, dialogueActivated;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorEvent.SetActive(true);
            dialogueActivated.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
