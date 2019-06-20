using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenuAnimatorScript : MonoBehaviour {

    Animator BackMenuAnimator;

    private void Start()
    {
        BackMenuAnimator = GetComponent<Animator>();

        
    }

    public void AnimationEnded()
    {
        print("Prints only once");
        BackMenuAnimator.Play("BackMenuOn");
    }
}
