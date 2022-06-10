using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catText : MonoBehaviour
{
    public GameObject cattext;
    // Start is called before the first frame update
    public void Start()
    {
        cattext.SetActive(false);
    }

    public void OnMouseOver()
    {
        cattext.SetActive(true);
    }

    public void OnMouseExit()
    {
        cattext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}
