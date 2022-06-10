using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoiledText : MonoBehaviour
{
    public GameObject spoiledtext;
    // Start is called before the first frame update
    public void Start()
    {
        spoiledtext.SetActive(false);
    }

    public void OnMouseOver()
    {
        spoiledtext.SetActive(true);
    }

    public void OnMouseExit()
    {
        spoiledtext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}