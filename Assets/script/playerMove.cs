using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speedRotation=5.0f;

    public float moveSpeed = 3.5f;

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float sideForce = Input.GetAxis("Horizontal") * speedRotation;
        if (sideForce!=0)
        {
            rb.angularVelocity = new Vector3(0.0f, sideForce, 0.0f);
        }

        float forwardForce = Input.GetAxis("Vertical") * moveSpeed;
        if (forwardForce!=0)
        {
            rb.velocity = rb.transform.forward * forwardForce;
        }
    }
}
