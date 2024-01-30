using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    [SerializeField] private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        ani.SetFloat("Speed", 0f);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger("Jump");
        }
        else if (!Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            resetBools();
            //ani.SetFloat("Speed", 0.5f);
            ani.SetBool("Walking", true);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            resetBools();
            //ani.SetFloat("Speed", 1f);
            ani.SetBool("Sprinting", true);
        }
        else
        {
            resetBools();
            ani.SetTrigger("Idle");
        }
    }

    private void resetBools()
    {
        ani.SetBool("Sprinting", false);
        ani.SetBool("Walking", false);
        //ani.SetFloat("Speed", 0f);
        ani.ResetTrigger("Jump");
        ani.ResetTrigger("Idle");
    }
}
