using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    public float rotateSpeed = 3.0f;
    
    public Vector3 directionRotate= Vector3.up;

    private bool enableRotate=false;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            enableRotate = !enableRotate;
        }
        if (enableRotate==true)
            transform.Rotate(directionRotate*rotateSpeed*Time.deltaTime);
    }
}
