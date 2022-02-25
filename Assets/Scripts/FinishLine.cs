using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float delayToLoad = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            
            Invoke("reloadScene", delayToLoad);
        }
    }

    void reloadScene() 
    {
        SceneManager.LoadScene(0);        
    }
}
