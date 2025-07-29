
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMiranda: MonoBehaviour
{
    Animator animator;
    public GameObject Effect1;
    public GameObject Effect2;
    private bool fast;
    private bool music;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        fast = animator.GetBool("fast");
        music = animator.GetBool("music");
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("fast", true);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("music", true);
        }

    }
}
