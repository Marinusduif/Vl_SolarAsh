using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float sprintMult = 2f;
    [SerializeField] private float rotSpeed = 50f;
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float move = speed * Input.GetAxis("Vertical");
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            newVel = rb.transform.forward * move * sprintMult * Time.deltaTime;
        }
        else
        {
            newVel = rb.transform.forward * move * Time.deltaTime;
        }
        newVel.y = lastVel.y;
        rb.velocity = newVel;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
    }

    
}