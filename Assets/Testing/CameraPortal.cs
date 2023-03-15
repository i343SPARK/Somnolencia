using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPortal : MonoBehaviour
{
    
    public GameObject otherCam;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        //imita la rotacion de la camara y gira 180 grados para que el portal se vea bien
        transform.rotation = Quaternion.Euler(otherCam.transform.rotation.eulerAngles.x,
            otherCam.transform.rotation.eulerAngles.y + 180, 270);
        
        //imita la posicion de la camara
        transform.position = -otherCam.transform.position;
        
        
    }
}
