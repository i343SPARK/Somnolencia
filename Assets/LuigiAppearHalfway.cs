using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiAppearHalfway : MonoBehaviour
{
    public GameObject luigi, componentToDestroy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            luigi.SetActive(true);
            Destroy(componentToDestroy);
        }
    }
}
