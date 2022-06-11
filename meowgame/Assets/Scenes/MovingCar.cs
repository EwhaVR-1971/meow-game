using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    public float timer;
    public int waitingTime;
    public GameObject car;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer <  2)
        {
            //Action
            transform.position += new Vector3(0, 0, 0.9f);
        }
        else
        {
            car.SetActive(false);
        }
    }
}
