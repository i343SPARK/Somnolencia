using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuigiFollowPlayer : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        //mueve a luigi cuando el jugador se mueve dejando una distancia
        transform.position = new Vector3(player.transform.position.x + 3f, transform.position.y,
            player.transform.position.z + 0.5f);
    }

    // private void OnBecameVisible()
    // {
    //     soundUp.SetActive(true);
    // }
}
