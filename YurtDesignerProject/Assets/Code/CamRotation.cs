using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    float pitch, yaw;
    [SerializeField] float speed = 400;

    void OnMouseDrag()
    {

        float mouseX = -Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float rotAmountX = mouseX * Time.deltaTime * speed;
        float rotAmountY = mouseY * Time.deltaTime * speed;

        pitch = Mathf.Clamp(pitch - rotAmountY, -80f, 80f);
        yaw += rotAmountX;

        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);

    }

}
