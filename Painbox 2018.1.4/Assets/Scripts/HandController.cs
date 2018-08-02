using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {
    Animator animator;
    Animation CurrentAnimation;

    int VerticalSwing = Animator.StringToHash("VS");
    int VerticalStab = Animator.StringToHash("VST");

    int HorizontalStab = Animator.StringToHash("HS");





    // Update is called once per frame

    private void Start()
    {
        

        animator = GetComponent<Animator>();
        print("Should say 0: " + animator.GetCurrentAnimatorClipInfo(0).Length);


    }
    void Update () {

       
        //Vertical Swing
       
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            print("q");
            animator.SetTrigger(VerticalStab);
           


        }
        //Horizontal Stab
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("w");

            animator.SetTrigger(VerticalSwing);
        }
        //Vertical Stab
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("e");

            animator.SetTrigger(HorizontalStab);
            //     animator.GetCurrentAnimatorClipInfo
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("r");
            animator.SetInteger("Hand State", 0);
        }
       
    }
}
