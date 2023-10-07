using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.AddForce((2*transform.forward+2*transform.up) * 100.0f, ForceMode.Force);
    }
}
