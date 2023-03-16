using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPortal : MonoBehaviour
{
    
    public GameObject otherCam;
    public GameObject player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //imita la rotacion de la camara y gira 180 grados para que el portal se vea bien
        transform.rotation = Quaternion.Euler(otherCam.transform.rotation.eulerAngles.x,
            otherCam.transform.rotation.eulerAngles.y + 180, 0);

        Vector3 pos = transform.InverseTransformPoint(player1.transform.position);

        //Mover al objeto al mismo tiempo que se mueve pos
        transform.localPosition = -new Vector3(pos.x, -pos.y, pos.z);

    }
}
