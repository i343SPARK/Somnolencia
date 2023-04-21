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
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f);
    }
    
}
