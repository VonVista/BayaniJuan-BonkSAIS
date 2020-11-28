using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OrganizerScript : MonoBehaviour
{
    public TransitionControl trans;
    public Animator transitionanim;

    public void GotoOrganizeDrive()
    {
        trans.setSceneNum(11);
        transitionanim.SetTrigger("Exit");
    }
}
