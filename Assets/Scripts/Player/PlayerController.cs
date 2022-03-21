using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    private AudioSource audio;
    private Animator animator;
    [SerializeField]private  GameObject tl;
    [SerializeField]private  GameObject cm;
    [SerializeField] private AudioClip[] placeSound;

    private void Start()
    {
        audio=gameObject.GetComponent<AudioSource>();
        animator=gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        animator.SetBool("isrun",false);
        if (Input.GetKey("a") )
        {
            transform.position += new Vector3(-velocidad*Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            animator.SetBool("isrun",true);

        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(velocidad*Time.deltaTime, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            animator.SetBool("isrun",true);
        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("entramos");
        if (col.gameObject.tag=="puerta")
        {
            if (Input.GetKey("e"))
            {
                animator.SetBool("isaction",true);
                transform.position = tl.gameObject.transform.position;
                Camera.main.transform.position = cm.transform.position;
                audio.PlayOneShot(placeSound[0],1f);
            }
        }
    }
}

