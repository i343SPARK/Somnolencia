using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingLuigiScript : MonoBehaviour
{

    public GameObject screenImage;
    float delay = 1, speed = 7;
    float time = 0;

    private void Start()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = false;
    }

    void Update()
    {
        time += delay * Time.deltaTime;
            
        Debug.Log(time);
            
        if (time > 10)
        {
            //speed += 1.1f;
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            screenImage.SetActive(true);
            Destroy(gameObject);
        }
    }
}
