using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Modefunction : MonoBehaviour
{
    public static float timer;
    public int gvr=0;
    // Start is called before the first frame update
    void Update(){
        if(gvr==1){
            timer += Time.deltaTime;
            if(timer > 1){
                SceneManager.LoadScene(1);
            }
        }
        if(gvr==2){
            timer += Time.deltaTime;
            if(timer > 1){
                SceneManager.LoadScene(5);
            }
        }
        if(gvr==3){
            timer += Time.deltaTime;
            if(timer > 1){
                SceneManager.LoadScene(6);
            }
        }
        
    }

    public void lookIntro(){
        gvr = 1;
    }

    public void lookStart(){
        gvr =2;
    }

    public void lookTutor(){
        gvr =3;
    }

}
