using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_Rotate : MonoBehaviour
{
    public float rotateSpeed = 2.0f;

    public Vector3 directionRotate= new Vector3 (0,1,0);

    private bool enabl=true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enabl = !enabl;
        }
        if (enabl)  
        {
            transform.Rotate(directionRotate, rotateSpeed*Time.deltaTime);
        }
    }
}
