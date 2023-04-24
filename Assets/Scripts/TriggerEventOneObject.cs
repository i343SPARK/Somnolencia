using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventOneObject : MonoBehaviour
{
    public GameObject animateActivate, _UIKeyInteractive;
    bool secure = false;
    // Update is called once per frame
    void Update()
    {
        if (secure && Input.GetKeyDown(KeyCode.E))
        {
            _UIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<DialogueSceneChange>().enabled = true;
            animateActivate.SetActive(true);
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
