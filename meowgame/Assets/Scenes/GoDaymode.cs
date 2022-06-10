using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoDaymode : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextScene(){
        SceneManager.LoadScene(1);
    }
}
