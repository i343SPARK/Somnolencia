using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewActivationObject : MonoBehaviour
{
    public GameObject objectActivated, objectDestroy;
    // Start is called before the first frame update
    private void OnBecameVisible()
    {
        objectActivated.SetActive(true);
        Destroy(objectDestroy);
    }
}
