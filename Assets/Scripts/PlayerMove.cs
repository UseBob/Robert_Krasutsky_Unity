using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float gravity = 20.0f;
    public float jumpSpeed = 8.0f;

    private CharacterController characterController;
    private Vector3 moveDirection= Vector3.zero;
    [SerializeField]private Light spotLight;
    private AudioSource audioSource;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float rotationX = Input.GetAxis("Mouse X");

        if (characterController.isGrounded) 
        {
             moveDirection =
                transform.TransformDirection(new Vector3(horizontal, 0, vertical));

            moveDirection *= moveSpeed;
      
            if (vertical != 0 && characterController.isGrounded || horizontal != 0 && characterController.isGrounded )
            {
                
                audioSource.volume = 1;
            }
            else 
            {
                audioSource.volume = 0;
            }


            if (Input.GetButton("Jump")) 
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y-=gravity*Time.deltaTime;

        characterController.transform.Rotate(Vector3.up, rotationX);

        characterController.Move(moveDirection*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.F))
        {
            spotLight.enabled=!spotLight.enabled;
        }
    }

}
