using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
            ani.SetBool("Sprinting", false);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !Input.GetKeyDown(KeyCode.LeftShift))
        {
            ani.SetBool("Walking", true);
            ani.SetTrigger("Walking1");
            ani.SetBool("Sprinting", false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ani.SetBool("Sprinting", true);
            ani.SetBool("Walking", false);
            ani.SetBool("Walking2", false);
        }
        else
        {
            ani.SetTrigger("Idle");
            ani.SetBool("Sprinting", false);
            ani.SetBool("Walking", false);
            ani.SetBool("Walking2", false);
        }
    }

}
