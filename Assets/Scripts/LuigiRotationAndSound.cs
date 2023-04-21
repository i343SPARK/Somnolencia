using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiRotationAndSound : MonoBehaviour
{
    bool secure = false;

    // Update is called once per frame
    void Update()
    {
        if (secure && transform.rotation.z > -0.83f)
        {
            transform.Rotate(0, 0, -120 * Time.deltaTime);
            Debug.Log(transform.rotation.z);
        }

        //Si el audio termina de reproducirse se destruye el objeto
        if (gameObject.GetComponent<AudioSource>().isPlaying == false && transform.rotation.z < -0.8f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            secure = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
