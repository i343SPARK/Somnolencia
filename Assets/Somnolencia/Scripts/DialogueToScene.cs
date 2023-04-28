using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueToScene : MonoBehaviour
{
    public TextMeshProUGUI textComponent; //Reference the text component of Text Mesh pro 
    public GameObject panelText;
    public Animator animator;
    public string[] lines; //A place where to store the dialogue lines that we can specify later on
    public float textSpeed; //Speed in which the dialogue will be displayed
    private int index; //An index which will help us track where we are in the conversation

    //public MonoBehaviour PlayerController; //Reference to the player script controller (foreign script)
    bool isActive = true;

    private void OnEnable() //Starts when the object alongside the script is enabled
    {
        if (isActive == false)
        {
            Start();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        panelText.SetActive(true);
        textComponent.text = string.Empty; //It CLEANS the dialogue box for a new use 
        StartDialogue(); //Starts dialogue method
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //If the right button of the mouse is clicked then...
        {
            if (textComponent.text == lines[index]) //If the dialogue is not finished yet the just proceed to next line.
            {
                NextLine(); //calls next line method
            }
            else
            {
                StopAllCoroutines(); //Do i need to explain?
                textComponent.text = lines[index];// it will get the current line and instantly fil it out
            }
        }
        
        // AnimatorStateInfo animState = animator.GetCurrentAnimatorStateInfo(0);
        // if (animState.IsName("DarkScreenInEnded"))
        // {
        //     if (animState.normalizedTime >= 1)
        //     {
        //         Debug.Log("Scene is Over!");
        //         SceneManager.LoadScene("Level 4");
        //     }
        // }
    }

    void StartDialogue() //Method used to start the dialogue 
    {
        //PlayerController.enabled = false; //If its an ongoing dialogue, the player wont move
        isActive = false;

        index = 0;  //Makes index 0
        StartCoroutine(TypeLine()); //It basically calls the method we just created, except is not a method, but a co routine.
    }

    IEnumerator TypeLine() //"IEnumerator" is the return type, and it will type each character 1 by 1
    {
        foreach (char c in lines[index].ToCharArray()) //Takes the string and then it breaks it down to a char array one by one. "c" is the name of the variable 
        {
            textComponent.text += c; // Adds a character to whatever value "c" had already.
            yield return new WaitForSeconds(textSpeed); //returns the value after some seconds depending on the "speed" that was given
        }
    }

    void NextLine() //Method used to move to the next line when the current dialogue line is finished
    {
        if (index < lines.Length - 1) //If we are done with the dialogue line and there is a next one then...
        {
            index++; //Get to the next index
            textComponent.text = string.Empty; //Cleans dialogue text
            StartCoroutine(TypeLine()); //Class the corutine typeline
        }
        else
        {
            textComponent.text = string.Empty;
            panelText.SetActive(false);
            animator.Play("LastAnimationChptr1");
            //Debug.Log("Scene is Over!");
            //gameObject.GetComponent<DialogueSceneChange>().enabled = false;
            //si la animator acaba, entonces cambia de escena
        }
    }
}
/* SCRIPT CONTEXT
 
This script is used to make a functional and simple dialoge box appear, disappear, get to next line etc. 
what you need is a Canvas in you scene,
then give that canvas a Panel object (which we will call Dialogue box),
and to that dialogue box, give it a Text Mesh pro.
This Script is supposed to be given as a component to the dialogue box. 
 
This script is only used when you want to change to the next scene when 
 */