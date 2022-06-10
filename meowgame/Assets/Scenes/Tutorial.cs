using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cat;
    public GameObject car;
    public GameObject choco;
    public GameObject choi;
    public GameObject rice;
    void Start()
    {
        cat.SetActive(false);
        car.SetActive(false);
        choco.SetActive(false);
        choi.SetActive(false);
        rice.SetActive(false);
    }

    // Update is called once per frame
    public void Cat(){
        cat.SetActive(true);
    }
    public void Car(){
        car.SetActive(true);
    }
    public void Choco(){
        choco.SetActive(true);
    }
    public void Choi(){
        choi.SetActive(true);
    }
    public void Rice(){
        rice.SetActive(true);
    }

    public void CatExit(){
        cat.SetActive(false);
    }
    public void CarExit(){
        car.SetActive(false);
    }
    public void ChocoExit(){
        choco.SetActive(false);
    }
    public void ChoiExit(){
        choi.SetActive(false);
    }
        public void RiceExit(){
        rice.SetActive(false);
    }

}
