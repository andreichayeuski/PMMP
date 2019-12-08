using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Begin.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "Floor")
        {
            Debug.Log("Hit the floor.");
        }
        else if (myCollision.gameObject.name.Contains("Wall"))
        {
            Debug.Log("Hit the wall.");
        }
    }
}
