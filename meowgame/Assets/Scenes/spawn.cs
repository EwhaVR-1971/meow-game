using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] prefabs; 
    private BoxCollider area;  
    public int count;     
    float currTime;
    private List<GameObject> gameObject = new List<GameObject>();


    void Start(){
       
    }
    void Update(){
        currTime += Time.deltaTime;
        area = GetComponent<BoxCollider>();
        if(currTime > 2){
            for(int i = 0; i < count; ++i)
            {
                Spawn();
            }     
            currTime = 0;
        }
        area.enabled = false;
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;
        
        float posX = basePosition.x + Random.Range(-size.x/2f, size.x/2f);
        float posY = basePosition.y + Random.Range(-size.y/2f, size.y/2f);
        float posZ = basePosition.z + Random.Range(-size.z/2f, size.z/2f);
        
        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        
        return spawnPos;
    }

     private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);
        
        GameObject selectedPrefab = prefabs[selection];
        
        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수
        
        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
        
    }

}
