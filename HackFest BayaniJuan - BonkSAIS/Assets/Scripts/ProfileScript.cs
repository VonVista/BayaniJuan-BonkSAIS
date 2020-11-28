using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileScript : MonoBehaviour
{
    public Text userText;
    public TransitionControl trans;
    public Animator transitionanim;

    void Start()
    {
        if (userText != null)
        {
            userText.text = PlayerPrefs.GetString("USERNAME");
        }
    }

    public void GotoVerification()
    {
        trans.setSceneNum(9);
        transitionanim.SetTrigger("Exit");
    }
    public void GotoDashboard()
    {
        trans.setSceneNum(10);
        transitionanim.SetTrigger("Exit");
    }
}
