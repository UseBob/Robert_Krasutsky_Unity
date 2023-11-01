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
    private Collider2D collider;

    
    private float scaleTime;
    

    private void Start()
    {
        collider=GetComponent<Collider2D>();
        endPosition =point2.transform.position;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player" && this.collider.tag!="Platform")
        {
            collider.enabled = false;
            Destroy(gameObject.GetComponent<movePlatform>());   
        }  
    }
}
