using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour {

    Animator AnimatorComponent;
    // Use this for initialization
    void Start()
    {
        AnimatorComponent = (GameObject.Find("uganda")).GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
               
    }

    public void trun360()
    {
        AnimatorComponent.Play("360", -1, 0f);
    }

    public void jump()
    {
        AnimatorComponent.Play("jump", -1, 0f);
    }

    public void jumpAnd360()
    {
        AnimatorComponent.Play("jumpAnd360", -1, 0f);
    }

    public void exit()
    {
        Application.Quit();
    }
}
