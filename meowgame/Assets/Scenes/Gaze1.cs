using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze1 : MonoBehaviour
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
    public Text Scoreboard1;
    public Text gameover1;
    public Text retry1;
    static float gameTimer;
    public Text timescore;
    Vector3 target = new Vector3(0f, 1.2f, 205f);

    void Start()
    { 
        instance = this.gameObject;
        originScale = instance.transform.localScale; 
        Scoreboard1 = GameObject.Find("board1").GetComponent<Text>();
        gameover1 = GameObject.Find("over1").GetComponent<Text>();
        retry1 = GameObject.Find("retry1").GetComponent<Text>();
        timescore = GameObject.Find("time1").GetComponent<Text>();

    }

    void Update()
    {
        gameTimer += Time.deltaTime;
        if(score>=500){
            Time.timeScale = 0f;
            timescore.text = "Time : " + Mathf.Round(gameTimer).ToString();
            gameover1.text = "GAEM OVER";
            retry1.text = "다시하기";
        }
        else{

            instance.transform.position = Vector3.MoveTowards(instance.transform.position, target, 0.1f);
            Debug.Log("go");

            if (instance.transform.position == target){
                Debug.Log("checkin");
                Destroy(instance);                
            }
            else if(gvrStatus)
            {
                instance.transform.localScale = originScale*(1+gvrTimer*speed);
                gvrTimer += Time.deltaTime;

                if(gvrTimer > totalTime){
                    score += itemScore;
                    Scoreboard1.text = "Score : "+score.ToString();
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

 
            
            

            