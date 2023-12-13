using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private int jumps;
    [SerializeField] private float jump_height;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (jumps > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            if (jumps == 2)
            {
                rb.velocity = transform.up * 0;
                rb.AddForce(transform.up * jump_height);
            }
            else
            {
                rb.velocity = transform.up * 0;
                rb.AddForce(transform.up * jump_height / 2);
            }
            jumps -= 1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumps = 2;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumps = 1;
        }
    }
}
