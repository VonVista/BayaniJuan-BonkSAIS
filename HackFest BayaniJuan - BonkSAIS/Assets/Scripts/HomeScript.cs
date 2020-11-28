using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScript : MonoBehaviour
{
    public Text userText;
    public TransitionControl trans;
    public Animator transitionanim;

    // Start is called before the first frame update
    void Start()
    {
        if (userText != null)
        {
            userText.text = PlayerPrefs.GetString("USERNAME");
        }
    }

    public void GotoDrive()
    {
        trans.setSceneNum(2);
        transitionanim.SetTrigger("Exit");
    }

    public void GotoDrive2()
    {
        trans.setSceneNum(12);
        transitionanim.SetTrigger("Exit");
    }
    public void GotoDrive3()
    {
        trans.setSceneNum(13);
        transitionanim.SetTrigger("Exit");
    }
    public void GotoDrive4()
    {
        trans.setSceneNum(14);
        transitionanim.SetTrigger("Exit");
    }
    public void GotoDrive5()
    {
        trans.setSceneNum(15);
        transitionanim.SetTrigger("Exit");
    }

}
