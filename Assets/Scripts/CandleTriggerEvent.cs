using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleTriggerEvent : MonoBehaviour
{
    public GameObject _UIKeyInteractive, candleHUD, wallBlock;
    
    bool secure = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (secure && Input.GetKeyDown(KeyCode.E))
        {
            _UIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact();
            candleHUD.SetActive(true);
            wallBlock.SetActive(false);
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
