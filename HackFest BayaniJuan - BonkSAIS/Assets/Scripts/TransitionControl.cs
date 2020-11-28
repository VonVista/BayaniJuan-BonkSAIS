using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionControl : MonoBehaviour
{
    private int sceneNum;
    
    public void setSceneNum(int sceneNum)
    {
        this.sceneNum = sceneNum;
    }

    public void GoTo()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
