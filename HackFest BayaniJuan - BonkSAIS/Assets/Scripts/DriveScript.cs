using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriveScript : MonoBehaviour
{
    public TransitionControl trans;
    public Animator transitionanim;

    public void GotoReport()
    {
        trans.setSceneNum(7);
        transitionanim.SetTrigger("Exit");
    }
    public void GotoDonate()
    {
        trans.setSceneNum(8);
        transitionanim.SetTrigger("Exit");
    }

}
