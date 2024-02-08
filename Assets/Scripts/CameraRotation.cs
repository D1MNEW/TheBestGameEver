using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float SpeedRotation;
    public Transform CameraAxisTransform;

    public float minAngle;
    public float maxAngle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * SpeedRotation* Input.GetAxis("Mouse X"), 0);

        var NewAngleX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * SpeedRotation * Input.GetAxis("Mouse Y");

        if (NewAngleX > 180)
            NewAngleX -= 360;
        NewAngleX = Mathf.Clamp(NewAngleX, minAngle, maxAngle);

        CameraAxisTransform.localEulerAngles = new Vector3(NewAngleX, 0, 0);
    }
}