using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMng : MonoBehaviour
{ 
    public float rotSpeed = 1.0f;

    public Camera fpsCam;

 

    void Update()
    { 
        RotCtrl();
    }

    

    void RotCtrl()
    { //마우스 회전 시점이동 함수
        float rotX = Input.GetAxis("Mouse Y") * rotSpeed;
        float rotY = Input.GetAxis("Mouse X") * rotSpeed;

        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
        fpsCam.transform.localRotation *= Quaternion.Euler(-rotX, 0, 0);
    }
}
