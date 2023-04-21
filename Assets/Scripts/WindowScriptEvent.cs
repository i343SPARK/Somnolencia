using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScriptEvent : MonoBehaviour
{
    public GameObject _UIKeyInteractive, SoundProgresive, dialogueBox, luigiTrigger;
    public Animator _animator;
    
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
            _animator.Play("WindowEvent");
            SoundProgresive.SetActive(true);
            dialogueBox.SetActive(true);
            luigiTrigger.SetActive(true);
            gameObject.GetComponent<BoxCollider>().enabled = false;
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
