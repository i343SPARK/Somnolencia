using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLuigiFollow : MonoBehaviour
{
    
    public GameObject luigi, parent;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            luigi.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(parent);
        }
    }
}
