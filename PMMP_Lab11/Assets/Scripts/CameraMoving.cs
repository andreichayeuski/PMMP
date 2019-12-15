using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    void Start()
    {
        Speed = 15f;
    }
    public float Speed = 15f;
    private bool rotate = false;
    float moveY, moveX;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
        if (Input.GetMouseButtonDown(1))
        {
            rotate = true;
            Cursor.visible = false;
        }
        if (Input.GetMouseButtonUp(1))
        {
            rotate = false;
            Cursor.visible = true;
        }
        if (rotate)
        {
            moveY -= Input.GetAxis("Mouse Y") * 3;
            moveX += Input.GetAxis("Mouse X") * 3;
            transform.rotation = Quaternion.Euler(moveY, moveX, 0);
        }
    }
}
