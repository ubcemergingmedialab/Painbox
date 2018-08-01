using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {
    Animator animator;


    // Update is called once per frame

    private void Start()
    {

        animator = GetComponent<Animator>();
    }
    void Update () {

        //Vertical Swing
        if (Input.GetKeyDown("1"))
        {
          
            print("1");
            animator.SetInteger("Hand State", 1);
        }
        //Horizontal Stab
        if (Input.GetKeyDown("2"))
        {
            animator.SetInteger("Hand State", 2);
        }
        //Vertical Stab
        if (Input.GetKeyDown("3"))
        {
            animator.SetInteger("Hand State", 3);
            //     animator.GetCurrentAnimatorClipInfo
        }
        if (Input.GetKeyDown("0"))
        {
            animator.SetInteger("Hand State", 0);
        }
       
    }
}
