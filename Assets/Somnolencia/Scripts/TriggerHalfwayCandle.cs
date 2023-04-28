using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHalfwayCandle : MonoBehaviour
{
    public GameObject _UIKeyInteractive, candleHUD, triggerEvent, triggerEvent2;
    bool secure = false;


    private void Update()
    {
        if (secure && Input.GetKeyDown(KeyCode.E))
        {
            _UIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact();
            candleHUD.SetActive(true);
            triggerEvent.SetActive(true);
            triggerEvent2.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _UIKeyInteractive.SetActive(true);
            secure = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _UIKeyInteractive.SetActive(false);
            secure = false;
        }
    }
}
