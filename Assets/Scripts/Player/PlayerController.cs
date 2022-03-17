using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    private void FixedUpdate()
    {

        if (Input.GetKey("a") )
        {
            transform.position += new Vector3(-velocidad*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(velocidad*Time.deltaTime, 0, 0);
        }

            
        }
}

