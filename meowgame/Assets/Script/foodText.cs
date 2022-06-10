using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodText : MonoBehaviour
{
    public GameObject foodtext;
    // Start is called before the first frame update
    public void Start()
    {
        foodtext.SetActive(false);
    }

    public void OnMouseOver()
    {
        foodtext.SetActive(true);
    }

    public void OnMouseExit()
    {
        foodtext.SetActive(false);
    }
    // Update is called once per frame
    /*public void Update()
    {
        
    }*/
}
