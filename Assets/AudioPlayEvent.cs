using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esta clase se encarga de crear metodos para reproducir los audios de la animacion
//del microondas
public class AudioPlayEvent : MonoBehaviour
{

    //Se llaman los Audios del mismo componente, y se categorizan en cuestion
    //a como se van llamando
    public AudioSource audio1, audio2, audio3;
    
    //Reproduce el primer audio del evento del microondas
    public void PlayOpenSound()
    {
        audio1.Play();
    }

    public void PlayCloseSound()
    {
        audio2.Play();
    }
}
