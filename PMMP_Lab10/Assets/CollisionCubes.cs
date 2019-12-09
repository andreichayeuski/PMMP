using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name != "Plane")
        {
            myCollision.gameObject
                .GetComponent<Rigidbody>().AddForce(0, 0, 1000);
        }
    }
}
