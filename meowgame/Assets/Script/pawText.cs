using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawText : MonoBehaviour
{
    public GameObject pawtext;
    // Start is called before the first frame update
    public void Start()
    {
        pawtext.SetActive(false);
    }

    public void OnMouseOver()
    {
        pawtext.SetActive(true);
    }

    public void OnMouseExit()
    {
        pawtext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}