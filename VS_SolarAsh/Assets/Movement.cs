using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 1000f;
    [SerializeField] private float rotSpeed = 200f;
    public bool isMoving;
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        isMoving = false;
    }

    // Update is called once per frame
    private void Update()
    {
        Moving();

        if(Input.GetKeyDown(KeyCode.W)) 
        { 
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        /*if(isMoving == true  && Input.GetKeyDown(KeyCode.LeftShift)) 
        { 
            Sprinting();
        }*/

           
            
    }

    public void Moving()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
    }

    /*public void Sprinting()
    {
        float speed2 = 1500f;
        float rotSpeed2 = 100f;
        float move2 = Time.deltaTime * speed2 * Input.GetAxis("Vertical");
        Vector3 lastVel2 = rb.velocity;
        Vector3 newVel2 = rb.transform.forward * move2;
        newVel2.y = lastVel2.y;
        rb.velocity = newVel2;
        float rot2 = Input.GetAxis("Horizontal") * rotSpeed2 * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot2, 0));
    }*/
}