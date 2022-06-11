using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MovingCat : MonoBehaviour
{
    public float timer;
    public float waitingTime;
    public GameObject cat1;
    public GameObject cat2;
    //public GameObject thought1;
    public GameObject thought2;


    void Update()
    {
        waitingTime -= Time.deltaTime;
        timer += Time.deltaTime;

        if (timer < 3)
        {
            //Action
            transform.position += new Vector3(0.13f, 0, 0);
        }
        else if (timer > 3)
        {
            //thought1.SetActive(true); 
             cat1.SetActive(false);
            //thought1.SetActive(false);
            cat2.SetActive(true);
            thought2.SetActive(true);

        }       
        else if (timer >4){
            SceneManager.LoadScene(0);
        }
    }
}
