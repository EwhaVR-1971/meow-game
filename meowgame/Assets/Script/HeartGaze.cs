/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartGaze : MonoBehaviour
{
    
    public Image imgGaze;

    public float totalTime;
    bool gvrStatus;
    float gvrTimer;
    public GameObject cat;
    public Vector3 originScale;
    // Start is called before the first frame update
    void Start()
    {
        originScale = cat.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            cat.transform.localScale = originScale * (1+gvrTimer);
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;

            if(gvrTimer > totalTime){
                //cat.SetActive(false);
                Destroy(cat);
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
        cat.transform.localScale = originScale;

    }
    
}
*/