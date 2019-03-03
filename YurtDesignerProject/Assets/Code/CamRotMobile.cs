using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotMobile : MonoBehaviour
{
   
    private float _sensitivity;
    private Vector2 _touchReference;
    private Vector2 _touchOffset;
    private Vector3 _rotation;
    private bool _isRotating;
    GameObject pivot;
    public bool notZooming = true;

    void Start()
    {
        _sensitivity = 0.3f;
        _rotation = Vector3.zero;
        pivot = gameObject;
    }

    void FixedUpdate()
    {
        if(notZooming == false)
        {
            _isRotating = false;
        }

        if (_isRotating && Input.touchCount == 1 && notZooming == true)
        {

            _touchOffset = (Input.touches[0].position - _touchReference);


            _rotation.y = -(_touchOffset.x) * _sensitivity;
            _rotation.x = -(_touchOffset.y) * _sensitivity;


            transform.eulerAngles += _rotation;

            _touchReference = Input.touches[0].position;

            while (pivot.transform.eulerAngles.x > 83 && pivot.transform.eulerAngles.x < 120)
            {
                _isRotating = false;
                transform.Rotate(-5, 0, 0);
            }
            while (pivot.transform.eulerAngles.x > 270 && pivot.transform.eulerAngles.x < 300)
            {
                _isRotating = false;
                transform.Rotate(+5, 0, 0);
            }
        }
    }

    void OnMouseDown()
    {

        _isRotating = true;


        _touchReference = Input.touches[0].position;
    }

    void OnMouseUp()
    {

        _isRotating = false;
    }
}
