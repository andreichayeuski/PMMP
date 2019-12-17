using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayer : MonoBehaviour
{
    public float Speed = 20f;
    float positionY = 1;
    float positionX = 1; 
    private Rigidbody2D rb;
    private Vector2 startingPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;
    }

    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * Speed);
            positionY = 10;
            positionX = 0;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * Speed);
            positionY = -10;
            positionX = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * Speed);
            positionX = -10;
            positionY = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow))
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
    public void ResetPosition()
    {
        rb.position = startingPosition;
    }
}
