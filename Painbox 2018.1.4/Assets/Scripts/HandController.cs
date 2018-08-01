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
        if (Input.GetKeyDown("1"))
        {
            print("1");
            animator.SetInteger("HandState", 1);
        }
        if (Input.GetKeyDown("2"))
        {
            animator.SetInteger("HandState", 2);
        }
        if (Input.GetKeyDown("3"))
        {
            animator.SetInteger("HandState", 3);
            //     animator.GetCurrentAnimatorClipInfo
        }
        if (Input.GetKeyDown("0"))
        {
            animator.SetInteger("HandState", 0);
        }
    }
}
