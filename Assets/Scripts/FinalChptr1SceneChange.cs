using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalChptr1SceneChange : MonoBehaviour
{
    public GameObject sceneToLoad, actualScene,parentComponent, playerToDisable;
    // Start is called before the first frame update
    public void LoadCinematicChptr1()
    {
        RenderSettings.fogDensity = 0f;
        sceneToLoad.SetActive(true);
        actualScene.SetActive(false);
        parentComponent.SetActive(false);
        playerToDisable.SetActive(false);
    }
}
