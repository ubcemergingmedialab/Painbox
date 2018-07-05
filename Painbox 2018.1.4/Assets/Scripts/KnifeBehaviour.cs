using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : MonoBehaviour {

    private MeshCollider KnifeCollider;
    private Vector3 KnifePosition;
    public Texture Damage;
    Renderer BalloonRenderer;



    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balloon")
        {
            BalloonRenderer = GetComponent<Renderer>();

            BalloonRenderer.material.EnableKeyword("_NORMALMAP");
            BalloonRenderer.material.EnableKeyword("_METALLICGLOSSMAP");

            BalloonRenderer.material.SetTexture("MainTex",Damage);


            print("Testing");
          //  other.GetComponent < Material > = a;
        }
    }
}
