using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichEventScript : MonoBehaviour
{
    public GameObject uIKeyInteractive;
    MicroWageEvent _microWageEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        uIKeyInteractive.GetComponent<ShowUIKeyInteractive>();
        _microWageEvent = GameObject.FindWithTag("Microwave").GetComponent<MicroWageEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        uIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the administrative area");
            uIKeyInteractive.SetActive(true);
            _microWageEvent.EnableMicrowaveEvent();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the administrative area");
            uIKeyInteractive.SetActive(false);
            _microWageEvent.DisableMicrowaveEvent();
        }
    }
}
