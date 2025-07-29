using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerAbigail : MonoBehaviour
{
    Animator animator;
    public GameObject Effect1;
    public GameObject Effect2;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    void Update()
    {
        bool light = animator.GetBool("light");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!light)
            {
                animator.SetBool("light", true);
                  Effect2.SetActive(false);
            }
        }
        if (Input.anyKeyDown)
        {
            if (light)
            {
                animator.SetBool("light", false);
                if (Effect2.activeSelf)
                {
                    Effect2.SetActive(false);
                }
            }
        }

   
   
}}