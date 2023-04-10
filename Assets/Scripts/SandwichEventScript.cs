using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script que compone el sanwich, este script se encarga de
//activar el evento de la microondas y destruir el sandwich
//al presionar la E y cuando se acerca al jugador
public class SandwichEventScript : MonoBehaviour
{
    //Se llama al componente de la UI que indica que se puede interactuar
    public GameObject uIKeyInteractive;
    // Se llama al componente del evento de la microondas
    MicroWageEvent _microWageEvent;
    
    //Variable para asegurar que el objeto se destruya solo cuando el jugador este cerca
    private bool secureDestroy = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //Se llama al componente de la UI, el cual es el Script ShowUIKeyInteractive
        uIKeyInteractive.GetComponent<ShowUIKeyInteractive>();
        //Se llama al componente del evento de la microondas desde el objeto que tiene el tag Microwave
        _microWageEvent = GameObject.FindWithTag("Microwave").GetComponent<MicroWageEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Se llama a la funcion Interact del script ShowUIKeyInteractive el cual se encarga
        //de desactivar la UI cuando se presiona la E
        uIKeyInteractive.GetComponent<ShowUIKeyInteractive>().Interact(gameObject);

        //Si el jugador esta cerca del objeto y presiona la E, se destruye el objeto, asegurando 
        //que el jugador este cerca y despues de presionar la E
        if (secureDestroy)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
            }
        }
        
    }

    //Funcion que se activa cuando el jugador entra en el area de colision del objeto
    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto que entra en el area de colision tiene el tag Player
        if (other.CompareTag("Player"))
        {
            // Debug.Log("Player entered the administrative area");
            //Se activa la UI que indica que se puede interactuar
            uIKeyInteractive.SetActive(true);
            //Se activa el evento de la microondas
            _microWageEvent.EnableMicrowaveEvent();
            //Se quita el seguro de destruccion
            secureDestroy = true;
        }
    }

    //Funcion que se activa cuando el jugador sale del area de colision del objeto
    private void OnTriggerExit(Collider other)
    {
        //Si el objeto que sale del area de colision tiene el tag Player
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player exited the administrative area");
            //Se desactiva la UI que indica que se puede interactuar
            uIKeyInteractive.SetActive(false);
            //Se desactiva el evento de la microondas
            _microWageEvent.DisableMicrowaveEvent();
            //Se pone el seguro de destruccion
            secureDestroy = false;
        }
    }
    
}
