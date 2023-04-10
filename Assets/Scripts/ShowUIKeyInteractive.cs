using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase se encarga de desactivar el objeto que se le pasa por parametro al precionar la tecla E
public class ShowUIKeyInteractive : MonoBehaviour
{
    
    //Funcion recibe el objeto a interactuar y al precionar la E destruye el objeto
    public void Interact(GameObject obj)
    {
        //Si se preciona la tecla E se desactiva la UI
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
        }
    }
}
