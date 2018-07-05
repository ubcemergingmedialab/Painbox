using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : MonoBehaviour {

    private MeshCollider KnifeCollider;
    private Vector3 KnifePosition;
    public Texture Damage;
    Renderer BalloonRenderer;






    // Update is called once per frame
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

    public void OnCollisionEnter(Collision collision)
    {


        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(collision.contacts[0].point - collision.contacts[0].normal, collision.contacts[0].normal);
        if (Physics.Raycast(ray, out hit))
        {

            print(hit.textureCoord);
        }
    }
}
