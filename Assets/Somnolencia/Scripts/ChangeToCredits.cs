using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToCredits : MonoBehaviour
{
    public GameObject theAnotherPanel;
    public AudioSource audioSource;
    
    public void ChangeToCreditsScene()
    {
        theAnotherPanel.SetActive(true);
        audioSource.Stop();
    }
}
