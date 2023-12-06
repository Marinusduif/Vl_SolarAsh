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

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ani.SetTrigger("Attack");
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            ani.SetTrigger("Walking");
        }
        else
        {
            ani.SetTrigger("Idle");
        }
    }
}
