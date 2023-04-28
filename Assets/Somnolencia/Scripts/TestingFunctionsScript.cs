using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// comenta el codigo cuando puedas, es para que no se me olvide que hace cada cosa
public class TestingFunctionsScript : MonoBehaviour
{
    // luces de la escena, sonido de las luces, musica de ambiente, sonido de prueba, pantalla de fade
    //public GameObject lights, sound, sound2, soundTest, fadeScreen;
    public GameObject player, player2, soundAmbient;
    
    
    // Start is called before the first frame update
    void Start()
    { 
        // Se asegura que se desactivan las luces y que se activa la pantalla de fade
        //soundTest.SetActive(false);
        //fadeScreen.SetActive(true);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            player.SetActive(false);
            player2.SetActive(true);
            soundAmbient.SetActive(false);
            RenderSettings.fog = true;
        }
    }
    
}
