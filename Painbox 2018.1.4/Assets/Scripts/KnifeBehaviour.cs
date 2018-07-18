using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : MonoBehaviour {

    private MeshCollider KnifeCollider;
    private Vector3 KnifePosition;
    
    private Rigidbody knifeBody;
    private Texture2D OtherTexture;
    private ContactPoint[] pointsOfContactWithSphere;

    public Texture Damage;
    Renderer BalloonRenderer;





    private void Start()
    {
        if(knifeBody.velocity.x > 0)
        {
            print("MOvement!");
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        print(other.collider.gameObject.tag);
        if (other.collider.gameObject.tag == "Balloon")
        {
            print("Before the for loop");
            pointsOfContactWithSphere = other.contacts; // getting the points of contact of the collision
           
            OtherTexture = (Texture2D)other.collider.gameObject.GetComponent<Renderer>().material.mainTexture;

            for(int i = 0; i < pointsOfContactWithSphere.Length; i++)
            {
                //print(pointsOfContactWithSphere[i].normal.x);
                Debug.DrawRay(pointsOfContactWithSphere[0].point, pointsOfContactWithSphere[0].normal, Color.white,5,false);
               // OtherTexture.SetPixel((int)pointsOfContactWithSphere[i].point.x, (int)pointsOfContactWithSphere[i].point.y, new Color(0,0,0));
            }

            print("Inside for loop");
            //Destroy(other.collider.gameObject);
        }
        print("Testing");
    }

   /* private void OnTriggerEnter(SphereCollider other)

    /* private void OnTriggerEnter(Collider other)
     {
         if (other.tag == "Balloon")
         {



             //BalloonRenderer = other.gameObject.GetComponent<Renderer>();



             // BalloonRenderer.material = Damage;


             // BalloonRenderer.material.EnableKeyword("_NORMALMAP");
             // BalloonRenderer.material.EnableKeyword("_METALLICGLOSSMAP");

             //BalloonRenderer.material.mainTexture = Damage;


             //print("Testing");
         }
     }*/

    


     
    }

