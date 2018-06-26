using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehaviour : MonoBehaviour {

    private MeshCollider KnifeCollider;
    private Vector3 KnifePosition;



    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balloon")
        {
            print("Testing");
            Destroy(other.gameObject);
        }
    }
}
