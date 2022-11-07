using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
// {
//     public float mouseSensitivity = 50f;
    
//     public Transform playerBody;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float mouseX = Input.GetAxis("Mouse X") + mouseSensitivity + Time.deltaTime;
//         float mouseY = Input.GetAxis("Mouse Y") + mouseSensitivity + Time.deltaTime;

//         playerBody.Rotate(Vector3.up * mouseX);
//     }
// }
 
{
    float xRotation = 0f;
    public Vector2 turn;
    public float sensitivity = 50;
    public Vector3 deltaMove;
    public float speed = 1;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);
    }
}