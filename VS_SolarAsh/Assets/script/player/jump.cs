using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private int jumps;
    [SerializeField] private float jump_height;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jumps > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = transform.up * 0;
            rb.AddForce(transform.up * jump_height);
            jumps -= 1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
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
