using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyyyy : MonoBehaviour
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
        Destroy(myCollision.gameObject, .5f);
    }
}
