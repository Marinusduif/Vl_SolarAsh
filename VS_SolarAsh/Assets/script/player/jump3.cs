using UnityEngine;

public class jump3 : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float grav = -9.81f;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float jumpHeight = 3f;

    [SerializeField] private bool isGrounded;
    int jumpsMade = 0;

    Vector3 velocity;

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -5f;
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
                velocity.y = Mathf.Sqrt(jumpHeight * -1f * grav);
                jumpsMade++;
            }
        }
        if (Input.GetButtonUp("Jump") && (!isGrounded) && velocity.y > 0)
        {
            velocity.y /= 2;
        }
    }
}

