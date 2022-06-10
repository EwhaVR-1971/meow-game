using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStart : MonoBehaviour
{
    // Start is called before the first frame update
    public int gvr =0;
    public static float timer;
    void Update(){
        if(gvr==1){
            timer += Time.deltaTime;
            if(timer > 1){
                SceneManager.LoadScene(0);
            }
        }
    }
    
    public void lookRe(){
        gvr = 1;
    }
}
