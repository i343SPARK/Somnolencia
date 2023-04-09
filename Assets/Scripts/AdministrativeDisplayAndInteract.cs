using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AdministrativeDisplayAndInteract : MonoBehaviour
{

    public GameObject UIKeyInteractive;
    // Start is called before the first frame update
    void Start()
    {
        UIKeyInteractive.GetComponent<ShowUIKeyInteractive>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the administrative area");
            UIKeyInteractive.SetActive(true);
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the administrative area");
            UIKeyInteractive.SetActive(false);
        }
    }
}
