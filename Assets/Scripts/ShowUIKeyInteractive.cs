using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIKeyInteractive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Funcion recibe el objeto a interactuar y al precionar la E destruye el objeto
    public void Interact(GameObject obj)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(obj);
        }
    }
}
