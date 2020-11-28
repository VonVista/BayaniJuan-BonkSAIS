using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FooterSceneManager : MonoBehaviour
{
    public TransitionControl trans;
    public Animator transitionanim;

    public void GotoHome()
    {
        trans.setSceneNum(1);
        transitionanim.SetTrigger("Exit");
    }

    public void GotoProfile()
    {
        trans.setSceneNum(3);
        transitionanim.SetTrigger("Exit");
    }


}
