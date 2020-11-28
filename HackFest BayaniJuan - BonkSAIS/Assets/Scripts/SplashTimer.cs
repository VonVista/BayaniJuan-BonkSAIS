using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoLogin()
    {
        SceneManager.LoadScene(6);
    }
}
