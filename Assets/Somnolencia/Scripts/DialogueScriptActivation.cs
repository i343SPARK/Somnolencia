using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScriptActivation : MonoBehaviour
{
    public GameObject garageDoor;

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //dialogueBox.SetActive(true);
            gameObject.GetComponent<Dialogue>().enabled = true;
            Destroy(garageDoor);
        }
    }
}
