using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esta clase se encarga de crear metodos para reproducir los audios de la animacion
//del microondas
public class AudioPlayEvent : MonoBehaviour
{

    //Se llaman los Audios del mismo componente, y se categorizan en cuestion
    //a como se van llamando
    public AudioSource audio1, audio2, audio3, audio4;
    PointOfMicrowave _pointOfMicrowave;
    UniverseController _universeController;
    public GameObject player2, camera;

    void Start()
    {
        _pointOfMicrowave = GameObject.FindWithTag("BrainCode1").GetComponent<PointOfMicrowave>();
        _universeController = GameObject.FindWithTag("BrainCode1").GetComponent<UniverseController>();
    }

    //Reproduce el primer audio del evento del microondas
    public void PlayOpenSound()
    {
        audio1.Play();
    }

    public void PlayCloseSound()
    {
        audio2.Play();
    }
    
    public void PlaySecuenceSound()
    {
        audio3.Play();
    }

    public void StopSecuenceSound()
    {
        audio3.Stop();
    }
    
    public void PlayElectricitySound()
    {
        audio4.Play();
    }
    
    public void StopElectricitySound()
    {
        audio4.Stop();
    }
    
    public void PlayFunctionMoment()
    {
        _pointOfMicrowave.ActivationOfMicrowaveEvent();
    }
    
    public void SetPlayerOn()
    {
        player2.SetActive(true);
        camera.GetComponent<AudioListener>().enabled = false;
        camera.SetActive(false);
        gameObject.SetActive(false);
    }
    
    public void FadeIn()
    {
        _universeController.FadeIn();
    }
    
    public void FadeOut()
    {
        _universeController.FadeOut();
    }

}
