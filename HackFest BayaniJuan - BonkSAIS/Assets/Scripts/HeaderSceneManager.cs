using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeaderSceneManager : MonoBehaviour
{
    public TransitionControl trans;
    public Animator transitionanim;
    public InputField searchbar;

    public void Search()
    {
        trans.setSceneNum(5);
        PlayerPrefs.SetString("SEARCH",searchbar.text);
        transitionanim.SetTrigger("Exit");
    }

    public void GotoBack()
    {
        trans.setSceneNum(1);
        transitionanim.SetTrigger("Exit");
    }

    public void GotoMessages()
    {
        trans.setSceneNum(4);
        transitionanim.SetTrigger("Exit");
    }


}
