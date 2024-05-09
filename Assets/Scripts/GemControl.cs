using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GemControl : XRGrabInteractable
{
    [SerializeField] private GemManager gemManager;
    [SerializeField] private TouchControl touch;
    [SerializeField] private Seal seal;

    public float Distance => Vector3.Distance(transform.position, seal.transform.position);

    [SerializeField] private bool isRotating;

    [SerializeField] private bool isInToSeal;

    [SerializeField] private bool isInserting;

    public int gemIndex;

    private void Start()
    {
      gemManager.Init(gemIndex,transform);
    }


    private void Update()
    {
        // if (Input.GetMouseButton(0))
        // {
        //     touch.Rotate();
        //
        // }
        isInToSeal = Distance <= 0.2f;
        if (!isHovered)
        {
            isRotating = !isInToSeal;

            if (!isInToSeal)
            {
                if (isRotating) touch.AutoRotate();
            }
            else
            {
                if (transform.childCount > 0 && !isInserting)
                {
                    seal.InsertGem(gemIndex , this);
                    isInserting = true;
                }
            }
           
        }
        // print(Distance);
    }

    public void RemoveFromPool()
    {
        gemManager.RemoveFromGemPool();
    }
}