using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewActivationObject : MonoBehaviour
{
    public GameObject objectActivated, objectDestroy;
    
    bool secure = false;
    
    float delay = 15;
    float time = 0;
    // Start is called before the first frame update

    private void Update()
    {
        if (secure)
        {
            time += delay * Time.deltaTime;
            
            Debug.Log(time);
            
            if (time > 10)
            {
                Destroy(objectDestroy);
                secure = false;
            }
        }
    }

    private void OnBecameVisible()
    {
        objectActivated.SetActive(true);
        secure = true;
        //Destroy(objectDestroy);
    }
}
