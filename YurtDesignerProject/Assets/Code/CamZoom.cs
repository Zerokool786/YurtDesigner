using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    private float zoomSpeed = 0.2f;
    [SerializeField]private CamRotMobile camRotMobile;
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2)
        {
            camRotMobile.notZooming = false;
            Touch touch01 = Input.GetTouch(0);
            Touch touch02 = Input.GetTouch(1);

            
            Vector2 touch01PrevPos = touch01.position - touch01.deltaPosition;
            Vector2 touch02PrevPos = touch02.position - touch02.deltaPosition;

            
            float prevTouchDeltaMag = (touch01PrevPos - touch02PrevPos).magnitude;
            float touchDeltaMag = (touch01.position - touch02.position).magnitude;
        
            
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            camera.fieldOfView += deltaMagnitudeDiff * zoomSpeed;
            
            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, 30f, 90f);

        }
        else
        {
            Invoke("ZoomingCoolDown", 0.1f);
        }
            
        
            


    }

    private void ZoomingCoolDown()
    {
        camRotMobile.notZooming = true;
    }
}
