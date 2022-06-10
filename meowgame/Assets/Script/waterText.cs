using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterText : MonoBehaviour
{
    public GameObject watertext;
    // Start is called before the first frame update
    public void Start()
    {
        watertext.SetActive(false);
    }

    public void OnMouseOver()
    {
        watertext.SetActive(true);
    }

    public void OnMouseExit()
    {
        watertext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}