using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchPageScripts : MonoBehaviour
{
    public Text searchtext;

    // Start is called before the first frame update
    void Start()
    {
        this.searchtext.text = PlayerPrefs.GetString("SEARCH");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
