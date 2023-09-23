using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedScale=3.0f;

    private Vector3 firstScale;

    private Vector3 startPosition;

    private Vector3 changeScale=new Vector3(0.15f,0.15f,0.15f);

    private float mult = 0.5f;

    private bool nextStep=false;

    public float delay=1.0f;

     void Start()
    {
        firstScale= transform.localScale;
        startPosition= transform.position;
    }

     void Update()
    {
        if (nextStep==false)
        {
            transform.localScale -= changeScale * speedScale * Time.deltaTime * mult;
            mult += 0.1f;
            if (transform.localScale.x <= 0)
            {
                transform.position = startPosition + new Vector3(Random.Range(0, 4), Random.Range(0, 3), Random.Range(0, 4));
                nextStep = true;
            }
        }

        if (transform.localScale.x <= firstScale.x && nextStep==true)
        {
            transform.localScale += changeScale * speedScale * Time.deltaTime;
            if (transform.localScale.x >= firstScale.x)
            {
                Invoke("Delay", delay);
            }
        }
    }
    void Delay() 
    {
        Debug.Log("2src");
        nextStep = false;
        mult = 0.5f;
    }
}
