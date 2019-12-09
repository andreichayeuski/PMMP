using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Vector3 startPosition;
    private float positionGun;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.GetComponent<Rigidbody>().position;

        positionGun = -18.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space shot!");
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 100);
            /*GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(newX, newY, newZ);
            cube.transform.GetComponent<Renderer>().material.color = colors[colorSetter++ % colorsCount];
            cube.AddComponent<Rigidbody>();
            cube.name = $"Cube{colorSetter}";*/
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            positionGun -= 0.5f;
            transform.position = new Vector3(positionGun, 3.6f, -13.44f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            positionGun += 0.5f;
            transform.position = new Vector3(positionGun, 3.6f, -13.44f);

            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
           
    private void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name.Contains("Target"))
        {
            Destroy(myCollision.gameObject, .5f);
            gameObject.GetComponent<Rigidbody>().position = startPosition;
            gameObject.GetComponent<Rigidbody>().AddForce(0,0,0);
        }
    }
}
