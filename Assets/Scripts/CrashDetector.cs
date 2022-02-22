using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    [SerializeField] float delayToLoad = 0.5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Invoke("reloadScene", delayToLoad);
        }
    }

    void reloadScene() 
    {
        SceneManager.LoadScene(0);        
    }
}
