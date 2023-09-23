using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCube : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    private Vector3 startPosition;

    private int step = 0;

    public int direction_X=1, direction_Y=1,direction_Z=1;    

    public float path_X,path_Y,path_Z = 3.0f;
    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (step == 0)
        {
            transform.Translate(new Vector3(0, 0, direction_Z) * moveSpeed * Time.deltaTime);
            if (Mathf.Abs(Mathf.Abs(startPosition.z) - Mathf.Abs(transform.position.z)) > path_Z)
            {
                step = 1;
            }         
        }

        if (step == 1)
        {
            transform.Translate(new Vector3(direction_X, 0, 0) * moveSpeed * Time.deltaTime);
            if ((Mathf.Abs(Mathf.Abs(startPosition.x) - Mathf.Abs(transform.position.x)) > path_X))
            {
                step = 2;
            }
        }
        if (step == 2)
        {
            transform.Translate(new Vector3(0, direction_Y, 0) * moveSpeed * Time.deltaTime);
            if ((Mathf.Abs(Mathf.Abs(startPosition.y) - Mathf.Abs(transform.position.y)) > path_Y))
            {
                step = 3;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            transform.position = startPosition;
            step = 0;
        }
    }
}

