using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instance;
    //public Image imgGaze;
    public Vector3 originScale;
    public float totalTime;
    float gvrTimer;
    bool gvrStatus;
    float speed = 0.01f;
    static int score = 0;
    public int itemScore;
    public Text Scoreboard;
    static int life = 3;
    public Text gameover;
    public Text lifemode;
    public Text retry;
    Vector3 target = new Vector3(0f, 1.2f, 219.6f);

    void Start()
    { 
        instance = this.gameObject;
        originScale = instance.transform.localScale; 
        Scoreboard = GameObject.Find("board").GetComponent<Text>();
        lifemode = GameObject.Find("life").GetComponent<Text>();
        gameover = GameObject.Find("over").GetComponent<Text>();
        retry = GameObject.Find("retry").GetComponent<Text>();

    }

    void Update()
    {
        if(life==0){
            gameover.text = "Game Over";
            retry.text = "다시하기";
        }
        else{

            instance.transform.position = Vector3.MoveTowards(instance.transform.position, target, 0.1f);
            Debug.Log("go");

            if (instance.transform.position == target){
                Debug.Log("checkin");
                if(gameObject.CompareTag("bad")){
                    life -= 1;
                    lifemode.text = "Life : "+ life.ToString();
                }
                Destroy(instance);                
            }
            else if(gvrStatus)
            {
                instance.transform.localScale = originScale*(1+gvrTimer*speed);
                gvrTimer += Time.deltaTime;

                if(gvrTimer > totalTime){
                    score += itemScore;
                    Scoreboard.text = "Score : "+score.ToString();
                    Destroy(instance);
                }
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
        instance.transform.localScale = originScale;
    }
}

 
            
            

            