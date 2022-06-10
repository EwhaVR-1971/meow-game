using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userText : MonoBehaviour
{
    public GameObject usertext;
    // Start is called before the first frame update
    public void Start()
    {
        usertext.SetActive(false);
    }

    public void OnMouseOver()
    {
        usertext.SetActive(true);
    }

    public void OnMouseExit()
    {
        usertext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}