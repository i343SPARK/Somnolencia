using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDownHalfWay : MonoBehaviour
{
    public AudioSource audioSource2;
    
    bool secure = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (audioSource2.volume > 0 && secure)
        {
            audioSource2.volume -= 0.1f * Time.deltaTime;
        }

        if (audioSource2.volume < -0.01f)
        {
            secure = false;
            audioSource2.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            secure = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}