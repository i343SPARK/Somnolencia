using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MicroWageEvent : MonoBehaviour
{
    
    public GameObject _uIKeyInteractive;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the microwave area");
            _uIKeyInteractive.SetActive(true);
        }
    }

    public void EnableMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
    
    public void DisableMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
