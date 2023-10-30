using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaRun : MonoBehaviour
{
    public float speed = 5.0f;


    private SpriteRenderer spriteRenderer;
    public float direction=1.0f;
    public GameObject endPos;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction *= -1.0f;
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        transform.position += new Vector3(direction, 0, 0) * Time.deltaTime * speed;
    }
}
