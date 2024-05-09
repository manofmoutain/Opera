using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class TouchControl
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject gem;
    public void Rotate()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        
        float xAngle = Input.GetAxis("Mouse Y") * speed * 80;
        float yAngle = -Input.GetAxis("Mouse X") * speed * 80;
        float zAngle = 0;

        gem.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }


    public void AutoRotate()
    {
        gem.transform.Rotate(0, speed * 0.01f, 0, Space.World);
    }
}
