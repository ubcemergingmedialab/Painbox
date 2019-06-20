using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {
    Animator animator, BackMenuAnimator;
    Animation CurrentAnimation;
    GameObject HorizontalRuler;
    GameObject VerticalRuler;
    GameObject globalVarC;
    int TapOnlyOnce = 0;
 


    void Start()
    {
        
        BackMenuAnimator = GameObject.FindGameObjectWithTag("Panel").GetComponent<Animator>();
        animator = GetComponent<Animator>();
        HorizontalRuler = GameObject.FindGameObjectWithTag("HorizontalRuler");
        VerticalRuler = GameObject.FindGameObjectWithTag("VerticalRuler");
        /*GameObject.Find("HorizontalRuler").transform.localScale = new Vector3(0, 0, 0);
        print(GameObject.Find("HorizontalRuler").name);*/

        VerticalRuler.GetComponent<MeshRenderer>().enabled = false;
        HorizontalRuler.GetComponent<MeshRenderer>().enabled = false;


    }
    void Update () {

        int a = Input.touchCount ;
        if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount == 1 && (Input.GetTouch(0).phase == TouchPhase.Began))) && PlayerPrefs.GetInt("Vertical") == 1
            && TapOnlyOnce == 0)
        {
            VerticalRuler.GetComponent<MeshRenderer>().enabled = true;
            HorizontalRuler.GetComponent<MeshRenderer>().enabled = false;

            animator.Play("VerticalStab");
            StartCoroutine(BackMenuAnimation());
            TapOnlyOnce = 1;
        }


        if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount == 1 && (Input.GetTouch(0).phase == TouchPhase.Began))) && PlayerPrefs.GetInt("Horizontal") == 1
            && TapOnlyOnce == 0)
        {

            VerticalRuler.GetComponent<MeshRenderer>().enabled = false;
            HorizontalRuler.GetComponent<MeshRenderer>().enabled = true;

            animator.Play("HorizontalStab");
            StartCoroutine(BackMenuAnimation());
            TapOnlyOnce = 1;


        }


    }
    //Coroutine exists so that it activates the return menu, five seconds after animation is triggered
    IEnumerator BackMenuAnimation()
    {
        
        yield return new WaitForSecondsRealtime(5f);
        BackMenuAnimator.Play("BackMenuActivate");
        TapOnlyOnce = 0;

    }

    /*
    void HandAnimationEnded()
    {
        animationTrigger = !animationTrigger;
        if (animationTrigger)
        {
            BackMenuAnimator.Play("BackMenuActivate");
        }
  
    }
    */

}
