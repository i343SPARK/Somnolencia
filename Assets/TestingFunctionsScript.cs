using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// comenta el codigo cuando puedas, es para que no se me olvide que hace cada cosa
public class TestingFunctionsScript : MonoBehaviour
{
    public GameObject lights; // luces de la escena
    public GameObject sound; // sonido de las luces
    public GameObject sound2; // musica de ambiente
    private bool toggleLights = true; // variable para activar y desactivar las luces
    private bool secureSound = false; // variable para asegurar que el sonido se desactive hasta que el pitch llegue a cero
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
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
    }
    
}
