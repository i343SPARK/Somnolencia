using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// comenta el codigo cuando puedas, es para que no se me olvide que hace cada cosa
public class TestingFunctionsScript : MonoBehaviour
{
    public GameObject lights, sound, sound2, soundTest, fadeScreen; // luces de la escena, sonido de las luces, musica de ambiente, sonido de prueba
    private bool toggleLights = true; // variable para activar y desactivar las luces
    private bool secureSound = false; // variable para asegurar que el sonido se desactive hasta que el pitch llegue a cero
    
    
    // Start is called before the first frame update
    void Start()
    {
      soundTest.SetActive(false);  
      fadeScreen.SetActive(true);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            // si toggleLights es true, desactiva las luces y activa el sonido
            if (toggleLights)
            {
                lights.SetActive(false);
                sound.SetActive(true);
                RenderSettings.fog = true;
                secureSound = true;
                toggleLights = false;
            }
            // si toggleLights es false, activa las luces y desactiva el sonido
            else
            {
                secureSound = false;
                lights.SetActive(true);
                sound.SetActive(false);
                RenderSettings.fog = false;
                sound2.GetComponent<AudioSource>().pitch = 1;
                toggleLights = true;
            }

        }
        
        // Reduce el pitch del sonido2(musica de ambiente) de forma lineal hasta llegar a cero
        if (secureSound && sound2.GetComponent<AudioSource>().pitch > -0.1f)
        {
            sound2.GetComponent<AudioSource>().pitch -= 0.1f * Time.deltaTime;
        }
        else
        {
            secureSound = false;
        }

        if (sound2.GetComponent<AudioSource>().pitch < -0.1f)
        {
            soundTest.SetActive(true);
            sound2.SetActive(false);
        }
    }
    
}
