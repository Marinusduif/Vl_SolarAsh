using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    public CharacterController characterController;
    public float grav = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;

    bool isGrounded;
    int jumpsMade = 0;

    Vector3 velocity;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            jumpsMade = 0; // Reset jumps when grounded
        }

        velocity.y += grav * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && (isGrounded || jumpsMade < 1))
        {
            if (isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * grav);
            }
            else
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * grav);
                jumpsMade++;
            }
        }
    }
}

