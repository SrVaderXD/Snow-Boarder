using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSped = 30f;

    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        rotatePlayer();
        boostPlayer();
    }

    void rotatePlayer() 
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-torqueAmount);
        }
    }

    void boostPlayer()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSped;
        }

        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
