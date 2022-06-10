using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chocoText : MonoBehaviour
{
    public GameObject chocotext;
    // Start is called before the first frame update
    public void Start()
    {
        chocotext.SetActive(false);
    }

    public void OnMouseOver()
    {
        chocotext.SetActive(true);
    }

    public void OnMouseExit()
    {
        chocotext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}