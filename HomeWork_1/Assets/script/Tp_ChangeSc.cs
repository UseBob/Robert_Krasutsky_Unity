using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_ChangeSc : MonoBehaviour
{
    public float speedScale = 1.0f;

    private Vector3 firstScale;
    private Vector3 startPosition;

    private bool nextPosition;

    private Vector3 changeScale = new Vector3(0.15f, 0.15f, 0.15f);

    private float multSpeed = 0.1f;

    public float delayTime=2.0f;

    private void Start()
    {
        firstScale=transform.localScale;
        startPosition=transform.position;
    }
    private void Update()
    {
        Teleport();
    }

    void Teleport()
    {
        if (transform.localScale.x >= 0 && nextPosition == false)
        {
            transform.localScale -= changeScale * speedScale * Time.deltaTime * multSpeed;
            multSpeed += 0.1f;
        }

        if (transform.localScale.x <= 0.2)
        {
            transform.position = startPosition + new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));
            nextPosition = true;
        }

        if (transform.localScale.x <= firstScale.x && nextPosition == true)
        {
            transform.localScale += changeScale * speedScale * Time.deltaTime * multSpeed;
            if (transform.localScale.x >= firstScale.x)
            {
                Invoke("Delay", delayTime);
            }
        }
    }
    void Delay()
    {
        nextPosition = false;
        multSpeed = 0.1f;
    }
}
