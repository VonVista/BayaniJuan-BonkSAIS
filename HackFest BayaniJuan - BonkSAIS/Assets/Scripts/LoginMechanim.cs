using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginMechanim : MonoBehaviour
{
    public InputField userField, passwordField;
    public TransitionControl trans;
    public Animator transitionanim;


    public void isInputted()
    {
        if(userField.text != "" && passwordField.text != "")
        {
            PlayerPrefs.SetString("USERNAME", userField.text);
            trans.setSceneNum(1);
            transitionanim.SetTrigger("Exit");
        }
    }
}
