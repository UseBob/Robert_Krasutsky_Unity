using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoForce : MonoBehaviour
{
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(transform.forward * 100.0f, ForceMode.Impulse);
    }
    private void FixedUpdate()
    {
        //body.AddForce(transform.forward*10.0f, ForceMode.Impulse);
    }
}
