using UnityEngine;

public class grind1 : MonoBehaviour
{
    private CharacterController controller;
    private movement3 movement;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        movement = GetComponent<movement3>();
    }

    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "rail")
        {
            movement.enabled = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "rail")
        {
            movement.enabled = true;
        }
    }
}
