using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivatorDoor : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Dialogue>().enabled = true;
        }
    }
}
