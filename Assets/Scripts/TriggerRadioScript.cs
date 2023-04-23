using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRadioScript : MonoBehaviour
{
    public GameObject _UIKeyInteractive, musicAmbient, dialogueBox, doorActitator;

    bool secure = false;
    // Update is called once per frame
    void Update()
    {
        if (secure && Input.GetKeyDown(KeyCode.E))
        {
            _UIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact();
            dialogueBox.SetActive(true);
            musicAmbient.SetActive(false);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            doorActitator.SetActive(true);
            secure = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            secure = true;
            _UIKeyInteractive.SetActive(true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            secure = false;
            _UIKeyInteractive.SetActive(false);
        }
    }
}
