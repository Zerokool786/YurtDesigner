using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    private float _sensitivity;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;
    private bool _isRotating;
    GameObject pivot;

    void Start()
    {
        _sensitivity = 0.3f;
        _rotation = Vector3.zero;
        pivot = gameObject;
    }

    void FixedUpdate()
    {
        if (_isRotating)
        {
            
            _mouseOffset = (Input.mousePosition - _mouseReference);


            _rotation.y = -(_mouseOffset.x) * _sensitivity;
            _rotation.x = -(_mouseOffset.y) * _sensitivity;
         
            
            transform.eulerAngles += _rotation;
            
            _mouseReference = Input.mousePosition;

            while(pivot.transform.eulerAngles.x > 83 && pivot.transform.eulerAngles.x < 120)
            {
                _isRotating = false;
                transform.Rotate(-5, 0, 0);
            }
            while(pivot.transform.eulerAngles.x > 270 && pivot.transform.eulerAngles.x < 300)
            {
                _isRotating = false;
                transform.Rotate(+5, 0, 0);
            }
        }
    }

    void OnMouseDown()
    {
        
        _isRotating = true;

        
        _mouseReference = Input.mousePosition;
    }

    void OnMouseUp()
    {      
        _isRotating = false;
    }


}
