using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public float sprintSpeed = 5.0f;
    public float animationBlendSpeed = 0.2f;
    public float rotationSpeed = 0.2f;
    public float jumpSpeed = 7.0f;

    private CharacterController characterController;
    private Camera characterCamera;
    private Animator anim;

    private float rotationAngle = 0.0f;
    private float targetAnimationSpeed = 0.0f;
    private bool isSprint=false;
    private bool isJumping=false;
    private float speedY = 0.0f;
    private float gravity = -9.81f;
        
    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        characterCamera = FindObjectOfType<Camera>();

        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            anim.SetTrigger("Jump");
            speedY += jumpSpeed;
        }
        if (!characterController.isGrounded)
        {
            speedY += gravity * Time.deltaTime;
        }
        else if(speedY<0.0f)
        {
            speedY = 0.0f;
        }
        anim.SetFloat("SpeedY",speedY/jumpSpeed);
        if (isJumping && speedY<0.0f)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position,Vector3.down,out hit,1f,LayerMask.GetMask("Default")))
            {
                Debug.Log("Ground");
                isJumping = false;
                anim.SetTrigger("Land"); 
            }
        }


        isSprint = Input.GetKey(KeyCode.LeftShift);

        Vector3 movement= new Vector3(horizontal,0,vertical);
        Vector3 rotadedMovement = 
            Quaternion.Euler(0.0f, characterCamera.transform.rotation.eulerAngles.y, 0.0f) * movement.normalized;
        Vector3 verticalMovement = Vector3.up * speedY;
        float currentSpead = isSprint ? sprintSpeed : movementSpeed;

        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Spawn") && !anim.GetBool("Dead"))
        {
            characterController.Move((verticalMovement+rotadedMovement * currentSpead )* Time.deltaTime);
        }
        

        if (rotadedMovement.sqrMagnitude>0.0f && !anim.GetBool("Dead"))
        {
            rotationAngle = Mathf.Atan2(rotadedMovement.x, rotadedMovement.z)*Mathf.Rad2Deg;
            targetAnimationSpeed=isSprint ? 1.0f : 0.5f;
        }
        else
        {
            targetAnimationSpeed= 0.0f;
        }
        anim.SetFloat("Speed",Mathf.Lerp(anim.GetFloat("Speed"),targetAnimationSpeed,animationBlendSpeed));

        Quaternion currenRotation = characterController.transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(0.0f,rotationAngle,0.0f);

        characterController.transform.rotation = Quaternion.Lerp(currenRotation,targetRotation,rotationSpeed);

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("Dead", true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            int rand = Random.Range(1, 4);
            anim.SetInteger("NumberPanch", rand);
            Debug.Log(rand);
            anim.SetTrigger("Punch");
        }
    }
}
