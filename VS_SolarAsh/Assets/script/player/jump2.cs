using System.Collections;
using UnityEngine;

public class jump2 : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] private float gravity = 9.807f;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float jumpDecrese = 0.5f;
    [SerializeField] private int jumps;
    [SerializeField] private float downVel;
    [SerializeField] private bool jumping;
    [SerializeField] private bool onGround;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 1.5f, LayerMask.GetMask("isGround"))) onGround = true;
        else onGround = false;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);

        if (!onGround)
        {
            downVel -= Time.deltaTime * gravity;
        }

        if (onGround)
        {
            jumps = 2;
        }
        else if (!jumping || jumps > 1)
        {
            downVel = -0.5f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumps--;
                downVel = jumpHeight;
                StartCoroutine(Jump());
            }
        }
        controller.Move(transform.up * downVel);
    }
    private IEnumerator Jump()
    {
        jumping = true;
        yield return new WaitForSeconds(0.5f);
        jumping = false;
    }
}
