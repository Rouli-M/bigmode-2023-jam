using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera mainCamera;
    [SerializeField]
    Vector3 customRotate;
    [SerializeField] bool custom=false;
    void Start()
    {
        mainCamera = Camera.main;
    }
    void LateUpdate()
    {
        transform.LookAt(mainCamera.transform);
        if (!custom)
            transform.Rotate(0, 180, 0);
        else
            transform.Rotate(customRotate);
    }
}
