using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicroWageEvent : MonoBehaviour
{
    public GameObject sandwich;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
    
    public void DisableMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
