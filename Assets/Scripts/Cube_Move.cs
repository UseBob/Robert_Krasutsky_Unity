using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Move : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    private Vector3 startPosition;

    private int step = 0;

    public int path_X=3;

    public int path_Y = 3;

    public int path_Z = 3;

    private void Start()
    {
        startPosition= transform.position;
    }

    private void Update()
    {
        if (step==0)
        {
            transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
            if (Mathf.Abs(Mathf.Abs(startPosition.x) - Mathf.Abs(transform.position.x)) >= path_X)
            {
                step++;
            }
        }

        if (step == 1)
        {
            transform.Translate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime);
            if (Mathf.Abs(Mathf.Abs(startPosition.y) - Mathf.Abs(transform.position.y)) >= path_Y)
            {
                step++;
            }
        }

        if (step == 2)
        {
            transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);
            if (Mathf.Abs(Mathf.Abs(startPosition.z) - Mathf.Abs(transform.position.z)) >= path_Z)
            {
                step++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = startPosition;
            step = 0;
        }
    }
}
