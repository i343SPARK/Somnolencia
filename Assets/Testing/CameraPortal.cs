using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPortal : MonoBehaviour
{
    public Camera otherCam;
    public Transform otherPortal;
    private Rigidbody playerRbody;
    
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion direction = Quaternion.Inverse(transform.rotation) * Camera.main.transform.rotation;
        otherCam.transform.localEulerAngles = new Vector3(direction.eulerAngles.x, direction.eulerAngles.y + 180,
            direction.eulerAngles.z);
    }
}
