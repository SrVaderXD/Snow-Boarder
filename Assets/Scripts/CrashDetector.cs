using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    [SerializeField] float delayToLoad = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().disableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("reloadScene", delayToLoad);
        }
    }

    void reloadScene() 
    {
        SceneManager.LoadScene(0);        
    }
}
