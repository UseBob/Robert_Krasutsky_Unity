using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GrenadeForce : MonoBehaviour
{
    Rigidbody rb;
    private float mult=12.0f;
    private Vector3 explosionPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce((2*transform.forward+3*Vector3.up) * mult,ForceMode.Acceleration);
        if (transform.position.y>3.0f)
        {
            mult = -2.0f;
        }

        for (int i = 1; i < transform.childCount; i++)
        {
            if (Vector3.Distance(transform.GetChild(i).position, explosionPos)>11 && explosionPos!=default)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag!= "GrenadePart")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            explosionPos = transform.position;
            for (int i = 1; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                transform.GetChild(i).GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), Random.Range(-2, 2)) * 30.0f, ForceMode.VelocityChange);
            }
        }
    }
}
