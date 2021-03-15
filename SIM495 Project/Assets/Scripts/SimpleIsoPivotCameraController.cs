using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleIsoPivotCameraController : MonoBehaviour
{
    public float slewSpeed = 5f;
    public float rotationRate = 5f;
    public float zoomSpeed = 5f;
    Camera childCam;
    float rotY;
    // Start is called before the first frame update
    void Start()
    {
        childCam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //float rotY = transform.rotation.y;
        float rotDirection = 0;
        
        //float scrollSpeed = Input.GetAxis("Mouse ScrollWheel");
        //childCam.orthographicSize += Mathf.Clamp(scrollSpeed * -zoomSpeed, 10, 70);
        if (Input.GetKey(KeyCode.Q))
            rotDirection = 1;
        if (Input.GetKey(KeyCode.E))
            rotDirection = -1;
        rotY += rotDirection * rotationRate;
        Vector3 dir = transform.right * x + transform.forward * z;
        transform.position += dir * slewSpeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotY, 0);
    }
}
