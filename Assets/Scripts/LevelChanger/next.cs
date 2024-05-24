using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public int levelToLoad;
    public float time;
    public float nextLevel;
    
    void Update()
    {
        if(time > nextLevel)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        time += Time.deltaTime;
    }   
}
