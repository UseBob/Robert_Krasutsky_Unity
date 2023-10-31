using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float jumpForce = 60.0f;

    private Rigidbody2D body;
    public Button buttonReset;

    private bool isJumping;
    public static bool isDead;
    private float moveHorizontal;
    private float moveVertical;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isDead)
        {
            buttonReset.gameObject.SetActive(true);
            transform.position = new Vector2(-2,2);
        }


        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (moveHorizontal>0.1f || moveHorizontal < -0.1f) 
        {
           body.AddForce(new Vector2(moveHorizontal * moveSpeed,0f),ForceMode2D.Impulse);
        }

        if (!isJumping && moveVertical > 0.1f)
        {
            body.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Platform") 
        {
            isJumping = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Debug.Log("sf");
            isJumping = true;
        }

        if (collision.gameObject.tag == "Trap")
        {
            isDead = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Trap")
        {
            isDead = true;
        }
    }

}
