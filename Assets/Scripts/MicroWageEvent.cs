using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Esta clase se encarga de manejar los eventos de la microondas
public class MicroWageEvent : MonoBehaviour
{
    // Se llama al componente de la UI que indica que se puede interactuar
    public GameObject _uIKeyInteractive;
    // Start is called before the first frame update
    void Start()
    {
        //Se asegura que el BoxCollider este desactivado al iniciar el juego
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Funcion que se activa cuando el jugador entra en el area de colision del objeto
    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto que entra en el area de colision tiene el tag Player
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player entered the microwave area");
            //Se activa la UI que indica que se puede interactuar
            _uIKeyInteractive.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Player exited the microwave area");
            //Se desactiva la UI que indica que se puede interactuar
            _uIKeyInteractive.SetActive(false);
        }
    }

    //Funcion que se activa cuando el jugador se encuentra en el area de colision del sandwich
    public void EnableMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
    
    //Funcion que se activa cuando el jugador se encuentra fuera del area de colision del sandwich
    public void DisableMicrowaveEvent()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
