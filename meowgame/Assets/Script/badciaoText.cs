using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badciaoText : MonoBehaviour
{
    public GameObject badciaotext;
    // Start is called before the first frame update
    public void Start()
    {
        badciaotext.SetActive(false);
    }

    public void OnMouseOver()
    {
        badciaotext.SetActive(true);
    }

    public void OnMouseExit()
    {
        badciaotext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}
