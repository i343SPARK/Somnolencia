using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniverseController : MonoBehaviour
{
    public GameObject animObject;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        animObject.SetActive(true);
        anim.Play("DarkScreen");
    }

    // Update is called once per frame
    public void FadeIn()
    {
        anim.Play("DarkScreenIn");
    }
    public void FadeOut()
    {
        anim.Play("DarkScreen");
    }
}
