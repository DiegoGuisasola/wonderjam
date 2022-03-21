using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    public float velocidad;
    private AudioSource stepSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        stepSound=gameObject.GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("a") )
        {
            transform.position += new Vector3(-velocidad*Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(velocidad*Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;


        }

    }
}

