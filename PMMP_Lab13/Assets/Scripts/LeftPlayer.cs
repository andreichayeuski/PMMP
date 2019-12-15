﻿using UnityEngine;

public class LeftPlayer : MonoBehaviour
{
    public float Speed = 20f;
    float positionY = 1;
    float positionX = 1;
    void Start()
    {
    }

    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * Speed);
            positionY = 10;
            positionX = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * Speed);
            positionY = -10;
            positionX = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * Speed);
            positionX = -10;
            positionY = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * Speed);
            positionX = 10;
            positionY = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D myCollision)
    {
        if (myCollision.gameObject.name == "Puck")
        {
            myCollision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(positionX, positionY), ForceMode2D.Impulse);
        }
    }
}
