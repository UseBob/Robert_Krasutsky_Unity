using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class movePlatform : MonoBehaviour
{
    public float distanceTime=3.0f;

    public GameObject point1;
    public GameObject point2;
    private Vector3 startPosition;
    private Vector3 endPosition;

    
    private float scaleTime;
    

    private void Start()
    {
        endPosition=point2.transform.position;
        startPosition = transform.position;
    }

    private void Update()
    {
        scaleTime += Time.deltaTime;
        float ChangeTime = scaleTime / distanceTime;

        transform.position = Vector3.Lerp(startPosition, endPosition, ChangeTime);

        if (ChangeTime >=1.0f )
        {
            startPosition=transform.position;
            scaleTime = 0f;
            if (endPosition==point2.transform.position)
            {
                endPosition = point1.transform.position;
            }
            else
            {
                endPosition = point2.transform.position;
            }
        }
    }
}
