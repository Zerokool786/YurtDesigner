using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 distance;
    float posX;
    float posY;
    [SerializeField]Camera camera1;

    private void OnMouseDown()
    {
        distance = camera1.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - distance.x;
        posY = Input.mousePosition.y - distance.y;
    }

    private void OnMouseDrag()
    {
        Vector3 cursorPosition = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, distance.z);

        Vector3 worldPos = camera1.ScreenToWorldPoint(cursorPosition);
        transform.position = worldPos;
    }
}
