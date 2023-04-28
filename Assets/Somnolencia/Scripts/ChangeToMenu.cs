using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMenu : MonoBehaviour
{
    public void ChangeToMenuScene()
    {
        //Aqui va el menu
        SceneManager.LoadScene("Level 2");
    }
}
