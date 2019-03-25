using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 distance;
    float posX;
    float posY;
    float smooth = 5.0f;
    float tiltAngle = 60.0f; 
    float rotateSpeed = 180;
    Camera camera1;

    private void Start()
    {
        camera1 = GameObject.Find("BuilderCam").GetComponent<Camera>();
    }
   

 
    private void OnMouseDown()
    {
        distance = camera1.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - distance.x;
        posY = Input.mousePosition.y - distance.y;
    }

    private void OnMouseDrag()
    {

        //float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad; //smooth bug while drag and rotation 
        //float rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;

        {
            Vector3 cursorPosition = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, distance.z);

            Vector3 worldPos = camera1.ScreenToWorldPoint(cursorPosition);
            transform.position = worldPos;
        }

        //transform.Rotate(Vector3.up, -rotX);
        //transform.Rotate(Vector3.down, rotY);

    }
}
