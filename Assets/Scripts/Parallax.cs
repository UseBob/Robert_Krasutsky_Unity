using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera cam;
    public float parallax;


    private float startPos;

    private void Start()
    {
        startPos = transform.position.x;
    }

    private void Update()
    {
        float distX = (cam.transform.position.x*(1-parallax));

        transform.position = new Vector3(startPos + distX,transform.position.y,transform.position.z);
    }
}
