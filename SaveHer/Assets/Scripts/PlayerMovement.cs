using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // gravity part
    public CharacterController controller;
    
    public float gravity,jumpHeight;

    public Transform groundCheck;
    public float groundSize;
    public LayerMask groundMask;
    public int jumpQuantity;


    public Vector3 velocityVector;
    public bool isGrounded;
    public int jumpCount;

    // Horizontal Move
    public float velocity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundSize, groundMask);

        if(isGrounded && velocityVector.y < 0)
        {
            velocityVector.y = -2f;
            jumpCount = jumpQuantity;
        }

        if (Input.GetButtonDown("Jump") && (isGrounded))
        {
            velocityVector.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        else if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            jumpCount--;
            velocityVector.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            velocityVector.x = velocity * Time.deltaTime * Input.GetAxis("Horizontal");
        }
        else if (Input.GetAxis("Horizontal") < -0.1f)
        {
            velocityVector.x = velocity * Time.deltaTime * Input.GetAxis("Horizontal");
        }
        else
        {
            velocityVector.x = 0;
        }


        velocityVector.y += gravity * Time.deltaTime;

        controller.Move(velocityVector * Time.deltaTime);


    }
}
