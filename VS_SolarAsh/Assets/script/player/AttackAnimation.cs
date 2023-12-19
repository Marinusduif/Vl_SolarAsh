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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.LeftShift))
        {
            resetBools();
            ani.SetBool("Walking", true);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            resetBools();
            ani.SetBool("Sprinting", true);
        }
        else
        {
            ani.SetTrigger("Idle");
            resetBools();
        }
    }

    private void resetBools()
    {
        ani.SetBool("Sprinting", false);
        ani.SetBool("Walking", false);
    }
}
