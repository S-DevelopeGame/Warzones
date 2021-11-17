using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnY : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 1f;

    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");
        Debug.Log("mouse y = " + _mouseY);
        Vector3 rotation = transform.localEulerAngles;
        rotation.x -= _mouseY * _speedRotation;
        transform.localEulerAngles = rotation;
    }
}
